using System;
using System.Diagnostics;
using System.Windows.Forms;
using Md2Word.Utility;
using Md2Word.Models;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Drawing;
using System.Collections;
using DocumentFormat.OpenXml.Wordprocessing;
using Md2Word.Window;

namespace Md2Word
{
    public partial class MainWindow : Form
    {
        string sourcePath;
        string outputPath;
        string testMdPath = @"D:\VS-workspace\Md2Word\README.md";
        string tempPath = @".\temp\ref.docx";
        string pandocPath = @"pandoc";
        string presetDirPath = @".\preset\";
        ArrayList installedFontList = new ArrayList();

        HelpWindow helpWindow = new HelpWindow();

        // 左侧样式列表选中的Style对象
        // 这里新建一个对象，是防止在没有预设加载时出现的空指针错误
        ParagraphStyle curStyle = new ParagraphStyle();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载系统字体列表
        /// </summary>
        private void LoadInstalledFonts()
        {
            System.Drawing.FontFamily[] MyFontFamilies = new InstalledFontCollection().Families;
            int Count = MyFontFamilies.Length;
            for (int i = 0; i < Count; i++)
            {
                string FontName = MyFontFamilies[i].Name;
                installedFontList.Add(FontName);
            }
            fontsSelComboBox.Items.AddRange(installedFontList.ToArray());
            sourceMdPathInputBox.Text = testMdPath;
        }

        /// <summary>
        /// 设置各个控件的初始信息和状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadComponentData(object sender, EventArgs e)
        {
            LoadInstalledFonts();
            StyleManager.LoadStylePreset(presetDirPath);
            presetListCmbox.Items.AddRange(StyleManager.PresetList.ToArray());

            // 加载时预设不为空，默认加载第一个
            if (StyleManager.PresetList.Count > 0)
            {
                presetListCmbox.SelectedIndex = 0;
                var curGroup = (StyleGroup)presetListCmbox.SelectedItem;
                styleListBox.Items.AddRange(curGroup.styles);
                styleListBox.SelectedIndex = 0;
            }
            autoLineSpacingTip.SetToolTip(autoLineSpaceRadioBtn, "设置n倍行距，如1倍、1.15倍和2倍行距等");
        }

        /// <summary>
        /// 执行转换。
        /// 步骤1：新建样式模板docx
        /// 步骤2：调用pandoc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuateBtn_Click(object sender, EventArgs e)
        {
            sourcePath = sourceMdPathInputBox.Text;
            DocumentManager.Transform2Word(sourcePath, outputPath);
        }

        /// <summary>
        /// 当拖放完成时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceMdPath_DragDrop(object sender, DragEventArgs e)
        {
            //取出拖放数据，返回类型为 Object，需要强制转换成 string[] 类型
            var array = e.Data.GetData(DataFormats.FileDrop) as string[];
            //数组中的每个元素都是一个文件或目录的完整路径
            sourcePath = array[0];
            sourceMdPathInputBox.Text = sourcePath;
        }

        /// <summary>
        /// 当鼠标拖动到控件时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceMdPath_DragEnter(object sender, DragEventArgs e)
        {
            //表示接收到的数据是文件类型
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All; // 设置鼠标效果
            }
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            sourcePath = openFileDialog.FileName;
            sourceMdPathInputBox.Text = sourcePath;
        }

        /// <summary>
        /// 新建预设并保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPresetBtn_Click(object sender, EventArgs e)
        {
            // 输入名称
            string newPresetName = Interaction.InputBox("请输入新预设名：", "请输入新预设名", "", -1, -1);
            if (newPresetName.Equals(""))
            {
                MessageBox.Show("命名为空！");
                return;
            }

            // 验证命名是否包含非法字符 $ / \ < > ? * " |
            Regex reg = new Regex("[\\$\\/\\:\\?\"\\<\\>\\|/]+");
            if (reg.IsMatch(newPresetName))
            {
                MessageBox.Show(@"命名包含非法字符 $ / \ < > ? * "" |");
                return;
            }

            ParagraphStyle[] ps = new ParagraphStyle[StyleManager.StyleList.Count];

            int i = 0;
            foreach(ParagraphStyle p in StyleManager.StyleList)
            {
                ps[i++] = p;
            }
            string xmlPath = presetDirPath + newPresetName + ".xml";
            XMLManager.SerializeAsXmlFile(ps, xmlPath, Encoding.UTF8);
        }

