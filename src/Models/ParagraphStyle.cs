using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Md2Word.Utility;

namespace Md2Word.Models
{
    public class ParagraphStyle
    {
        public string StyleType { get; set; } // 样式类型：段落样式、字符样式、表格样式
        public string StyleName { get; set; }
        public string Alias { get; set; } // 中文名称
        public string StyleId { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }
        public LineSpacingRuleValues LineSpacingRuleValues { get; set; } // 倍数行距或固定值
        public string LineSpacing { get; set; }
        public string ColorHex { get; set; }
        public int OutLineLvl { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public bool FirstLineIndentation { get; set; } // 首行缩进
        public JustificationValues JustificationValues { get; set; } // 对齐方式，取值为枚举类型

        public ParagraphStyle()
        {
        }

        public Style GetStyle()
        {
            return StyleManager.GenerateStyle(this);
        }

        public override string ToString()
        {
            //string res = FontName + ", "+ FontSizeLb + "pt, #"+ ColorHex;
            //res += Bold ? ", 加粗" : "";
            //res += Italic ? ", 斜体" : "";
            return string.IsNullOrEmpty(Alias) ? StyleName : Alias;
        }

    }
}
