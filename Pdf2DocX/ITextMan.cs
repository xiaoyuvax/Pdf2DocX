using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PDFConverter
{
    internal static class ITextMan
    {
        private const int MAX_PAGE_PER_FILE = 3;

        public static Action<float> WaterarkProgress;

        public static Color WaterMarkColor { get; set; } = Color.Black;
        public static int WaterMarkSize { get; set; } = 200;
        public static int WaterMarkFontSize { get; set; } = 24;
        public static float WaterMarkAlpha { get; set; } = 0.1f;
        public static int WaterMarkAngle { get; set; } = 45;

        public static bool WaterMarkPrintable { get; set; } = true;

        public static Bitmap GenerateWaterMarkBitmap(string text)
        {
            // 创建一个新的Bitmap对象
            int width = WaterMarkSize; //(int)(210 * 96 / 25.4f);
            int height = WaterMarkSize; //(int)(297 * 96 / 25.4f);
            Bitmap bmp = new(width, height);

            if (!string.IsNullOrEmpty(text))
            {
                // 使用Graphics对象来绘制
                using Graphics g = Graphics.FromImage(bmp);
                bmp.MakeTransparent();
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                var color = WaterMarkColor;
                var transparentColor = Color.FromArgb((int)(WaterMarkAlpha * 0xff), color.R, color.G, color.B);
                var font = new System.Drawing.Font("SimHei", WaterMarkFontSize);
                var brush = new SolidBrush(transparentColor);
                var location = new PointF(0, 0);
                var matrix = new Matrix();
                matrix.RotateAt(WaterMarkAngle, location);

                // 应用旋转矩阵
                g.Transform = matrix;
                g.DrawString(text, font, brush, location);
            };
            return bmp;
        }

        public static byte[] GetBinary(this Bitmap bmp)
        {
            MemoryStream ms = new();
            bmp.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static bool AddWaterMark(string pdfFile, string outputFile, string waterMarkFile = null, string waterMarkText = null)
        {
            if (!string.IsNullOrEmpty(waterMarkText) || File.Exists(waterMarkFile))
            {
                WaterarkProgress?.Invoke(0.01f);
                try
                {
                    using PdfReader pdfReader = new(pdfFile);
                    using var fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None);
                    using PdfStamper pdfStamper = new(pdfReader, fs);
                    pdfStamper.Writer.SetEncryption(true, "", "", WaterMarkPrintable ? PdfWriter.AllowPrinting : 0);  //必须再加水印前先设置加密，否则水印无法成功

                    iTextSharp.text.Image img = string.IsNullOrEmpty(waterMarkText) ?
                        iTextSharp.text.Image.GetInstance(waterMarkFile) : iTextSharp.text.Image.GetInstance(GenerateWaterMarkBitmap(waterMarkText).GetBinary());

                    //img.SetAbsolutePosition(10, 10);
                    Enumerable.Range(1, pdfReader.NumberOfPages).ToList().ForEach(i =>
                    {
                        var waterMark = pdfStamper.GetOverContent(i);
                        var pSize = pdfReader.GetPageSize(i);

                        for (float x = 0; x < pSize.Width; x += img.Width)
                            for (float y = 0; y < pSize.Height; y += img.Height)
                                waterMark.AddImage(img, img.Width, 0, 0, img.Height, x, y);

                        WaterarkProgress?.Invoke(0.01f + i / pdfReader.NumberOfPages * 0.99f);
                    });

                    pdfStamper.FormFlattening = true;

                    pdfStamper.Close();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
            else return false;
        }

        public static List<byte[]> SPlitPDf(string path)
        {
            byte[] pdfBin = null;
            try
            {
                pdfBin = File.ReadAllBytes(path);
            }
            catch (Exception ex) { }

            List<byte[]> pdfBook = [];

            if (pdfBin != null)
            {
                List<PdfImportedPage> pageBook = [];
                try
                {
                    using Document doc = new();

                    using var ms = new MemoryStream();
                    using var copy = new PdfSmartCopy(doc, ms);
                    doc.Open();
                    using var reader = new PdfReader(pdfBin);
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        var p = copy.GetImportedPage(reader, i);
                        pageBook.Add(p);
                    }

                    for (int i = 0; i < pageBook.Count; i += MAX_PAGE_PER_FILE)
                    {
                        using var ms2 = new MemoryStream();
                        using Document doc2 = new();
                        using var copy2 = new PdfSmartCopy(doc2, ms2);
                        doc2.Open();
                        for (int j = i; j < i + MAX_PAGE_PER_FILE && j < pageBook.Count; j++) copy2.AddPage(pageBook[j]);
                        doc2.Close();
                        pdfBook.Add(ms2.ToArray());
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return pdfBook;
        }
    }
}