using System;
using System.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Collections;
using WindowsFormsApp1.Models;
using System.IO;
using System.Text;

/// <summary>
/// 样式管理与生成
/// </summary>
namespace WindowsFormsApp1.Utility
{
    public class StyleManager
    {

        public static ArrayList StyleList = new ArrayList(7);

        public static ArrayList PresetList = new ArrayList();

        /// <summary>
        /// 加载XML保存的预设
        /// </summary>
        /// <param name="presetPath"></param>
        public static void LoadStylePreset(string presetPath)
        {
            if (!Directory.Exists(presetPath))
            {
                Directory.CreateDirectory(presetPath);
                return;
            }
            // 加载目录下的所有xml文件
            DirectoryInfo dir = new DirectoryInfo(presetPath);
            FileInfo[] files = dir.GetFiles();
            ArrayList presetsFilePathList = new ArrayList();

            foreach(FileInfo f in files)
            {
                if (f.FullName.EndsWith(".xml"))
                    presetsFilePathList.Add(f.FullName);
            }

            // 反序列化为对象，同时捕获异常，如果存在非规范化的xml文件则跳过
            foreach(string path in presetsFilePathList)
            {
                try
                {
                    string presetName = path.Substring(path.LastIndexOf("\\")+1);
                    ParagraphStyle[] styles = XMLManager.DeserializeXmlFromFile<ParagraphStyle[]>(path, Encoding.UTF8);
                    StyleGroup group = new StyleGroup(presetName, styles);
                    PresetList.Add(group);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            // 加载完成，向界面更新


        }

        /// <summary>
        /// 生成基本样式
        /// </summary>
        /// <returns></returns>
        public static Style GenerateNormalStyle()
        {
            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "Normal", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            style1.Append(styleName1);
            style1.Append(primaryStyle1);
            return style1;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Style GenerateNormalStyle(string styleName)
        {
            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = styleName };
            StyleName styleName1 = new StyleName() { Val = styleName };
            //BasedOn basedOn1 = new BasedOn() { Val = "BodyText" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "00D80145" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();

            //NumberingProperties numberingProperties1 = new NumberingProperties();
            //NumberingId numberingId1 = new NumberingId() { Val = 24 };
            //numberingProperties1.Append(numberingId1);
            //styleParagraphProperties1.Append(numberingProperties1);

            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines()
            {
                Line = "400",
                LineRule = LineSpacingRuleValues.Exact
            };
            styleParagraphProperties1.Append(spacingBetweenLines1);

            // 缩进
            if (styleName.Equals("Compact"))
            {
                Indentation indentation1 = new Indentation()
                {
                    LeftChars = 200,
                    Left = "420",
                    FirstLine = "0"
                };

                styleParagraphProperties1.Append(indentation1);
            }

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts() { EastAsia = "宋体" };
            FontSize fontSize1 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "24" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(fontSize1);
            styleRunProperties1.Append(fontSizeComplexScript1);

            style1.Append(styleName1);
            //style1.Append(basedOn1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);
            return style1;
        }




        /// <summary>
        /// 根据传入的参数生成一个指定的样式实例并返回
        /// </summary>
        /// <param name="styleName">样式名</param>
        /// <param name="styleId">样式ID</param>
        /// <param name="fontName">字体名</param>
        /// <param name="fontSizeLb">字号大小</param>
        /// <param name="lineSpacingLb">行高</param>
        /// <param name="colorHex">字体颜色</param>
        /// <param name="outLineLvl">大纲级别</param>
        /// <param name="isBold">是否加粗</param>
        /// <param name="isItalic">是否斜体</param>
        /// <returns>一个按照上述要求生成的Style实例</returns>
        public static Style GenerateStyle(string styleName, string styleId,
                                          string fontName, string fontSizeLb, string lineSpacingLb, string colorHex,
                                          int outLineLvl, bool isBold, bool isItalic)
        {
            // 设置样式元数据
            Style style = new Style() { Type = StyleValues.Paragraph, StyleId = styleId };
            StyleName styleName1 = new StyleName() { Val = styleName };
            //BasedOn basedOn1 = new BasedOn() { Val = "a" };

            // 后续段落样式的，Val设置样式的ID
            //NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a0" }; // ?

            // 在界面中展示的优先级，从0开始
            UIPriority uIPriority1;
            try
            {
                var prior = Convert.ToInt32(styleId);
                uIPriority1 = new UIPriority() { Val = prior };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                uIPriority1 = new UIPriority() { Val = 3 };
            }

            // ?
            PrimaryStyle primaryStyle1 = new PrimaryStyle();

            //Rsid rsid1 = new Rsid() { Val = "00A32AEE" };

            // 段落样式 ---------------------------------------------
            StyleParagraphProperties paragraphProperties = new StyleParagraphProperties();

            // 不加这两个属性以避免段落前出现黑点
            //KeepNext keepNext1 = new KeepNext();
            //paragraphProperties.Append(keepNext1);
            //KeepLines keepLines1 = new KeepLines();
            //paragraphProperties.Append(keepLines1);

            // 行间距
            // 行间距值 = 磅值*20
            // 可设置的属性有：
            // Before段前、After段后、Line行距、LineRule行距类型
            // LineRule（枚举：单倍行距、固定值(取决于Line的值)、最小行距）
            if (lineSpacingLb != null && !lineSpacingLb.Equals(""))
            {
                string lineSpacingStr = Convert.ToString(Convert.ToDouble(lineSpacingLb) * 20);
                SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines()
                {
                    Line = lineSpacingStr,
                    LineRule = LineSpacingRuleValues.Exact
                };
                paragraphProperties.Append(spacingBetweenLines1);
            }
            else
            {
                SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines()
                {
                    LineRule = LineSpacingRuleValues.Auto
                };
                paragraphProperties.Append(spacingBetweenLines1);
            }


            // 大纲级别。从0开始，0代表1级，以此类推，-1表示正文，则不添加
            if (outLineLvl != -1)
            {
                OutlineLevel outlineLevel1 = new OutlineLevel() { Val = outLineLvl };
                SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "150", After = "150" };
                paragraphProperties.Append(spacingBetweenLines1);
                paragraphProperties.Append(outlineLevel1);
            }
            else
            {
                // 是正文，首行缩进
                Indentation indentation1 = new Indentation()
                {
                    //FirstLine = "420",
                    FirstLineChars = 200
                };
                paragraphProperties.Append(indentation1);
            }

            // 字符样式 ---------------------------------------------
            StyleRunProperties charProperties = new StyleRunProperties();

            // 字体
            RunFonts runFonts1 = new RunFonts() { Ascii = fontName, HighAnsi = fontName, EastAsia = fontName, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            charProperties.Append(runFonts1);

            // 字号
            // 字号 = 磅值*2
            string sizeStr = Convert.ToString(Convert.ToDouble(fontSizeLb) * 2);
            FontSize fontSize1 = new FontSize() { Val = sizeStr };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = sizeStr };
            charProperties.Append(fontSize1);
            charProperties.Append(fontSizeComplexScript1);

            // 颜色
            Color color1 = new Color() { Val = colorHex };
            charProperties.Append(color1);

            // 加粗
            if (isBold)
            {
                Bold bold1 = new Bold();
                BoldComplexScript boldComplexScript1 = new BoldComplexScript();
                charProperties.Append(bold1);
                charProperties.Append(boldComplexScript1);
            }

            // 斜体
            if (isItalic)
            {
                Italic italic = new Italic();
                charProperties.Append(italic);
            }

            // 段落样式和字符设置完成 ---------------------------------

            style.Append(styleName1);
            //style1.Append(basedOn1);
            //style1.Append(nextParagraphStyle1);
            style.Append(uIPriority1);
            style.Append(primaryStyle1);
            //style1.Append(rsid1);
            style.Append(paragraphProperties);
            style.Append(charProperties);
            return style;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Style GenerateStyle(ParagraphStyle p)
        {
            return GenerateStyle(p.StyleName, p.StyleId,
                p.FontName, p.FontSizeLb, p.LineSpacingLb, p.ColorHex, p.OutLineLvl, p.Bold, p.Italic);
        }



    }
}
