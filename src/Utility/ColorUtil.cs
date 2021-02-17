using System;
using System.Drawing;

namespace Md2Word.Utility
{
    class ColorUtil
    {
        /// <summary>
        /// 将Color对象的颜色值转为Hex值（十六进制）
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ColorToHex(Color color)
        {
            int r = Convert.ToInt32(color.R);
            int g = Convert.ToInt32(color.G);
            int b = Convert.ToInt32(color.B);

            string rhex, ghex, bhex;
            rhex = Convert.ToString(r, 16);
            ghex = Convert.ToString(g, 16);
            bhex = Convert.ToString(b, 16);

            rhex = r < 0x0f ? "0" + rhex : rhex;
            ghex = g < 0x0f ? "0" + ghex : ghex;
            bhex = b < 0x0f ? "0" + bhex : bhex;

            return rhex + ghex + bhex;
        }
    }
}
