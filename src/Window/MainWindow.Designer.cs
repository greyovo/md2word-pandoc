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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.fontsSelComboBox = new System.Windows.Forms.ComboBox();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericOutlevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.colorInputBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.curStyleNameIdLabel = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.paragraphStyleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editingGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.resetBtn.Location = new System.Drawing.Point(14, 385);
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
            this.editingGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.editingGroupBox.Controls.Add(this.boldCheckBox);
            this.editingGroupBox.Controls.Add(this.italicCheckBox);
            this.editingGroupBox.Controls.Add(this.underlineCheckBox);
            this.editingGroupBox.Controls.Add(this.curStyleNameIdLabel);
            this.editingGroupBox.Controls.Add(this.statementLabel);
            this.editingGroupBox.Controls.Add(this.label7);
            this.editingGroupBox.Location = new System.Drawing.Point(219, 87);
            this.editingGroupBox.Name = "editingGroupBox";
            this.editingGroupBox.Size = new System.Drawing.Size(647, 268);
            this.editingGroupBox.TabIndex = 12;
            this.editingGroupBox.TabStop = false;
            this.editingGroupBox.Text = "编辑样式";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.98374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.36641F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericFontSize, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericLineSpacing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericOutlevel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.fontsSelComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 123);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "字体";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontsSelComboBox
            // 
            this.fontsSelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsSelComboBox.FormattingEnabled = true;
            this.fontsSelComboBox.Location = new System.Drawing.Point(89, 4);
            this.fontsSelComboBox.Name = "fontsSelComboBox";
            this.fontsSelComboBox.Size = new System.Drawing.Size(199, 32);
            this.fontsSelComboBox.TabIndex = 2;
            // 
            // numericFontSize
            // 
            this.numericFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFontSize.DecimalPlaces = 1;
            this.numericFontSize.Location = new System.Drawing.Point(417, 5);
            this.numericFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(195, 31);
            this.numericFontSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "字体大小";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "行距";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericLineSpacing
            // 
            this.numericLineSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLineSpacing.DecimalPlaces = 1;
            this.numericLineSpacing.Location = new System.Drawing.Point(89, 46);
            this.numericLineSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericLineSpacing.Name = "numericLineSpacing";
            this.numericLineSpacing.Size = new System.Drawing.Size(199, 31);
            this.numericLineSpacing.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "大纲级别";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericOutlevel
            // 
            this.numericOutlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOutlevel.Location = new System.Drawing.Point(417, 46);
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
            this.numericOutlevel.Size = new System.Drawing.Size(195, 31);
            this.numericOutlevel.TabIndex = 4;
            this.numericOutlevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "颜色";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorInputBox
            // 
            this.colorInputBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorInputBox.Location = new System.Drawing.Point(18, 2);
            this.colorInputBox.Name = "colorInputBox";
            this.colorInputBox.Size = new System.Drawing.Size(181, 31);
            this.colorInputBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(448, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "值为-1时表示正文";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(104, 172);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(72, 29);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "加粗";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(182, 172);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(72, 29);
            this.italicCheckBox.TabIndex = 6;
            this.italicCheckBox.Text = "斜体";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(260, 172);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(91, 29);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "下划线";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // curStyleNameIdLabel
            // 
            this.curStyleNameIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.curStyleNameIdLabel.AutoSize = true;
            this.curStyleNameIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curStyleNameIdLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.curStyleNameIdLabel.Location = new System.Drawing.Point(12, 231);
            this.curStyleNameIdLabel.Name = "curStyleNameIdLabel";
            this.curStyleNameIdLabel.Size = new System.Drawing.Size(13, 20);
            this.curStyleNameIdLabel.TabIndex = 0;
            this.curStyleNameIdLabel.Text = " ";
            this.curStyleNameIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statementLabel
            // 
            this.statementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statementLabel.AutoSize = true;
            this.statementLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statementLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statementLabel.Location = new System.Drawing.Point(375, 231);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(256, 20);
            this.statementLabel.TabIndex = 0;
            this.statementLabel.Text = "*在左侧选择样式，在右侧修改其内容";
            this.statementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "其他";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.colorInputBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(89, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 35);
            this.panel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-5, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "#";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOutlevel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.GroupBox editingGroupBox;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label curStyleNameIdLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
    }
}

