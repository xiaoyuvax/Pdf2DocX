using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace PDFConverter
{
    internal static class DocXMan
    {
        public static Action<float> UpdateProgress;

        public static void MergeDocX(IList<MemoryStream> inputStreams, string outputFile, bool repairSpacing)
        {
            var firstStream = inputStreams.FirstOrDefault();
            if (firstStream != null)
            {
                try
                {
                    File.WriteAllBytes(outputFile, firstStream.ToArray());
                    firstStream.Close();
                    using WordprocessingDocument outputDoc = WordprocessingDocument.Open(outputFile, true);
                    var mainPart = outputDoc.MainDocumentPart;
                    EnsurePageBreakAtEnd(mainPart.Document.Body.Elements<Paragraph>().LastOrDefault());

                    int fileId = 0;
                    int restCount = inputStreams.Count - 1;
                    foreach (var sourceStream in inputStreams.Skip(1))
                    {
                        string altChunkId = $"AltChunk{fileId++}";
                        var chunk = mainPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.WordprocessingML, altChunkId);
                        sourceStream.Seek(0, SeekOrigin.Begin);
                        chunk.FeedData(sourceStream);
                        if (chunk.ContentType == AlternativeFormatImportPartType.WordprocessingML.ContentType && chunk.OpenXmlPackage?.RootPart?.RootElement is Document doc)
                        {
                            EnsurePageBreakAtEnd(doc.Body.Elements<Paragraph>().LastOrDefault());
                            doc.Save();
                        }

                        AltChunk altChunk = new() { Id = altChunkId };

                        var lastParagraph = mainPart.Document.Body.Elements<Paragraph>().LastOrDefault();

                        if (lastParagraph == null) mainPart.Document.Body.Append(altChunk);
                        else lastParagraph.InsertAfterSelf(altChunk);
                        if (fileId < restCount) altChunk.InsertAfterSelf(EnsurePageBreakAtEnd(new Paragraph()));

                        sourceStream.Close();
                    }

                    mainPart.Document.Save();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private static Paragraph EnsurePageBreakAtEnd(Paragraph p)
        {
            if (p != null)
                if (p.LastChild is Run r && r.LastChild is Break br && br.Type == BreakValues.Page)
                { }
                else
                {
                    p.Append(GetNewPageBreakRun());
                }
            return p;
        }

        private static Run GetNewPageBreakRun()
        {
            Run newLineRun = new();
            newLineRun.Append(new Break() { Type = BreakValues.Page });
            return newLineRun;
        }


        static void SplitDocxIntoMultipleFiles(string sourceDocx, string outputFolder, int pagesPerFile)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(sourceDocx, true))
            {
                int pageIndex = 0;
                int fileIndex = 1;
                string newDocxPath = Path.Combine(outputFolder, $"Part{fileIndex}.docx");

                for (int i = 1; i <= doc.MainDocumentPart.Document.Body.Elements().Count(); i++)
                {
                    if (pageIndex % pagesPerFile == 0 && pageIndex != 0)
                    {
                        fileIndex++;
                        newDocxPath = Path.Combine(outputFolder, $"Part{fileIndex}.docx");
                        using (WordprocessingDocument newDoc = WordprocessingDocument.Create(newDocxPath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                        {
                            // Add a new main document part.
                            MainDocumentPart mainPart = newDoc.AddMainDocumentPart();
                            // Add a new document body.
                            mainPart.Document = new Document();
                            Body body = mainPart.Document.AppendChild(new Body());
                        }
                    }

                    if (i == doc.MainDocumentPart.Document.Body.Elements().Count())
                    {
                        pageIndex++;
                        continue;
                    }

                    OpenXmlElement element = doc.MainDocumentPart.Document.Body.ElementAt(i);
                    using (WordprocessingDocument newDoc = WordprocessingDocument.Open(newDocxPath, true))
                    {
                        Body body = newDoc.MainDocumentPart.Document.Body;
                        body.AppendChild(element.CloneNode(true));
                    }

                    pageIndex++;
                }
            }
        }

    }
}