using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WindowsFormsApp1.Utility;

namespace WindowsFormsApp1.Models
{
    public class ParagraphStyle
    {
        public string StyleName { get; set; }
        public string StyleId { get; set; }
        public string FontName { get; set; }
        public string FontSizeLb { get; set; }
        public string LineSpacingLb { get; set; }
        public string ColorHex { get; set; }
        public int OutLineLvl { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }

        public ParagraphStyle()
        {
        }

        public Style GetStyle()
        {
            return StyleManager.GenerateStyle(this);
        }

        public override string ToString()
        {
            string res = FontName + ", "+ FontSizeLb + "pt, #"+ ColorHex;
            res += Bold ? ", 加粗" : "";
            res += Italic ? ", 斜体" : "";
            return res;
        }

    }
}
