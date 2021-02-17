using System;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Md2Word.Models;

namespace Md2Word.Utility
{
    public class DocumentManager
    {
        static string tempPath = @".\temp\ref.docx";
        static string pandocPath = @"pandoc";

        public static void Transform2Word (string sourcePath, string outputPath)
        {
            // 未选择预设
            if (StyleManager.StyleList.Count == 0)
            {
                MessageBox.Show("未选择预设！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 未选择源文件
            if (sourcePath.Equals(""))
            {
                MessageBox.Show("未选择源md文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 文件类型错误，文件扩展名非markdown
            if (!sourcePath.EndsWith(".md") || sourcePath.EndsWith(".markdown"))
            {
                MessageBox.Show("文件类型错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string fileName = sourcePath.Substring(sourcePath.LastIndexOf("\\"));
            outputPath = sourcePath.Substring(0, sourcePath.LastIndexOf("\\"));
            outputPath += fileName + ".docx";

            // 步骤1：新建样式模板docx
            CreateNewDocument(tempPath);
            WordprocessingDocument word = WordprocessingDocument.Open(tempPath, true);

            foreach (ParagraphStyle ps in StyleManager.StyleList)
            {
                AddParagraphStyle(word, StyleManager.GenerateStyle(ps));
            }

            word.Close();

            string args = "-o " + outputPath + " " + sourcePath +
                " --reference-doc=" + tempPath;

            // 步骤2：调用pandoc
            using (Process pandoc = new Process())
            {
                try
                {
                    pandoc.StartInfo.FileName = pandocPath;
                    pandoc.StartInfo.Arguments = args;
                    pandoc.Start();
                }
                catch (Exception)
                {
                    // TODO 动态设置pandoc的安装目录
                    MessageBox.Show("未在'" + pandocPath + "'下找到Pandoc！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


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
            if (style != null)
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
