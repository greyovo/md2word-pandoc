using System;
using System.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Collections;
using Md2Word.Models;
using System.IO;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 样式管理与生成
/// </summary>
namespace Md2Word.Utility
{
    public class StyleManager
    {

        public static ArrayList StyleList = new ArrayList();

        public static ArrayList PresetList = new ArrayList();

        /// <summary>
        /// 加载本地XML保存的预设
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
        /// 根据传入的参数生成一个指定的样式实例并返回
        /// </summary>
        /// <param name="p">段落样式对象</param>
        /// <returns>一个按照上述要求生成的Style实例</returns>
        public static Style GenerateStyle(ParagraphStyle p)
        {
            if (string.IsNullOrEmpty(p.StyleType))
                return null;

            Style style;

            // ---------------------------------------------
            // 段落样式 -------------------------------------
            // ---------------------------------------------
            if (p.StyleType.Equals("paragraph"))
            {
                style = new Style() { Type = StyleValues.Paragraph, StyleId = p.StyleId };
                StyleParagraphProperties paragraphProperties = new StyleParagraphProperties();

                // 对齐方式
                paragraphProperties.Append(new Justification() { Val = p.JustificationValues });

                // 行间距
                // 可设置的属性有：Before段前、After段后、Line行距、LineRule行距类型
                string lineSpacing;
                // 注意要判断为0的情况。默认使用1.15倍行距；或固定值时，使用字体大小的磅数
                Console.WriteLine(p.LineSpacing);
                Console.WriteLine(p.LineSpacingRuleValues);
                switch (p.LineSpacingRuleValues)
                {
                    case LineSpacingRuleValues.Auto:
                        p.LineSpacing = p.LineSpacing.Equals("0") ? "1.15" : p.LineSpacing;
                        lineSpacing = Convert.ToString(
                            Convert.ToDouble(p.LineSpacing) * 240 );
                        break;
                    case LineSpacingRuleValues.Exact:
                        p.LineSpacing = p.LineSpacing.Equals("0") ? p.FontSize : p.LineSpacing;
                        lineSpacing = Convert.ToString(
                            Convert.ToDouble(p.LineSpacing) * 20);
                        break;
                    default:
                        // 默认使用1.15倍行距
                        lineSpacing = Convert.ToString(
                            Convert.ToDouble(p.FontSize) * 1.15);
                        break;
                }

                SpacingBetweenLines spacingBetweenLines = new SpacingBetweenLines()
                {
                    Line = lineSpacing,
                    LineRule = p.LineSpacingRuleValues
                };
                paragraphProperties.Append(spacingBetweenLines);

                // 大纲级别。
                // 从0开始，0代表1级，以此类推
                // -1表示正文，则不添加
                if (p.OutLineLvl != -1)
                {
                    paragraphProperties.Append(
                        new SpacingBetweenLines() { Before = "150", After = "150" });
                    paragraphProperties.Append(
                         new OutlineLevel() { Val = p.OutLineLvl });
                }

                if (p.StyleId.Equals("BodyText"))
                paragraphProperties.Append(
                       new SpacingBetweenLines() { Before = "150", After = "0" });

               

                // 首行缩进
                if (p.FirstLineIndentation)
                {
                    Indentation indentation = new Indentation()
                    {
                        Left = "0",
                        FirstLine = "480",
                        FirstLineChars = 200 // 表示首行缩进两个字符
                    };
                    paragraphProperties.Append(indentation);
                }
                else if (p.OutLineLvl == -1)
                {
                    Indentation indentation = new Indentation()
                    {
                        FirstLine = "0"
                        // FirstLineChars = 200 // 表示首行缩进两个字符
                    };
                    paragraphProperties.Append(indentation);
                }
                style.Append(paragraphProperties);
            }
            else if (p.StyleType.Equals("character"))
                style = new Style() { Type = StyleValues.Character, StyleId = p.StyleId };
            else
            {
                MessageBox.Show("预设文件存在错误！StyleType字段未定义的值：" + p.StyleType, "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            style.Append(new StyleName() { Val = p.StyleName });
            style.Append(new PrimaryStyle());
            style.Append(new UIPriority() { Val = 3 });

            // ---------------------------------------------
            // 字符样式 -------------------------------------
            // ---------------------------------------------
            StyleRunProperties charProperties = new StyleRunProperties();

            // 字体
            RunFonts runFonts = new RunFonts() { Ascii = p.FontName, HighAnsi = p.FontName, EastAsia = p.FontName, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            charProperties.Append(runFonts);

            // 字号
            // 字号 = 磅值*2
            string sizeStr = Convert.ToString(Convert.ToDouble(p.FontSize) * 2);
            charProperties.Append(new FontSize() { Val = sizeStr });
            charProperties.Append(new FontSizeComplexScript() { Val = sizeStr });

            // 颜色
            Color color = new Color() { Val = p.ColorHex };
            charProperties.Append(color);

            // 加粗
            if (p.Bold)
            {
                charProperties.Append(new Bold());
                charProperties.Append(new BoldComplexScript());
            }

            // 斜体
            if (p.Italic)
                charProperties.Append(new Italic());

            // 下划线
            if (p.Underline)
                charProperties.Append(new Underline() { Val = UnderlineValues.Single } );

            style.Append(charProperties);

            return style;
        }


        /// <summary>
        /// 表格样式，默认启用
        /// </summary>
        /// <returns></returns>
        public static Style GenerateTableStyle()
        {
            Style style1 = new Style() { Type = StyleValues.Table, StyleId = "Table" };
            StyleName styleName1 = new StyleName() { Val = "Table" };
            BasedOn basedOn1 = new BasedOn() { Val = "a1" };
            UIPriority uIPriority1 = new UIPriority() { Val = 4 };

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);

            styleTableProperties1.Append(tableBorders1);

            // 居中对齐
            TableJustification tableJustification1 = new TableJustification() { Val = TableRowAlignmentValues.Center };
            styleTableProperties1.Append(tableJustification1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(uIPriority1);
            style1.Append(styleTableProperties1);
            return style1;
        }

        public static Style GenerateTableBaseStyle()
        {
            Style style1 = new Style() { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName1 = new StyleName() { Val = "Normal Table" };
            UIPriority uIPriority1 = new UIPriority() { Val = 99 };
            SemiHidden semiHidden1 = new SemiHidden();
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();

            StyleTableProperties styleTableProperties1 = new StyleTableProperties();
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TopMargin topMargin1 = new TopMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin() { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(topMargin1);
            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(bottomMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);

            styleTableProperties1.Append(tableIndentation1);
            styleTableProperties1.Append(tableCellMarginDefault1);

            style1.Append(styleName1);
            style1.Append(uIPriority1);
            style1.Append(semiHidden1);
            style1.Append(unhideWhenUsed1);
            style1.Append(styleTableProperties1);
            return style1;
        }

        

    }
}
