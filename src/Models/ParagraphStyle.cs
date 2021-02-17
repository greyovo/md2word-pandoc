using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Md2Word.Utility;

namespace Md2Word.Models
{
    public class ParagraphStyle
    {
        public string StyleName { get; set; }
        public string StyleId { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }
        public string LineSpacing { get; set; }
        public string ColorHex { get; set; }
        public int OutLineLvl { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public bool FirstLineIndentation { get; set; } // 首行缩进

        public ParagraphStyle()
        {
        }

        public Style GetStyle()
        {
            return StyleManager.GenerateParagraphStyle(this);
        }

        public override string ToString()
        {
            //string res = FontName + ", "+ FontSizeLb + "pt, #"+ ColorHex;
            //res += Bold ? ", 加粗" : "";
            //res += Italic ? ", 斜体" : "";
            return StyleName;
        }

    }
}
