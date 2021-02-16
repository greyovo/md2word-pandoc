using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WindowsFormsApp1.Utility;
using WindowsFormsApp1.Models;
using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;

public delegate int MyDelegate(int x);

namespace WindowsFormsApp1
{
    public partial class Form0 : Form
    {
        string sourcePath;
        string outputPath;
        string tempPath = @".\temp\ref.docx";
        string pandocPath = @"C:\Program Files\Pandoc\pandoc.exe";
        string presetDirPath = @".\preset\";

        private ParagraphStyle H1Style;
        private ParagraphStyle H2Style;
        private ParagraphStyle H3Style;
        private ParagraphStyle H4Style;
        private ParagraphStyle BodyTextStyle;
        private ParagraphStyle FirstParagraphStyle;
        private ParagraphStyle BlockTextStyle;
        private ParagraphStyle CodeTextStyle;

        public Form0()
        {
            InitializeComponent();
        }

        

        private void CompLoad(object sender, EventArgs e)
        {
            StyleManager.LoadStylePreset(presetDirPath);
            presetListCmbox.Items.AddRange(StyleManager.PresetList.ToArray());
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
            if (StyleManager.StyleList.Count == 0)
            {
                MessageBox.Show("未选择预设！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sourcePath = sourceMdPath.Text;
            if (sourcePath.Equals(""))
            {
                MessageBox.Show("未选择源md文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fileName = sourcePath.Substring(sourcePath.LastIndexOf("\\"));
            outputPath = sourcePath.Substring(0, sourcePath.LastIndexOf("\\"));
            outputPath += fileName + ".docx";

            // 步骤1：新建样式模板docx
            DocumentManager.CreateNewDocument(tempPath);
            WordprocessingDocument word = WordprocessingDocument.Open(tempPath, true);

            foreach(ParagraphStyle paragraph in StyleManager.StyleList)
            {
                DocumentManager.AddParagraphStyle(word, StyleManager.GenerateStyle(paragraph));
            }
            DocumentManager.AddParagraphStyle(word, StyleManager.GenerateNormalStyle("Normal"));
            DocumentManager.AddParagraphStyle(word, StyleManager.GenerateNormalStyle("Compact"));

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
                MessageBox.Show("未安装Pandoc！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
