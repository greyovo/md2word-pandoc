using System;
using System.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Collections;
using Md2Word.Models;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Md2Word.Utility
{
    class NumberingManager
    {
        /// <summary>
        /// 无序列表样式
        /// </summary>
        /// <returns></returns>
        public static AbstractNum GenerateBulletAbstractNum()
        {
            // 缩进量
            int baseIndent = 284;
            int levelNum = 9;

            AbstractNum abstractNum1 = new AbstractNum() { AbstractNumberId = 0 };
            //Nsid nsid1 = new Nsid() { Val = "ea454b4c" };
            MultiLevelType multiLevelType1 = new MultiLevelType() { Val = MultiLevelValues.Multilevel };
            //abstractNum1.Append(nsid1);
            abstractNum1.Append(multiLevelType1);

            // ---------------level---------------
            for (int i = 0; i < levelNum; i++)
            {
                Level level = new Level() { LevelIndex = i };
                NumberingFormat numberingFormat1 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
                LevelText levelText1 = new LevelText() { Val = i % 2 == 0 ? "•" : "-" };
                LevelJustification levelJustification1 = new LevelJustification() { Val = LevelJustificationValues.Left };

                PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties();

                Tabs tabs1 = new Tabs();
                TabStop tabStop1 = new TabStop() { Val = TabStopValues.Number, Position = i * baseIndent };

                tabs1.Append(tabStop1);
                Indentation indentation1 = new Indentation()
                {
                    Left = Convert.ToString(baseIndent * (i+1)),
                    Hanging = Convert.ToString(baseIndent)
                };

                previousParagraphProperties1.Append(tabs1);
                previousParagraphProperties1.Append(indentation1);

                level.Append(numberingFormat1);
                level.Append(levelText1);
                level.Append(levelJustification1);
                level.Append(previousParagraphProperties1);
                abstractNum1.Append(level);
            }
            // ---------------level2---------------
            /*Level level2 = new Level() { LevelIndex = 1 };
            NumberingFormat numberingFormat2 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText2 = new LevelText() { Val = "–" };
            LevelJustification levelJustification2 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties2 = new PreviousParagraphProperties();

            Tabs tabs2 = new Tabs();
            TabStop tabStop2 = new TabStop() { Val = TabStopValues.Number, Position = 720 };

            tabs2.Append(tabStop2);
            Indentation indentation2 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties2.Append(tabs2);
            previousParagraphProperties2.Append(indentation2);

            level2.Append(numberingFormat2);
            level2.Append(levelText2);
            level2.Append(levelJustification2);
            level2.Append(previousParagraphProperties2);

            Level level3 = new Level() { LevelIndex = 2 };
            NumberingFormat numberingFormat3 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText3 = new LevelText() { Val = "•" };
            LevelJustification levelJustification3 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties3 = new PreviousParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop3 = new TabStop() { Val = TabStopValues.Number, Position = 1440 };

            tabs3.Append(tabStop3);
            Indentation indentation3 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties3.Append(tabs3);
            previousParagraphProperties3.Append(indentation3);

            level3.Append(numberingFormat3);
            level3.Append(levelText3);
            level3.Append(levelJustification3);
            level3.Append(previousParagraphProperties3);

            Level level4 = new Level() { LevelIndex = 3 };
            NumberingFormat numberingFormat4 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText4 = new LevelText() { Val = "–" };
            LevelJustification levelJustification4 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties4 = new PreviousParagraphProperties();

            Tabs tabs4 = new Tabs();
            TabStop tabStop4 = new TabStop() { Val = TabStopValues.Number, Position = 2160 };

            tabs4.Append(tabStop4);
            Indentation indentation4 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties4.Append(tabs4);
            previousParagraphProperties4.Append(indentation4);

            level4.Append(numberingFormat4);
            level4.Append(levelText4);
            level4.Append(levelJustification4);
            level4.Append(previousParagraphProperties4);*/

            return abstractNum1;
        }


        /// <summary>
        /// 数字列表的样式定义
        /// </summary>
        /// <returns></returns>
        public static AbstractNum GenerateDecimalAbstractNum()
        {
            // 缩进量
            int baseIndent = 240;
            int times = 1;

            AbstractNum abstractNum1 = new AbstractNum() { AbstractNumberId = 99411 };
            Nsid nsid1 = new Nsid() { Val = "71315dca" };
            MultiLevelType multiLevelType1 = new MultiLevelType() { Val = MultiLevelValues.Multilevel };
            abstractNum1.Append(nsid1);
            abstractNum1.Append(multiLevelType1);

            Level level1 = new Level() { LevelIndex = 0 };
            StartNumberingValue startNumberingValue1 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat1 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText1 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification1 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties();


            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop() { Val = TabStopValues.Number, Position = 0 };

            tabs1.Append(tabStop1);
            Indentation indentation1 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "240" };

            previousParagraphProperties1.Append(tabs1);
            previousParagraphProperties1.Append(indentation1);

            level1.Append(startNumberingValue1);
            level1.Append(numberingFormat1);
            level1.Append(levelText1);
            level1.Append(levelJustification1);
            level1.Append(previousParagraphProperties1);


            // ---------------------------------------
            Level level2 = new Level() { LevelIndex = 1 };
            StartNumberingValue startNumberingValue2 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat2 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText2 = new LevelText() { Val = "%2." };
            LevelJustification levelJustification2 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties2 = new PreviousParagraphProperties();

            Tabs tabs2 = new Tabs();
            TabStop tabStop2 = new TabStop() { Val = TabStopValues.Number, Position = 720 };

            tabs2.Append(tabStop2);
            Indentation indentation2 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties2.Append(tabs2);
            previousParagraphProperties2.Append(indentation2);

            level2.Append(startNumberingValue2);
            level2.Append(numberingFormat2);
            level2.Append(levelText2);
            level2.Append(levelJustification2);
            level2.Append(previousParagraphProperties2);

            Level level3 = new Level() { LevelIndex = 2 };
            StartNumberingValue startNumberingValue3 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat3 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText3 = new LevelText() { Val = "%3." };
            LevelJustification levelJustification3 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties3 = new PreviousParagraphProperties();

            Tabs tabs3 = new Tabs();
            TabStop tabStop3 = new TabStop() { Val = TabStopValues.Number, Position = 1440 };

            tabs3.Append(tabStop3);
            Indentation indentation3 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties3.Append(tabs3);
            previousParagraphProperties3.Append(indentation3);

            level3.Append(startNumberingValue3);
            level3.Append(numberingFormat3);
            level3.Append(levelText3);
            level3.Append(levelJustification3);
            level3.Append(previousParagraphProperties3);

            Level level4 = new Level() { LevelIndex = 3 };
            StartNumberingValue startNumberingValue4 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat4 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText4 = new LevelText() { Val = "%4." };
            LevelJustification levelJustification4 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties4 = new PreviousParagraphProperties();

            Tabs tabs4 = new Tabs();
            TabStop tabStop4 = new TabStop() { Val = TabStopValues.Number, Position = 2160 };

            tabs4.Append(tabStop4);
            Indentation indentation4 = new Indentation() { Left = Convert.ToString(baseIndent * times++), Hanging = "480" };

            previousParagraphProperties4.Append(tabs4);
            previousParagraphProperties4.Append(indentation4);

            level4.Append(startNumberingValue4);
            level4.Append(numberingFormat4);
            level4.Append(levelText4);
            level4.Append(levelJustification4);
            level4.Append(previousParagraphProperties4);

            abstractNum1.Append(level1);
            abstractNum1.Append(level2);
            abstractNum1.Append(level3);
            abstractNum1.Append(level4);
            return abstractNum1;
        }


    }
}
