namespace WindowsFormsApp1
{
    partial class Form0
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
            this.presetListCmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPresetBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.changeH1Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeH2Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.changeH3Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.changeBodyTextBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.changeBlockBtn = new System.Windows.Forms.Button();
            this.changeCodeBlockBtn = new System.Windows.Forms.Button();
            this.h1Info = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.changeH4Btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.h2Info = new System.Windows.Forms.Label();
            this.h3Info = new System.Windows.Forms.Label();
            this.h4Info = new System.Windows.Forms.Label();
            this.bodyTextInfo = new System.Windows.Forms.Label();
            this.blockTextInfo = new System.Windows.Forms.Label();
            this.codeBlockInfo = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
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
            this.paragraphStyleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // presetListCmbox
            // 
            this.presetListCmbox.FormattingEnabled = true;
            this.presetListCmbox.Location = new System.Drawing.Point(170, 40);
            this.presetListCmbox.Name = "presetListCmbox";
            this.presetListCmbox.Size = new System.Drawing.Size(598, 32);
            this.presetListCmbox.TabIndex = 8;
            this.presetListCmbox.SelectedIndexChanged += new System.EventHandler(this.PresetListCmbox_SelectedIndexChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.presetListCmbox);
            this.groupBox1.Controls.Add(this.newPresetBtn);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.96719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.04993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.98288F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.changeH1Btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeH2Btn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.changeH3Btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.changeBodyTextBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.changeBlockBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.changeCodeBlockBtn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.h1Info, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.changeH4Btn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label21, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.h2Info, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.h3Info, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.h4Info, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bodyTextInfo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.blockTextInfo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.codeBlockInfo, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 285);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "## 二级标题";
            // 
            // changeH1Btn
            // 
            this.changeH1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeH1Btn.Location = new System.Drawing.Point(611, 3);
            this.changeH1Btn.Name = "changeH1Btn";
            this.changeH1Btn.Size = new System.Drawing.Size(76, 34);
            this.changeH1Btn.TabIndex = 6;
            this.changeH1Btn.Text = "修改...";
            this.changeH1Btn.UseVisualStyleBackColor = true;
            this.changeH1Btn.Click += new System.EventHandler(this.ShowFontDialogBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "# 一级标题";
            // 
            // changeH2Btn
            // 
            this.changeH2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeH2Btn.Location = new System.Drawing.Point(611, 43);
            this.changeH2Btn.Name = "changeH2Btn";
            this.changeH2Btn.Size = new System.Drawing.Size(76, 34);
            this.changeH2Btn.TabIndex = 6;
            this.changeH2Btn.Text = "修改...";
            this.changeH2Btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "### 三级标题";
            // 
            // changeH3Btn
            // 
            this.changeH3Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeH3Btn.Location = new System.Drawing.Point(611, 83);
            this.changeH3Btn.Name = "changeH3Btn";
            this.changeH3Btn.Size = new System.Drawing.Size(76, 34);
            this.changeH3Btn.TabIndex = 6;
            this.changeH3Btn.Text = "修改...";
            this.changeH3Btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "正文";
            // 
            // changeBodyTextBtn
            // 
            this.changeBodyTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeBodyTextBtn.Location = new System.Drawing.Point(611, 163);
            this.changeBodyTextBtn.Name = "changeBodyTextBtn";
            this.changeBodyTextBtn.Size = new System.Drawing.Size(76, 34);
            this.changeBodyTextBtn.TabIndex = 6;
            this.changeBodyTextBtn.Text = "修改...";
            this.changeBodyTextBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "> 引用块";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "``` 代码块";
            // 
            // changeBlockBtn
            // 
            this.changeBlockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeBlockBtn.Location = new System.Drawing.Point(611, 203);
            this.changeBlockBtn.Name = "changeBlockBtn";
            this.changeBlockBtn.Size = new System.Drawing.Size(76, 34);
            this.changeBlockBtn.TabIndex = 6;
            this.changeBlockBtn.Text = "修改...";
            this.changeBlockBtn.UseVisualStyleBackColor = true;
            // 
            // changeCodeBlockBtn
            // 
            this.changeCodeBlockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCodeBlockBtn.Location = new System.Drawing.Point(611, 245);
            this.changeCodeBlockBtn.Name = "changeCodeBlockBtn";
            this.changeCodeBlockBtn.Size = new System.Drawing.Size(76, 35);
            this.changeCodeBlockBtn.TabIndex = 6;
            this.changeCodeBlockBtn.Text = "修改...";
            this.changeCodeBlockBtn.UseVisualStyleBackColor = true;
            // 
            // h1Info
            // 
            this.h1Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.h1Info.AutoSize = true;
            this.h1Info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.h1Info.Location = new System.Drawing.Point(161, 8);
            this.h1Info.Name = "h1Info";
            this.h1Info.Size = new System.Drawing.Size(444, 23);
            this.h1Info.TabIndex = 9;
            this.h1Info.Text = "思源黑体 CN, 10磅, #000000, 加粗, 斜体";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "#### 四级标题";
            // 
            // changeH4Btn
            // 
            this.changeH4Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeH4Btn.Location = new System.Drawing.Point(611, 123);
            this.changeH4Btn.Name = "changeH4Btn";
            this.changeH4Btn.Size = new System.Drawing.Size(76, 34);
            this.changeH4Btn.TabIndex = 6;
            this.changeH4Btn.Text = "修改...";
            this.changeH4Btn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(761, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 31);
            this.textBox2.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(693, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "行距:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(761, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 31);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(761, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 31);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(761, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 31);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(761, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 31);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(761, 204);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(106, 31);
            this.textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(761, 247);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(106, 31);
            this.textBox8.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(693, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "行距:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(693, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 25);
            this.label17.TabIndex = 11;
            this.label17.Text = "行距:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(693, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 25);
            this.label18.TabIndex = 11;
            this.label18.Text = "行距:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(693, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 25);
            this.label19.TabIndex = 11;
            this.label19.Text = "行距:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(693, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 25);
            this.label20.TabIndex = 11;
            this.label20.Text = "行距:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(693, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 25);
            this.label21.TabIndex = 11;
            this.label21.Text = "行距:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // h2Info
            // 
            this.h2Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.h2Info.AutoSize = true;
            this.h2Info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.h2Info.Location = new System.Drawing.Point(161, 48);
            this.h2Info.Name = "h2Info";
            this.h2Info.Size = new System.Drawing.Size(444, 23);
            this.h2Info.TabIndex = 9;
            this.h2Info.Text = "<默认>";
            // 
            // h3Info
            // 
            this.h3Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.h3Info.AutoSize = true;
            this.h3Info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.h3Info.Location = new System.Drawing.Point(161, 88);
            this.h3Info.Name = "h3Info";
            this.h3Info.Size = new System.Drawing.Size(444, 23);
            this.h3Info.TabIndex = 9;
            this.h3Info.Text = "<默认>";
            // 
            // h4Info
            // 
            this.h4Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.h4Info.AutoSize = true;
            this.h4Info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.h4Info.Location = new System.Drawing.Point(161, 128);
            this.h4Info.Name = "h4Info";
            this.h4Info.Size = new System.Drawing.Size(444, 23);
            this.h4Info.TabIndex = 9;
            this.h4Info.Text = "<默认>";
            // 
            // bodyTextInfo
            // 
            this.bodyTextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextInfo.AutoSize = true;
            this.bodyTextInfo.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bodyTextInfo.Location = new System.Drawing.Point(161, 168);
            this.bodyTextInfo.Name = "bodyTextInfo";
            this.bodyTextInfo.Size = new System.Drawing.Size(444, 23);
            this.bodyTextInfo.TabIndex = 9;
            this.bodyTextInfo.Text = "<默认>";
            // 
            // blockTextInfo
            // 
            this.blockTextInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.blockTextInfo.AutoSize = true;
            this.blockTextInfo.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.blockTextInfo.Location = new System.Drawing.Point(161, 208);
            this.blockTextInfo.Name = "blockTextInfo";
            this.blockTextInfo.Size = new System.Drawing.Size(444, 23);
            this.blockTextInfo.TabIndex = 9;
            this.blockTextInfo.Text = "<默认>";
            // 
            // codeBlockInfo
            // 
            this.codeBlockInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBlockInfo.AutoSize = true;
            this.codeBlockInfo.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.codeBlockInfo.Location = new System.Drawing.Point(161, 251);
            this.codeBlockInfo.Name = "codeBlockInfo";
            this.codeBlockInfo.Size = new System.Drawing.Size(444, 23);
            this.codeBlockInfo.TabIndex = 9;
            this.codeBlockInfo.Text = "<默认>";
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
            // paragraphStyleBindingSource
            // 
            this.paragraphStyleBindingSource.DataSource = typeof(WindowsFormsApp1.Models.ParagraphStyle);
            // 
            // styleGroupBindingSource
            // 
            this.styleGroupBindingSource.DataSource = typeof(WindowsFormsApp1.Models.StyleGroup);
            // 
            // Form0
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
            this.Name = "Form0";
            this.Text = "Markdown转Word";
            this.Load += new System.EventHandler(this.CompLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceMdPath_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox presetListCmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.Button newPresetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox sourceMdPath;
        private System.Windows.Forms.CheckBox saveAtSameDirCheck;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeH1Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeH2Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeH3Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changeBodyTextBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeBlockBtn;
        private System.Windows.Forms.Button changeCodeBlockBtn;
        private System.Windows.Forms.Label h1Info;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeH4Btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label h2Info;
        private System.Windows.Forms.Label h3Info;
        private System.Windows.Forms.Label h4Info;
        private System.Windows.Forms.Label bodyTextInfo;
        private System.Windows.Forms.Label blockTextInfo;
        private System.Windows.Forms.Label codeBlockInfo;
        private System.Windows.Forms.BindingSource paragraphStyleBindingSource;
        private System.Windows.Forms.BindingSource styleGroupBindingSource;
    }
}

