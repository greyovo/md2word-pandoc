namespace Md2Word
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.sourceMdPathInputBox = new System.Windows.Forms.TextBox();
            this.saveAtSameDirCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.execuateBtn = new System.Windows.Forms.Button();
            this.styleListBox = new System.Windows.Forms.ListBox();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newPresetBtn = new System.Windows.Forms.Button();
            this.presetListCmbox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editingGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.distributeAlignRadioBtn = new System.Windows.Forms.RadioButton();
            this.bothAlignRadioBtn = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.rightAlignRadioBtn = new System.Windows.Forms.RadioButton();
            this.leftAlignRadioBtn = new System.Windows.Forms.RadioButton();
            this.centerAlignRadioBtn = new System.Windows.Forms.RadioButton();
            this.selectColorBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.numericOutlevel = new System.Windows.Forms.NumericUpDown();
            this.fontsSelComboBox = new System.Windows.Forms.ComboBox();
            this.firstLineIndentationCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoLineSpaceRadioBtn = new System.Windows.Forms.RadioButton();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.exactLineSpaceRadioBtn = new System.Windows.Forms.RadioButton();
            this.colorInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAutoLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.numericExactLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.openPresetDirBtn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.autoLineSpacingTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editingGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoLineSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExactLineSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // sourceMdPathInputBox
            // 
            this.sourceMdPathInputBox.AllowDrop = true;
            this.sourceMdPathInputBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sourceMdPathInputBox.Location = new System.Drawing.Point(195, 16);
            this.sourceMdPathInputBox.Name = "sourceMdPathInputBox";
            this.sourceMdPathInputBox.ReadOnly = true;
            this.sourceMdPathInputBox.Size = new System.Drawing.Size(389, 31);
            this.sourceMdPathInputBox.TabIndex = 12;
            this.sourceMdPathInputBox.WordWrap = false;
            this.sourceMdPathInputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragDrop);
            this.sourceMdPathInputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragEnter);
            // 
            // saveAtSameDirCheck
            // 
            this.saveAtSameDirCheck.AutoSize = true;
            this.saveAtSameDirCheck.Checked = true;
            this.saveAtSameDirCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveAtSameDirCheck.Enabled = false;
            this.saveAtSameDirCheck.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveAtSameDirCheck.Location = new System.Drawing.Point(494, 606);
            this.saveAtSameDirCheck.Name = "saveAtSameDirCheck";
            this.saveAtSameDirCheck.Size = new System.Drawing.Size(224, 29);
            this.saveAtSameDirCheck.TabIndex = 13;
            this.saveAtSameDirCheck.Text = "保存在源文档所在目录";
            this.saveAtSameDirCheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.chooseFileBtn);
            this.panel1.Controls.Add(this.sourceMdPathInputBox);
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 60);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Image = global::Md2Word.Properties.Resources.markdown_20px;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(16, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "     源文件(可拖放):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFileBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseFileBtn.Image = global::Md2Word.Properties.Resources.opened_folder_20px;
            this.chooseFileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chooseFileBtn.Location = new System.Drawing.Point(590, 13);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(116, 36);
            this.chooseFileBtn.TabIndex = 6;
            this.chooseFileBtn.Text = "浏览...";
            this.chooseFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseFileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpBtn.Image = global::Md2Word.Properties.Resources.help_20px;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpBtn.Location = new System.Drawing.Point(716, 13);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(171, 36);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.Text = "帮助/Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 50);
            this.label9.TabIndex = 9;
            this.label9.Text = "Markdown 转 Word";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(812, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 33);
            this.label13.TabIndex = 9;
            this.label13.Text = ">>";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Image = global::Md2Word.Properties.Resources.microsoft_word_48px;
            this.label14.Location = new System.Drawing.Point(846, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 50);
            this.label14.TabIndex = 9;
            this.label14.Text = "    ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Image = global::Md2Word.Properties.Resources.markdown_48px;
            this.label12.Location = new System.Drawing.Point(751, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 50);
            this.label12.TabIndex = 9;
            this.label12.Text = "    ";
            // 
            // execuateBtn
            // 
            this.execuateBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.execuateBtn.Image = global::Md2Word.Properties.Resources.next_20px;
            this.execuateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.execuateBtn.Location = new System.Drawing.Point(728, 599);
            this.execuateBtn.Name = "execuateBtn";
            this.execuateBtn.Size = new System.Drawing.Size(171, 41);
            this.execuateBtn.TabIndex = 5;
            this.execuateBtn.Text = "开始转换";
            this.execuateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.execuateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.execuateBtn.UseVisualStyleBackColor = true;
            this.execuateBtn.Click += new System.EventHandler(this.ExecuateBtn_Click);
            // 
            // styleListBox
            // 
            this.styleListBox.FormattingEnabled = true;
            this.styleListBox.ItemHeight = 24;
            this.styleListBox.Location = new System.Drawing.Point(18, 88);
            this.styleListBox.Name = "styleListBox";
            this.styleListBox.Size = new System.Drawing.Size(176, 268);
            this.styleListBox.TabIndex = 10;
            this.styleListBox.SelectedIndexChanged += new System.EventHandler(this.StyleListBox_SelectedIndexChanged);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAsBtn.Enabled = false;
            this.saveAsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAsBtn.Image = global::Md2Word.Properties.Resources.save_as_20px;
            this.saveAsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAsBtn.Location = new System.Drawing.Point(601, 385);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveAsBtn.Size = new System.Drawing.Size(128, 36);
            this.saveAsBtn.TabIndex = 6;
            this.saveAsBtn.Text = "另存为";
            this.saveAsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveAsBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Enabled = false;
            this.resetBtn.Location = new System.Drawing.Point(18, 385);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(103, 36);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "复位";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择预设";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::Md2Word.Properties.Resources.save_20px;
            this.saveBtn.Location = new System.Drawing.Point(745, 385);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(136, 36);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "保存修改";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // newPresetBtn
            // 
            this.newPresetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newPresetBtn.Image = global::Md2Word.Properties.Resources.add_20px;
            this.newPresetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newPresetBtn.Location = new System.Drawing.Point(587, 39);
            this.newPresetBtn.Name = "newPresetBtn";
            this.newPresetBtn.Size = new System.Drawing.Size(116, 36);
            this.newPresetBtn.TabIndex = 6;
            this.newPresetBtn.Text = "新建";
            this.newPresetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPresetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newPresetBtn.UseVisualStyleBackColor = true;
            this.newPresetBtn.Click += new System.EventHandler(this.NewPresetBtn_Click);
            // 
            // presetListCmbox
            // 
            this.presetListCmbox.FormattingEnabled = true;
            this.presetListCmbox.Location = new System.Drawing.Point(170, 40);
            this.presetListCmbox.Name = "presetListCmbox";
            this.presetListCmbox.Size = new System.Drawing.Size(411, 32);
            this.presetListCmbox.TabIndex = 8;
            this.presetListCmbox.SelectedIndexChanged += new System.EventHandler(this.PresetListCmbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editingGroupBox);
            this.groupBox1.Controls.Add(this.statementLabel);
            this.groupBox1.Controls.Add(this.styleListBox);
            this.groupBox1.Controls.Add(this.presetListCmbox);
            this.groupBox1.Controls.Add(this.openPresetDirBtn);
            this.groupBox1.Controls.Add(this.newPresetBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.saveAsBtn);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(15, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 437);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "段落样式设置";
            // 
            // editingGroupBox
            // 
            this.editingGroupBox.Controls.Add(this.panel2);
            this.editingGroupBox.Controls.Add(this.selectColorBtn);
            this.editingGroupBox.Controls.Add(this.label2);
            this.editingGroupBox.Controls.Add(this.label16);
            this.editingGroupBox.Controls.Add(this.label15);
            this.editingGroupBox.Controls.Add(this.label8);
            this.editingGroupBox.Controls.Add(this.italicCheckBox);
            this.editingGroupBox.Controls.Add(this.numericOutlevel);
            this.editingGroupBox.Controls.Add(this.fontsSelComboBox);
            this.editingGroupBox.Controls.Add(this.firstLineIndentationCheckBox);
            this.editingGroupBox.Controls.Add(this.boldCheckBox);
            this.editingGroupBox.Controls.Add(this.label7);
            this.editingGroupBox.Controls.Add(this.autoLineSpaceRadioBtn);
            this.editingGroupBox.Controls.Add(this.underlineCheckBox);
            this.editingGroupBox.Controls.Add(this.label6);
            this.editingGroupBox.Controls.Add(this.numericFontSize);
            this.editingGroupBox.Controls.Add(this.label11);
            this.editingGroupBox.Controls.Add(this.exactLineSpaceRadioBtn);
            this.editingGroupBox.Controls.Add(this.colorInputBox);
            this.editingGroupBox.Controls.Add(this.label3);
            this.editingGroupBox.Controls.Add(this.numericAutoLineSpacing);
            this.editingGroupBox.Controls.Add(this.numericExactLineSpacing);
            this.editingGroupBox.Controls.Add(this.label5);
            this.editingGroupBox.Controls.Add(this.label4);
            this.editingGroupBox.Location = new System.Drawing.Point(219, 88);
            this.editingGroupBox.Name = "editingGroupBox";
            this.editingGroupBox.Size = new System.Drawing.Size(662, 268);
            this.editingGroupBox.TabIndex = 11;
            this.editingGroupBox.TabStop = false;
            this.editingGroupBox.Text = "未选择样式";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.distributeAlignRadioBtn);
            this.panel2.Controls.Add(this.bothAlignRadioBtn);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.rightAlignRadioBtn);
            this.panel2.Controls.Add(this.leftAlignRadioBtn);
            this.panel2.Controls.Add(this.centerAlignRadioBtn);
            this.panel2.Location = new System.Drawing.Point(6, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 44);
            this.panel2.TabIndex = 15;
            // 
            // distributeAlignRadioBtn
            // 
            this.distributeAlignRadioBtn.AutoSize = true;
            this.distributeAlignRadioBtn.Location = new System.Drawing.Point(510, 7);
            this.distributeAlignRadioBtn.Name = "distributeAlignRadioBtn";
            this.distributeAlignRadioBtn.Size = new System.Drawing.Size(109, 29);
            this.distributeAlignRadioBtn.TabIndex = 11;
            this.distributeAlignRadioBtn.TabStop = true;
            this.distributeAlignRadioBtn.Text = "分散对齐";
            this.distributeAlignRadioBtn.UseVisualStyleBackColor = true;
            this.distributeAlignRadioBtn.CheckedChanged += new System.EventHandler(this.DistributeAlignRadioBtn_CheckedChanged);
            // 
            // bothAlignRadioBtn
            // 
            this.bothAlignRadioBtn.AutoSize = true;
            this.bothAlignRadioBtn.Location = new System.Drawing.Point(385, 7);
            this.bothAlignRadioBtn.Name = "bothAlignRadioBtn";
            this.bothAlignRadioBtn.Size = new System.Drawing.Size(109, 29);
            this.bothAlignRadioBtn.TabIndex = 11;
            this.bothAlignRadioBtn.TabStop = true;
            this.bothAlignRadioBtn.Text = "两端对齐";
            this.bothAlignRadioBtn.UseVisualStyleBackColor = true;
            this.bothAlignRadioBtn.CheckedChanged += new System.EventHandler(this.BothAlignRadioBtn_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(10, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "对齐：";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightAlignRadioBtn
            // 
            this.rightAlignRadioBtn.AutoSize = true;
            this.rightAlignRadioBtn.Location = new System.Drawing.Point(279, 7);
            this.rightAlignRadioBtn.Name = "rightAlignRadioBtn";
            this.rightAlignRadioBtn.Size = new System.Drawing.Size(90, 29);
            this.rightAlignRadioBtn.TabIndex = 11;
            this.rightAlignRadioBtn.TabStop = true;
            this.rightAlignRadioBtn.Text = "右对齐";
            this.rightAlignRadioBtn.UseVisualStyleBackColor = true;
            this.rightAlignRadioBtn.CheckedChanged += new System.EventHandler(this.RightAlignRadioBtn_CheckedChanged);
            // 
            // leftAlignRadioBtn
            // 
            this.leftAlignRadioBtn.AutoSize = true;
            this.leftAlignRadioBtn.Location = new System.Drawing.Point(84, 7);
            this.leftAlignRadioBtn.Name = "leftAlignRadioBtn";
            this.leftAlignRadioBtn.Size = new System.Drawing.Size(90, 29);
            this.leftAlignRadioBtn.TabIndex = 11;
            this.leftAlignRadioBtn.TabStop = true;
            this.leftAlignRadioBtn.Text = "左对齐";
            this.leftAlignRadioBtn.UseVisualStyleBackColor = true;
            this.leftAlignRadioBtn.CheckedChanged += new System.EventHandler(this.LeftAlignRadioBtn_CheckedChanged);
            // 
            // centerAlignRadioBtn
            // 
            this.centerAlignRadioBtn.AutoSize = true;
            this.centerAlignRadioBtn.Location = new System.Drawing.Point(188, 7);
            this.centerAlignRadioBtn.Name = "centerAlignRadioBtn";
            this.centerAlignRadioBtn.Size = new System.Drawing.Size(71, 29);
            this.centerAlignRadioBtn.TabIndex = 11;
            this.centerAlignRadioBtn.TabStop = true;
            this.centerAlignRadioBtn.Text = "居中";
            this.centerAlignRadioBtn.UseVisualStyleBackColor = true;
            this.centerAlignRadioBtn.CheckedChanged += new System.EventHandler(this.CenterAlignRadioBtn_CheckedChanged);
            // 
            // selectColorBtn
            // 
            this.selectColorBtn.Location = new System.Drawing.Point(92, 86);
            this.selectColorBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectColorBtn.Name = "selectColorBtn";
            this.selectColorBtn.Size = new System.Drawing.Size(30, 31);
            this.selectColorBtn.TabIndex = 10;
            this.selectColorBtn.Text = "█";
            this.selectColorBtn.UseVisualStyleBackColor = true;
            this.selectColorBtn.Click += new System.EventHandler(this.SelectColorBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "字体：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(495, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "0表示自动决定";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(493, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "单位: 磅";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(493, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "-1表示正文";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("新宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.italicCheckBox.Location = new System.Drawing.Point(220, 219);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(53, 24);
            this.italicCheckBox.TabIndex = 6;
            this.italicCheckBox.Text = "I ";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.ItalicCheckBox_CheckedChanged);
            // 
            // numericOutlevel
            // 
            this.numericOutlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOutlevel.Location = new System.Drawing.Point(373, 86);
            this.numericOutlevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericOutlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericOutlevel.Name = "numericOutlevel";
            this.numericOutlevel.Size = new System.Drawing.Size(114, 31);
            this.numericOutlevel.TabIndex = 4;
            this.numericOutlevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericOutlevel.ValueChanged += new System.EventHandler(this.NumericOutlevel_ValueChanged);
            // 
            // fontsSelComboBox
            // 
            this.fontsSelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsSelComboBox.FormattingEnabled = true;
            this.fontsSelComboBox.Location = new System.Drawing.Point(92, 41);
            this.fontsSelComboBox.Name = "fontsSelComboBox";
            this.fontsSelComboBox.Size = new System.Drawing.Size(158, 32);
            this.fontsSelComboBox.TabIndex = 2;
            this.fontsSelComboBox.SelectedIndexChanged += new System.EventHandler(this.FontsSelComboBox_SelectedIndexChanged);
            // 
            // firstLineIndentationCheckBox
            // 
            this.firstLineIndentationCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstLineIndentationCheckBox.AutoSize = true;
            this.firstLineIndentationCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstLineIndentationCheckBox.Location = new System.Drawing.Point(285, 216);
            this.firstLineIndentationCheckBox.Name = "firstLineIndentationCheckBox";
            this.firstLineIndentationCheckBox.Size = new System.Drawing.Size(110, 29);
            this.firstLineIndentationCheckBox.TabIndex = 6;
            this.firstLineIndentationCheckBox.Text = "首行缩进";
            this.firstLineIndentationCheckBox.UseVisualStyleBackColor = true;
            this.firstLineIndentationCheckBox.CheckedChanged += new System.EventHandler(this.FirstLineIndentationCheckBox_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boldCheckBox.Location = new System.Drawing.Point(90, 216);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 30);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "B";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "其他：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // autoLineSpaceRadioBtn
            // 
            this.autoLineSpaceRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoLineSpaceRadioBtn.AutoSize = true;
            this.autoLineSpaceRadioBtn.Location = new System.Drawing.Point(90, 130);
            this.autoLineSpaceRadioBtn.Name = "autoLineSpaceRadioBtn";
            this.autoLineSpaceRadioBtn.Size = new System.Drawing.Size(71, 29);
            this.autoLineSpaceRadioBtn.TabIndex = 7;
            this.autoLineSpaceRadioBtn.TabStop = true;
            this.autoLineSpaceRadioBtn.Text = "倍值";
            this.autoLineSpaceRadioBtn.UseVisualStyleBackColor = true;
            this.autoLineSpaceRadioBtn.CheckedChanged += new System.EventHandler(this.AutoLineSpaceRadioBtn_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.underlineCheckBox.Location = new System.Drawing.Point(152, 215);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(48, 29);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "U";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.UnderlineCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(274, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "大纲级别：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericFontSize
            // 
            this.numericFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFontSize.DecimalPlaces = 1;
            this.numericFontSize.Location = new System.Drawing.Point(373, 41);
            this.numericFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(114, 31);
            this.numericFontSize.TabIndex = 3;
            this.numericFontSize.ValueChanged += new System.EventHandler(this.NumericFontSize_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "#";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exactLineSpaceRadioBtn
            // 
            this.exactLineSpaceRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exactLineSpaceRadioBtn.AutoSize = true;
            this.exactLineSpaceRadioBtn.Location = new System.Drawing.Point(279, 130);
            this.exactLineSpaceRadioBtn.Name = "exactLineSpaceRadioBtn";
            this.exactLineSpaceRadioBtn.Size = new System.Drawing.Size(90, 29);
            this.exactLineSpaceRadioBtn.TabIndex = 8;
            this.exactLineSpaceRadioBtn.TabStop = true;
            this.exactLineSpaceRadioBtn.Text = "固定值";
            this.exactLineSpaceRadioBtn.UseVisualStyleBackColor = true;
            this.exactLineSpaceRadioBtn.CheckedChanged += new System.EventHandler(this.ExactLineSpaceRadioBtn_CheckedChanged);
            // 
            // colorInputBox
            // 
            this.colorInputBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorInputBox.Location = new System.Drawing.Point(145, 86);
            this.colorInputBox.Name = "colorInputBox";
            this.colorInputBox.Size = new System.Drawing.Size(105, 31);
            this.colorInputBox.TabIndex = 5;
            this.colorInputBox.TextChanged += new System.EventHandler(this.ColorInputBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(274, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "字体大小：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericAutoLineSpacing
            // 
            this.numericAutoLineSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAutoLineSpacing.DecimalPlaces = 2;
            this.numericAutoLineSpacing.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericAutoLineSpacing.Location = new System.Drawing.Point(167, 130);
            this.numericAutoLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericAutoLineSpacing.Name = "numericAutoLineSpacing";
            this.numericAutoLineSpacing.Size = new System.Drawing.Size(83, 31);
            this.numericAutoLineSpacing.TabIndex = 4;
            this.numericAutoLineSpacing.ValueChanged += new System.EventHandler(this.NumericAutoLineSpacing_ValueChanged);
            this.numericAutoLineSpacing.EnabledChanged += new System.EventHandler(this.NumericAutoLineSpacing_EnabledChanged);
            // 
            // numericExactLineSpacing
            // 
            this.numericExactLineSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericExactLineSpacing.DecimalPlaces = 1;
            this.numericExactLineSpacing.Location = new System.Drawing.Point(375, 130);
            this.numericExactLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericExactLineSpacing.Name = "numericExactLineSpacing";
            this.numericExactLineSpacing.Size = new System.Drawing.Size(114, 31);
            this.numericExactLineSpacing.TabIndex = 4;
            this.numericExactLineSpacing.ValueChanged += new System.EventHandler(this.NumericLineSpacing_ValueChanged);
            this.numericExactLineSpacing.EnabledChanged += new System.EventHandler(this.NumericExactLineSpacing_EnabledChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "颜色：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "行距：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statementLabel
            // 
            this.statementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statementLabel.AutoSize = true;
            this.statementLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statementLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statementLabel.Location = new System.Drawing.Point(215, 392);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(256, 20);
            this.statementLabel.TabIndex = 0;
            this.statementLabel.Text = "*在左侧选择样式，在右侧修改其内容";
            this.statementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openPresetDirBtn
            // 
            this.openPresetDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openPresetDirBtn.Image = global::Md2Word.Properties.Resources.opened_folder_20px;
            this.openPresetDirBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openPresetDirBtn.Location = new System.Drawing.Point(713, 39);
            this.openPresetDirBtn.Name = "openPresetDirBtn";
            this.openPresetDirBtn.Size = new System.Drawing.Size(171, 36);
            this.openPresetDirBtn.TabIndex = 6;
            this.openPresetDirBtn.Text = "打开预设目录";
            this.openPresetDirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openPresetDirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openPresetDirBtn.UseVisualStyleBackColor = true;
            this.openPresetDirBtn.Click += new System.EventHandler(this.OpenPresetDirBtn_Click);
            // 
            // autoLineSpacingTip
            // 
            this.autoLineSpacingTip.AutoPopDelay = 10000;
            this.autoLineSpacingTip.InitialDelay = 500;
            this.autoLineSpacingTip.ReshowDelay = 100;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveAtSameDirCheck);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.execuateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Markdown转Word";
            this.Load += new System.EventHandler(this.LoadComponentData);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editingGroupBox.ResumeLayout(false);
            this.editingGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoLineSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExactLineSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button execuateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox sourceMdPathInputBox;
        private System.Windows.Forms.CheckBox saveAtSameDirCheck;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox styleListBox;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newPresetBtn;
        private System.Windows.Forms.ComboBox presetListCmbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontsSelComboBox;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericExactLineSpacing;
        private System.Windows.Forms.TextBox colorInputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericOutlevel;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton autoLineSpaceRadioBtn;
        private System.Windows.Forms.RadioButton exactLineSpaceRadioBtn;
        private System.Windows.Forms.GroupBox editingGroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button selectColorBtn;
        private System.Windows.Forms.CheckBox firstLineIndentationCheckBox;
        private System.Windows.Forms.RadioButton bothAlignRadioBtn;
        private System.Windows.Forms.RadioButton rightAlignRadioBtn;
        private System.Windows.Forms.RadioButton centerAlignRadioBtn;
        private System.Windows.Forms.RadioButton leftAlignRadioBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton distributeAlignRadioBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericAutoLineSpacing;
        private System.Windows.Forms.ToolTip autoLineSpacingTip;
        private System.Windows.Forms.Button openPresetDirBtn;
    }
}

