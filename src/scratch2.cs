private void LoadStylePreset()
        {
            H1Style = new ParagraphStyle()
            {
                StyleId = "1",
                StyleName = "Heading 1",
                FontName = "黑体",
                FontSizeLb = "14",
                ColorHex = "000000",
                OutLineLvl = 1,
                Bold = false,
                Italic = false
            };
            H2Style = new ParagraphStyle()
            {
                StyleId = "2",
                StyleName = "Heading 2",
                FontName = "黑体",
                FontSizeLb = "12",
                ColorHex = "000000",
                OutLineLvl = 2,
                Bold = false,
                Italic = false
            };
            H3Style = new ParagraphStyle()
            {
                StyleId = "3",
                StyleName = "Heading 3",
                FontName = "楷体_GB2312",
                LineSpacingLb = "18",
                FontSizeLb = "12",
                ColorHex = "000000",
                OutLineLvl = 3,
                Bold = false,
                Italic = false
            };
            H4Style = new ParagraphStyle()
            {
                StyleId = "3",
                StyleName = "Heading 3",
                FontName = "楷体_GB2312",
                FontSizeLb = "12",
                LineSpacingLb = "20",
                ColorHex = "000000",
                OutLineLvl = 3,
                Bold = false,
                Italic = false
            };
            FirstParagraphStyle = new ParagraphStyle()
            {
                StyleId = "FirstParagraph",
                StyleName = "FirstParagraph",
                FontName = "宋体",
                FontSizeLb = "12",
                ColorHex = "000000",
                LineSpacingLb = "20",
                OutLineLvl = -1,
                Bold = false,
                Italic = false
            };
            BodyTextStyle = new ParagraphStyle()
            {
                StyleId = "BodyText",
                StyleName = "Body Text",
                FontName = "宋体",
                FontSizeLb = "12",
                ColorHex = "000000",
                LineSpacingLb = "20",
                OutLineLvl = -1,
                Bold = false,
                Italic = false
            };
            BlockTextStyle = new ParagraphStyle()
            {
                StyleId = "a9",
                StyleName = "Block Text",
                FontName = "宋体",
                FontSizeLb = "12",
                LineSpacingLb = "20",
                ColorHex = "000000",
                OutLineLvl = -1,
                Bold = false,
                Italic = true
            };
            CodeTextStyle = new ParagraphStyle()
            {
                StyleId = "SourceCode",
                StyleName = "Source Code",
                FontName = "Consolas",
                FontSizeLb = "11",
                LineSpacingLb = "20",
                ColorHex = "000000",
                OutLineLvl = -1,
                Bold = false,
                Italic = false
            };

        }