using System;
using System.Diagnostics;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using Md2Word.Utility;
using Md2Word.Models;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Drawing;
using System.Collections;

public delegate int MyDelegate(int x);

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

        ParagraphStyle curStyle = new ParagraphStyle();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadInstalledFonts()
        {
            FontFamily[] MyFontFamilies = new InstalledFontCollection().Families;
            int Count = MyFontFamilies.Length;
            for (int i = 0; i < Count; i++)
            {
                string FontName = MyFontFamilies[i].Name;
                installedFontList.Add(FontName);
            }
            fontsSelComboBox.Items.AddRange(installedFontList.ToArray());
            sourceMdPathInputBox.Text = testMdPath;
        }

        private void CompLoad(object sender, EventArgs e)
        {
            LoadInstalledFonts();
            StyleManager.LoadStylePreset(presetDirPath);
            presetListCmbox.Items.AddRange(StyleManager.PresetList.ToArray());

            // 加载时预设不为空，默认加载第一个
            if (StyleManager.PresetList.Count > 0)
            {
                presetListCmbox.SelectedIndex = 0;
                var curGroup = (StyleGroup)presetListCmbox.SelectedItem;
                空.Items.AddRange(curGroup.styles);
                空.SelectedIndex = 0;
            }

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


        //当拖放完成时发生
        private void SourceMdPath_DragDrop(object sender, DragEventArgs e)
        {
            //取出拖放数据，返回类型为 Object，需要强制转换成 string[] 类型
            var array = e.Data.GetData(DataFormats.FileDrop) as string[];
            //数组中的每个元素都是一个文件或目录的完整路径
            sourcePath = array[0];
            sourceMdPathInputBox.Text = sourcePath;
        }

        //当鼠标拖动到控件时发生
        private void SourceMdPath_DragEnter(object sender, DragEventArgs e)
        {
            //表示接收到的数据是文件类型
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //设置鼠标效果
                e.Effect = DragDropEffects.All;
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
            curStyle = (ParagraphStyle)空.SelectedItem;

            editingGroupBox.Text = curStyle.StyleName;
            fontsSelComboBox.Text = curStyle.FontName;
            numericFontSize.Value = Convert.ToDecimal(curStyle.FontSize);
            numericLineSpacing.Value = Convert.ToDecimal(curStyle.LineSpacing);
            numericOutlevel.Value = Convert.ToDecimal(curStyle.OutLineLvl);
            colorInputBox.Text = curStyle.ColorHex;
            selectColorBtn.ForeColor = ColorTranslator.FromHtml("#" + colorInputBox.Text);
            boldCheckBox.Checked = curStyle.Bold;
            italicCheckBox.Checked = curStyle.Italic;
            underlineCheckBox.Checked = curStyle.Underline;
            firstLineIndentationCheckBox.Checked = curStyle.FirstLineIndentation;
            // TODO 行距自动与自定义的切换
            autoLineSpaceRadioBtn.Checked = false;
            customLineSpaceRadioBtn.Checked = true;
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

        private void AutoLineSpaceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            numericLineSpacing.Enabled = false;
        }

        private void CustomLineSpaceRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            numericLineSpacing.Enabled = true;
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

        private void NumericLineSpacing_ValueChanged(object sender, EventArgs e)
        {
            curStyle.LineSpacing = Convert.ToString(numericLineSpacing.Value);
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
    }
}