        private void PresetListCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StyleGroup sel = (StyleGroup) presetListCmbox.SelectedItem;
            StyleManager.StyleList.Clear();
            StyleManager.StyleList.AddRange(sel.styles);
        }


        /// <summary>
        /// 左侧列表内容改变后将样式的内容更新到右侧编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StyleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curStyle = (ParagraphStyle)styleListBox.SelectedItem;

            editingGroupBox.Text = curStyle.StyleName;
            fontsSelComboBox.Text = curStyle.FontName;
            numericFontSize.Value = Convert.ToDecimal(curStyle.FontSize);
            numericExactLineSpacing.Value = Convert.ToDecimal(curStyle.LineSpacing);
            numericOutlevel.Value = Convert.ToDecimal(curStyle.OutLineLvl);
            colorInputBox.Text = curStyle.ColorHex;
            selectColorBtn.ForeColor = ColorTranslator.FromHtml("#" + colorInputBox.Text);
            boldCheckBox.Checked = curStyle.Bold;
            italicCheckBox.Checked = curStyle.Italic;
            underlineCheckBox.Checked = curStyle.Underline;
            firstLineIndentationCheckBox.Checked = curStyle.FirstLineIndentation;
            // fixme 行距自动与自定义的切换
            switch (curStyle.LineSpacingRuleValues)
            {
                case LineSpacingRuleValues.Auto:
                    autoLineSpaceRadioBtn.Checked = true;
                    numericAutoLineSpacing.Value = 
                        Convert.ToDecimal(curStyle.LineSpacing);
                    numericExactLineSpacing.Value = 0;
                    break;
                case LineSpacingRuleValues.Exact:
                    exactLineSpaceRadioBtn.Checked = true;
                    numericExactLineSpacing.Value =
                        Convert.ToDecimal(curStyle.LineSpacing);
                    numericAutoLineSpacing.Value = 0;
                    break;
                default:
                    // 默认使用1.15倍行距
                    autoLineSpaceRadioBtn.Checked = true;
                    numericAutoLineSpacing.Value = Convert.ToDecimal(1.15);
                    numericExactLineSpacing.Value = 0;
                    break;
            }


            // 对齐方式
            switch (curStyle.JustificationValues)
            {
                case JustificationValues.Left:
                    leftAlignRadioBtn.Checked = true;
                    break;
                case JustificationValues.Right:
                    rightAlignRadioBtn.Checked = true;
                    break;
                case JustificationValues.Center:
                    centerAlignRadioBtn.Checked = true;
                    break;
                case JustificationValues.Both:
                    bothAlignRadioBtn.Checked = true;
                    break;
                case JustificationValues.Distribute:
                    distributeAlignRadioBtn.Checked = true;
                    break;
                default:
                    leftAlignRadioBtn.Checked = true;
                    break;
            }
        }


        private void ColorInputBox_TextChanged(object sender, EventArgs e)
        {
            
            if (colorInputBox.Text.Contains("#"))
            {
                colorInputBox.Text = colorInputBox.Text.Replace("#", "");
            }

            // 变换按钮上的预览的颜色
            try
            {
                selectColorBtn.ForeColor = ColorTranslator.FromHtml("#" + colorInputBox.Text);
                curStyle.ColorHex = colorInputBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("颜色代码不正确！\n"+ ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// 倍数行距
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoLineSpaceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (autoLineSpaceRadioBtn.Checked)
            {
                curStyle.LineSpacingRuleValues = LineSpacingRuleValues.Auto;
                numericAutoLineSpacing.Enabled = true;
                numericExactLineSpacing.Enabled = false;
            }
        }

        private void NumericAutoLineSpacing_ValueChanged(object sender, EventArgs e)
        {
            curStyle.LineSpacing = Convert.ToString(numericAutoLineSpacing.Value);
        }

        /// <summary>
        /// 固定值行距
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExactLineSpaceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (exactLineSpaceRadioBtn.Checked)
            {
                curStyle.LineSpacingRuleValues = LineSpacingRuleValues.Exact;
                numericExactLineSpacing.Enabled = true;
                numericAutoLineSpacing.Enabled = false;
            }
        }

        private void NumericLineSpacing_ValueChanged(object sender, EventArgs e)
        {
            curStyle.LineSpacing = Convert.ToString(numericExactLineSpacing.Value);
        }

        private void FontsSelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curStyle.FontName = fontsSelComboBox.Text;
        }

        private void NumericFontSize_ValueChanged(object sender, EventArgs e)
        {
            curStyle.FontSize = Convert.ToString(numericFontSize.Value);
        }

        private void NumericOutlevel_ValueChanged(object sender, EventArgs e)
        {
            curStyle.OutLineLvl = Convert.ToInt32(numericOutlevel.Value);
        }



        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.Bold = boldCheckBox.Checked;
        }

        private void UnderlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.Underline = underlineCheckBox.Checked;
        }

        private void ItalicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.Italic = italicCheckBox.Checked;
        }

        private void SelectColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorInputBox.Text = ColorUtil.ColorToHex(colorDialog.Color);
        }

        private void FirstLineIndentationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.FirstLineIndentation = firstLineIndentationCheckBox.Checked; 
        }

        private void LeftAlignRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.JustificationValues = JustificationValues.Left;
        }

        private void CenterAlignRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.JustificationValues = JustificationValues.Center;
        }

        private void RightAlignRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.JustificationValues = JustificationValues.Right;
        }

        private void BothAlignRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.JustificationValues = JustificationValues.Both;
        }

        private void DistributeAlignRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            curStyle.JustificationValues = JustificationValues.Distribute;
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            // 单例模式
            if (helpWindow.IsDisposed)
            {
                helpWindow = new HelpWindow();
            }
            helpWindow.Show();
        }

        private void OpenPresetDirBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", presetDirPath);
        }

        private void NumericAutoLineSpacing_EnabledChanged(object sender, EventArgs e)
        {
            var self = (NumericUpDown)sender;
            if (self.Value != 0)
            {
                curStyle.LineSpacing = Convert.ToString(self.Value);
            }
        }

        private void NumericExactLineSpacing_EnabledChanged(object sender, EventArgs e)
        {
            var self = (NumericUpDown)sender;
            if (self.Value != 0)
            {
                curStyle.LineSpacing = Convert.ToString(self.Value);
            }
        }
    }
}
