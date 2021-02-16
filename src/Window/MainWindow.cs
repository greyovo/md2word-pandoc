using System;
using System.Diagnostics;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using WindowsFormsApp1.Utility;
using WindowsFormsApp1.Models;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Drawing;
using System.Collections;

public delegate int MyDelegate(int x);

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        string sourcePath;
        string outputPath;
        string tempPath = @".\temp\ref.docx";
        string pandocPath = @"C:\Prog1ram Files\Pandoc\pandoc.exe";
        string presetDirPath = @".\preset\";
        ArrayList installedFontList = new ArrayList();

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
        }

        private void CompLoad(object sender, EventArgs e)
        {
            LoadInstalledFonts();
            StyleManager.LoadStylePreset(presetDirPath);
            presetListCmbox.Items.AddRange(StyleManager.PresetList.ToArray());

            // 加载的预设不为空
            if (StyleManager.PresetList.Count > 0)
            {
                presetListCmbox.SelectedIndex = 0;
                var curGroup = (StyleGroup)presetListCmbox.SelectedItem;
                styleListBox.Items.AddRange(curGroup.styles);
                styleListBox.SelectedIndex = 0;

                var curStyle = (ParagraphStyle)styleListBox.SelectedItem;
                editingGroupBox.Text = curStyle.StyleName;
                fontsSelComboBox.Text = curStyle.FontName;
                numericFontSize.Value = Convert.ToDecimal(curStyle.FontSizeLb);
                numericLineSpacing.Value = Convert.ToDecimal(curStyle.LineSpacingLb);
                numericOutlevel.Value = Convert.ToDecimal(curStyle.OutLineLvl);
                colorInputBox.Text = curStyle.ColorHex;
                boldCheckBox.Checked = curStyle.Bold;
                italicCheckBox.Checked = curStyle.Italic;
                underlineCheckBox.Checked = curStyle.Underline;
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
            // 未选择预设
            if (StyleManager.StyleList.Count == 0)
            {
                MessageBox.Show("未选择预设！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 未选择源文件
            sourcePath = sourceMdPath.Text;
            if (sourcePath.Equals(""))
            {
                MessageBox.Show("未选择源md文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 文件类型错误，文件扩展名非markdown
            if (!sourcePath.EndsWith(".md") || sourcePath.EndsWith(".markdown"))
            {
                MessageBox.Show("文件类型错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string fileName = sourcePath.Substring(sourcePath.LastIndexOf("\\"));
            outputPath = sourcePath.Substring(0, sourcePath.LastIndexOf("\\"));
            outputPath += fileName + ".docx";

            // 步骤1：新建样式模板docx
            DocumentManager.CreateNewDocument(tempPath);
            WordprocessingDocument word = WordprocessingDocument.Open(tempPath, true);

            foreach(ParagraphStyle paragraph in StyleManager.StyleList)
            {
                DocumentManager.AddParagraphStyle(word, StyleManager.GenerateParagraphStyle(paragraph));
            }
            //DocumentManager.AddParagraphStyle(word, StyleManager.GenerateNormalStyle("Normal"));
            //DocumentManager.AddParagraphStyle(word, StyleManager.GenerateNormalStyle("Compact"));

            word.Close();

            string args = "-o " + outputPath + " " + sourcePath +
                " --reference-doc=" + tempPath;

            // 步骤2：调用pandoc
            Process pandoc = new Process();
            pandoc.StartInfo.FileName = pandocPath;
            pandoc.StartInfo.Arguments = args;
            try
            {
                pandoc.Start();
            }
            catch (Exception)
            {
                // TODO 动态设置pandoc的安装目录
                MessageBox.Show("未在'" + pandocPath + "'下找到Pandoc！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void ShowFontDialogBtn_Click(object sender, EventArgs e)
        {
            fontDialog.ShowEffects= true;
            fontDialog.ShowColor= true;
            fontDialog.ShowDialog();
            
            string res = fontDialog.Color.ToString() + "";
            //MessageBox.Show(res, e.ToString(),
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //当拖放完成时发生
        private void SourceMdPath_DragDrop(object sender, DragEventArgs e)
        {
            //取出拖放数据，返回类型为 Object，需要强制转换成 string[] 类型
            var array = e.Data.GetData(DataFormats.FileDrop) as string[];
            //数组中的每个元素都是一个文件或目录的完整路径
            sourcePath = array[0];
            sourceMdPath.Text = sourcePath;
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
            sourceMdPath.Text = sourcePath;
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
            var curStyle = (ParagraphStyle)styleListBox.SelectedItem;

            editingGroupBox.Text = curStyle.StyleName;
            curStyleNameIdLabel.Text = "StyleId = " + curStyle.StyleId;

            fontsSelComboBox.Text = curStyle.FontName;
            numericFontSize.Value = Convert.ToDecimal(curStyle.FontSizeLb);
            numericLineSpacing.Value = Convert.ToDecimal(curStyle.LineSpacingLb);
            numericOutlevel.Value = Convert.ToDecimal(curStyle.OutLineLvl);
            colorInputBox.Text = curStyle.ColorHex;
            boldCheckBox.Checked = curStyle.Bold;
            italicCheckBox.Checked = curStyle.Italic;
            underlineCheckBox.Checked = curStyle.Underline;
        }
    }
}
