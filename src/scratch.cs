using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace GeneratedCode
{
    public class GeneratedClass
    {
        // 无序列表
        public Style GenerateNoListStyle()
        {
            Style style1 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Compact" };
            StyleName styleName1 = new StyleName(){ Val = "Compact" };
            BasedOn basedOn1 = new BasedOn(){ Val = "a0" };
            UIPriority uIPriority1 = new UIPriority(){ Val = 99 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed();
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid(){ Val = "00913301" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingId numberingId1 = new NumberingId(){ Val = 2 };

            numberingProperties1.Append(numberingId1);
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines(){ Line = "400", LineRule = LineSpacingRuleValues.Exact };

            styleParagraphProperties1.Append(numberingProperties1);
            styleParagraphProperties1.Append(spacingBetweenLines1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            FontSize fontSize1 = new FontSize(){ Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript(){ Val = "28" };

            styleRunProperties1.Append(fontSize1);
            styleRunProperties1.Append(fontSizeComplexScript1);

            style1.Append(styleName1);
            style1.Append(aliases1);
            style1.Append(basedOn1);
            style1.Append(uIPriority1);
            style1.Append(unhideWhenUsed1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);
            return style1;
        }

        // 有序列表
        public Style GenerateCompactStyle()
        {
            Style style1 = new Style(){ Type = StyleValues.Paragraph, StyleId = "Compact", CustomStyle = true };
            StyleName styleName1 = new StyleName(){ Val = "Compact" };
            BasedOn basedOn1 = new BasedOn(){ Val = "a0" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid(){ Val = "00D80145" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingId numberingId1 = new NumberingId(){ Val = 24 };

            numberingProperties1.Append(numberingId1);
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines(){ Line = "400", LineRule = LineSpacingRuleValues.Exact };

            styleParagraphProperties1.Append(numberingProperties1);
            styleParagraphProperties1.Append(spacingBetweenLines1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts(){ EastAsia = "宋体" };
            FontSize fontSize1 = new FontSize(){ Val = "24" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript(){ Val = "24" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(fontSize1);
            styleRunProperties1.Append(fontSizeComplexScript1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(linkedStyle1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);
            return style1;
        }



    }
}
