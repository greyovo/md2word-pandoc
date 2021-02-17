using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Md2Word.Models
{
    /// <summary>
    /// 样式集合
    /// </summary>
    public class StyleGroup
    {
        // 预设名称，以文件命名
        public string name { get; set; }

        public ParagraphStyle[] styles { get; set; }

        public StyleGroup(string name, ParagraphStyle[] styles)
        {
            this.name = name;
            this.styles = styles;
        }

        public override string ToString()
        {
            if (name.EndsWith(".xml"))
            {
                return name.Substring(0, name.LastIndexOf(".xml"));
            }
            return name;
        }
    }
}
