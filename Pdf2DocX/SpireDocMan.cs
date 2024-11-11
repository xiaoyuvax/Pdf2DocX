using Spire.Doc;
using Spire.Pdf;

namespace PDFConverter
{
    public class SpireDocMan
    {
        public static Action<float> UpdateProgress;

        public static bool PDF2Word(string src, string destPath)
        {
            var pdfBook = ITextMan.SPlitPDf(src);
            UpdateProgress?.Invoke(0.1f);
            int count = 0;
            List<MemoryStream> docBook = pdfBook.AsParallel().Select((p, n) =>
            {
                count++;
                var pdf = new PdfDocument();
                var ms = new MemoryStream();
                try
                {
                    pdf.LoadFromBytes(p);
                }
                catch (Exception ex) { }
                lock (pdfBook) pdf.SaveToStream(ms, Spire.Pdf.FileFormat.DOCX);
                //File.WriteAllBytes($"d:\\tmp\\docx\\{count}.docx",ms.ToArray());
                UpdateProgress?.Invoke(0.1f + (float)count / pdfBook.Count * 0.5f);
                return ms;
            }).ToList();
            UpdateProgress?.Invoke(0.6f);
            DocXMan.MergeDocX(docBook, destPath, false);
            UpdateProgress?.Invoke(0.9f);
            return true;
        }

        public static bool Word2PDF(string src, string dec)
        {
            Document doc = new();
            doc.LoadFromFile(src);
            doc.SaveToFile(dec, Spire.Doc.FileFormat.PDF);
            return true;
        }
    }
}