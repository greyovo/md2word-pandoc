namespace WindowsFormsApp1
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.sourceMdPath = new System.Windows.Forms.TextBox();
            this.saveAtSameDirCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
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
            this.colorPreviewLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.numericOutlevel = new System.Windows.Forms.NumericUpDown();
            this.fontsSelComboBox = new System.Windows.Forms.ComboBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.autoLineSpaceRadioBtn = new System.Windows.Forms.RadioButton();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.customLineSpaceRadioBtn = new System.Windows.Forms.RadioButton();
            this.colorInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.paragraphStyleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphStyleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // fontDialog
            // 
            this.fontDialog.Apply += new System.EventHandler(this.FontDialog1_Apply);
            // 
            // sourceMdPath
            // 
            this.sourceMdPath.AllowDrop = true;
            this.sourceMdPath.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sourceMdPath.Location = new System.Drawing.Point(195, 16);
            this.sourceMdPath.Name = "sourceMdPath";
            this.sourceMdPath.ReadOnly = true;
            this.sourceMdPath.Size = new System.Drawing.Size(389, 31);
            this.sourceMdPath.TabIndex = 12;
            this.sourceMdPath.WordWrap = false;
            this.sourceMdPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragDrop);
            this.sourceMdPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragEnter);
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
            this.panel1.Controls.Add(this.sourceMdPath);
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
            this.label10.Image = global::WindowsFormsApp1.Properties.Resources.markdown_20px;
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
            this.chooseFileBtn.Image = global::WindowsFormsApp1.Properties.Resources.opened_folder_20px;
            this.chooseFileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chooseFileBtn.Location = new System.Drawing.Point(590, 16);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(116, 31);
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
            this.helpBtn.Image = global::WindowsFormsApp1.Properties.Resources.help_20px;
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpBtn.Location = new System.Drawing.Point(716, 16);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(171, 31);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.Text = "如何使用?";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helpBtn.UseVisualStyleBackColor = true;
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
            this.label14.Image = global::WindowsFormsApp1.Properties.Resources.microsoft_word_48px;
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
            this.label12.Image = global::WindowsFormsApp1.Properties.Resources.markdown_48px;
            this.label12.Location = new System.Drawing.Point(751, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 50);
            this.label12.TabIndex = 9;
            this.label12.Text = "    ";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.aboutBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutBtn.Image = global::WindowsFormsApp1.Properties.Resources.info_20px;
            this.aboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutBtn.Location = new System.Drawing.Point(30, 609);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(102, 31);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "关于";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutBtn.UseVisualStyleBackColor = false;
            // 
            // execuateBtn
            // 
            this.execuateBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.execuateBtn.Image = global::WindowsFormsApp1.Properties.Resources.next_20px;
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
            this.saveAsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveAsBtn.Image = global::WindowsFormsApp1.Properties.Resources.save_as_20px;
            this.saveAsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAsBtn.Location = new System.Drawing.Point(601, 385);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveAsBtn.Size = new System.Drawing.Size(128, 36);
            this.saveAsBtn.TabIndex = 6;
            this.saveAsBtn.Text = "另存为...";
            this.saveAsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveAsBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.saveBtn.Image = global::WindowsFormsApp1.Properties.Resources.save_20px;
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
            this.newPresetBtn.Image = global::WindowsFormsApp1.Properties.Resources.add_20px;
            this.newPresetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newPresetBtn.Location = new System.Drawing.Point(778, 38);
            this.newPresetBtn.Name = "newPresetBtn";
            this.newPresetBtn.Size = new System.Drawing.Size(103, 36);
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
            this.presetListCmbox.Size = new System.Drawing.Size(598, 32);
            this.presetListCmbox.TabIndex = 8;
            this.presetListCmbox.SelectedIndexChanged += new System.EventHandler(this.PresetListCmbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editingGroupBox);
            this.groupBox1.Controls.Add(this.statementLabel);
            this.groupBox1.Controls.Add(this.styleListBox);
            this.groupBox1.Controls.Add(this.presetListCmbox);
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
            this.editingGroupBox.Controls.Add(this.colorPreviewLabel);
            this.editingGroupBox.Controls.Add(this.label2);
            this.editingGroupBox.Controls.Add(this.label16);
            this.editingGroupBox.Controls.Add(this.label15);
            this.editingGroupBox.Controls.Add(this.label8);
            this.editingGroupBox.Controls.Add(this.italicCheckBox);
            this.editingGroupBox.Controls.Add(this.numericOutlevel);
            this.editingGroupBox.Controls.Add(this.fontsSelComboBox);
            this.editingGroupBox.Controls.Add(this.boldCheckBox);
            this.editingGroupBox.Controls.Add(this.label7);
            this.editingGroupBox.Controls.Add(this.autoLineSpaceRadioBtn);
            this.editingGroupBox.Controls.Add(this.underlineCheckBox);
            this.editingGroupBox.Controls.Add(this.label6);
            this.editingGroupBox.Controls.Add(this.numericFontSize);
            this.editingGroupBox.Controls.Add(this.label11);
            this.editingGroupBox.Controls.Add(this.customLineSpaceRadioBtn);
            this.editingGroupBox.Controls.Add(this.colorInputBox);
            this.editingGroupBox.Controls.Add(this.label3);
            this.editingGroupBox.Controls.Add(this.numericLineSpacing);
            this.editingGroupBox.Controls.Add(this.label5);
            this.editingGroupBox.Controls.Add(this.label4);
            this.editingGroupBox.Location = new System.Drawing.Point(219, 88);
            this.editingGroupBox.Name = "editingGroupBox";
            this.editingGroupBox.Size = new System.Drawing.Size(662, 228);
            this.editingGroupBox.TabIndex = 11;
            this.editingGroupBox.TabStop = false;
            this.editingGroupBox.Text = "editingGroupBox";
            // 
            // colorPreviewLabel
            // 
            this.colorPreviewLabel.AutoSize = true;
            this.colorPreviewLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorPreviewLabel.Location = new System.Drawing.Point(211, 92);
            this.colorPreviewLabel.Name = "colorPreviewLabel";
            this.colorPreviewLabel.Size = new System.Drawing.Size(25, 25);
            this.colorPreviewLabel.TabIndex = 9;
            this.colorPreviewLabel.Text = "█";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 48);
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
            this.label16.Location = new System.Drawing.Point(407, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "单位: 磅";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(469, 52);
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
            this.label8.Location = new System.Drawing.Point(469, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "值为-1表示正文";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("新宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.italicCheckBox.Location = new System.Drawing.Point(217, 176);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(53, 24);
            this.italicCheckBox.TabIndex = 6;
            this.italicCheckBox.Text = "I ";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            // 
            // numericOutlevel
            // 
            this.numericOutlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOutlevel.Location = new System.Drawing.Point(349, 91);
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
            // 
            // fontsSelComboBox
            // 
            this.fontsSelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsSelComboBox.FormattingEnabled = true;
            this.fontsSelComboBox.Location = new System.Drawing.Point(89, 44);
            this.fontsSelComboBox.Name = "fontsSelComboBox";
            this.fontsSelComboBox.Size = new System.Drawing.Size(141, 32);
            this.fontsSelComboBox.TabIndex = 2;
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boldCheckBox.Location = new System.Drawing.Point(87, 173);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 30);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "B";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(20, 175);
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
            this.autoLineSpaceRadioBtn.Location = new System.Drawing.Point(87, 134);
            this.autoLineSpaceRadioBtn.Name = "autoLineSpaceRadioBtn";
            this.autoLineSpaceRadioBtn.Size = new System.Drawing.Size(71, 29);
            this.autoLineSpaceRadioBtn.TabIndex = 7;
            this.autoLineSpaceRadioBtn.TabStop = true;
            this.autoLineSpaceRadioBtn.Text = "自动";
            this.autoLineSpaceRadioBtn.UseVisualStyleBackColor = true;
            this.autoLineSpaceRadioBtn.CheckedChanged += new System.EventHandler(this.AutoLineSpaceRadioBtn_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.underlineCheckBox.Location = new System.Drawing.Point(149, 172);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(48, 29);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "U";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(250, 93);
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
            this.numericFontSize.Location = new System.Drawing.Point(349, 46);
            this.numericFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(114, 31);
            this.numericFontSize.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "#";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customLineSpaceRadioBtn
            // 
            this.customLineSpaceRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customLineSpaceRadioBtn.AutoSize = true;
            this.customLineSpaceRadioBtn.Location = new System.Drawing.Point(191, 134);
            this.customLineSpaceRadioBtn.Name = "customLineSpaceRadioBtn";
            this.customLineSpaceRadioBtn.Size = new System.Drawing.Size(90, 29);
            this.customLineSpaceRadioBtn.TabIndex = 8;
            this.customLineSpaceRadioBtn.TabStop = true;
            this.customLineSpaceRadioBtn.Text = "自定义";
            this.customLineSpaceRadioBtn.UseVisualStyleBackColor = true;
            this.customLineSpaceRadioBtn.CheckedChanged += new System.EventHandler(this.CustomLineSpaceRadioBtn_CheckedChanged);
            // 
            // colorInputBox
            // 
            this.colorInputBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorInputBox.Location = new System.Drawing.Point(109, 89);
            this.colorInputBox.Name = "colorInputBox";
            this.colorInputBox.Size = new System.Drawing.Size(102, 31);
            this.colorInputBox.TabIndex = 5;
            this.colorInputBox.TextChanged += new System.EventHandler(this.ColorInputBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(250, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "字体大小：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericLineSpacing
            // 
            this.numericLineSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLineSpacing.DecimalPlaces = 1;
            this.numericLineSpacing.Location = new System.Drawing.Point(287, 134);
            this.numericLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericLineSpacing.Name = "numericLineSpacing";
            this.numericLineSpacing.Size = new System.Drawing.Size(114, 31);
            this.numericLineSpacing.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 93);
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
            this.label4.Location = new System.Drawing.Point(20, 134);
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
            this.statementLabel.Location = new System.Drawing.Point(215, 336);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(256, 20);
            this.statementLabel.TabIndex = 0;
            this.statementLabel.Text = "*在左侧选择样式，在右侧修改其内容";
            this.statementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paragraphStyleBindingSource
            // 
            this.paragraphStyleBindingSource.DataSource = typeof(WindowsFormsApp1.Models.ParagraphStyle);
            // 
            // styleGroupBindingSource
            // 
            this.styleGroupBindingSource.DataSource = typeof(WindowsFormsApp1.Models.StyleGroup);
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
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.execuateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Markdown转Word";
            this.Load += new System.EventHandler(this.CompLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editingGroupBox.ResumeLayout(false);
            this.editingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paragraphStyleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button execuateBtn;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox sourceMdPath;
        private System.Windows.Forms.CheckBox saveAtSameDirCheck;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource paragraphStyleBindingSource;
        private System.Windows.Forms.BindingSource styleGroupBindingSource;
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
        private System.Windows.Forms.NumericUpDown numericLineSpacing;
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
        private System.Windows.Forms.RadioButton customLineSpaceRadioBtn;
        private System.Windows.Forms.GroupBox editingGroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label colorPreviewLabel;
    }
}

