using System;
using System.IO;
using System.Web;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WindowsFormsApp1.Utility
{
    public class DocumentManager
    {
        /// <summary>
        /// 创建一个新的Word文档
        /// </summary>
        /// <param name="filepath">创建文档的路径名</param>
        public static void CreateNewDocument(string filepath)
        {
            // 如果目录不存在则创建
            string dirPath = filepath.Substring(0, filepath.LastIndexOf("\\"));
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            // Create a document by supplying the filepath. 
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("This is a temporary word document - CreateWordprocessingDocument\nCreated by \"Md2Word.exe\"."));
            }
        }

        /// <summary>
        /// 向文档的样式库中添加样式
        /// </summary>
        /// <param name="word">文档实例</param>
        /// <param name="style">样式实例</param>
        public static void AddParagraphStyle(WordprocessingDocument word, Style style)
        {
            // Access the root element of the styles part.
            Styles styles = GetStyleDefinitionsPart(word).Styles;
            // Add the style to the styles part.
            styles.Append(style);
        }


        /// <summary>
        /// 从文档获取样式库实例
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        private static StyleDefinitionsPart GetStyleDefinitionsPart(WordprocessingDocument doc)
        {
            // Get the Styles part for this document.
            StyleDefinitionsPart part =
                doc.MainDocumentPart.StyleDefinitionsPart;

            // If the Styles part does not exist, add it and then add the style.
            if (part == null)
            {
                part = AddStylesPartToPackage(doc);
            }
            return part;
        }

        /// <summary>
        /// Add a StylesDefinitionsPart to the document. Returns a reference to it.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        private static StyleDefinitionsPart AddStylesPartToPackage(WordprocessingDocument doc)
        {
            StyleDefinitionsPart part;
            part = doc.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
            Styles root = new Styles();
            root.Save(part);
            return part;
        }

    }


}
