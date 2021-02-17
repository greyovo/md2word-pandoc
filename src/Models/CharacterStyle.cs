using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Md2Word.Models
{
    class CharacterStyle
    {
        public string StyleName { get; set; }
        public string StyleId { get; set; }
        public string FontName { get; set; }
        public string FontSizeLb { get; set; }
        public string ColorHex { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
    }
}
