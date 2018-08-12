namespace test
{
    partial class Test
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsimInsData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConvertTo = new System.Windows.Forms.Button();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bGeneratePass = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.nudPassLenght = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.clbGenerate = new System.Windows.Forms.CheckedListBox();
            this.Note = new System.Windows.Forms.TabPage();
            this.rtbxNotebad = new System.Windows.Forms.RichTextBox();
            this.Schetchik = new System.Windows.Forms.TabPage();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.LbCount = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtgnrtr = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tBFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.cbConvertTo = new System.Windows.Forms.ComboBox();
            this.btnChangeConv = new System.Windows.Forms.Button();
            this.cbMetrik = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).BeginInit();
            this.Note.SuspendLayout();
            this.Schetchik.SuspendLayout();
            this.Random.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsimInsData,
            this.tsmiInsTime,
            this.tsmiTimeDate,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsimInsData
            // 
            this.tsimInsData.Name = "tsimInsData";
            this.tsimInsData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsimInsData.Size = new System.Drawing.Size(239, 22);
            this.tsimInsData.Text = "Вставить дату";
            this.tsimInsData.Click += new System.EventHandler(this.tsimInsData_Click);
            // 
            // tsmiInsTime
            // 
            this.tsmiInsTime.Name = "tsmiInsTime";
            this.tsmiInsTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsTime.Size = new System.Drawing.Size(239, 22);
            this.tsmiInsTime.Text = "Встравить время";
            this.tsmiInsTime.Click += new System.EventHandler(this.tsmiInsTime_Click);
            // 
            // tsmiTimeDate
            // 
            this.tsmiTimeDate.Name = "tsmiTimeDate";
            this.tsmiTimeDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.tsmiTimeDate.Size = new System.Drawing.Size(239, 22);
            this.tsmiTimeDate.Text = "Время и дата";
            this.tsmiTimeDate.Click += new System.EventHandler(this.tsmiTimeDate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiSave.Size = new System.Drawing.Size(239, 22);
            this.tsmiSave.Text = "Сохранить блокнот";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.tsmiLoad.Size = new System.Drawing.Size(239, 22);
            this.tsmiLoad.Text = "Загрузить блокнот";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Note);
            this.tabControl1.Controls.Add(this.Schetchik);
            this.tabControl1.Controls.Add(this.Random);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbMetrik);
            this.tabPage2.Controls.Add(this.btnChangeConv);
            this.tabPage2.Controls.Add(this.cbConvertTo);
            this.tabPage2.Controls.Add(this.tbTo);
            this.tabPage2.Controls.Add(this.tBFrom);
            this.tabPage2.Controls.Add(this.btnConvertTo);
            this.tabPage2.Controls.Add(this.cbConvertFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(276, 212);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Конвертер";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConvertTo
            // 
            this.btnConvertTo.Location = new System.Drawing.Point(101, 182);
            this.btnConvertTo.Name = "btnConvertTo";
            this.btnConvertTo.Size = new System.Drawing.Size(100, 23);
            this.btnConvertTo.TabIndex = 2;
            this.btnConvertTo.Text = "Конвертировать";
            this.btnConvertTo.UseVisualStyleBackColor = true;
            this.btnConvertTo.Click += new System.EventHandler(this.btnConvertTo_Click);
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.cbConvertFrom.Location = new System.Drawing.Point(22, 114);
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(73, 21);
            this.cbConvertFrom.TabIndex = 0;
            this.cbConvertFrom.Text = "мм";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bGeneratePass);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.nudPassLenght);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.clbGenerate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(276, 212);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Генератор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bGeneratePass
            // 
            this.bGeneratePass.Location = new System.Drawing.Point(175, 46);
            this.bGeneratePass.Name = "bGeneratePass";
            this.bGeneratePass.Size = new System.Drawing.Size(75, 23);
            this.bGeneratePass.TabIndex = 5;
            this.bGeneratePass.Text = "Generate";
            this.bGeneratePass.UseVisualStyleBackColor = true;
            this.bGeneratePass.Click += new System.EventHandler(this.bGeneratePass_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 143);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // nudPassLenght
            // 
            this.nudPassLenght.Location = new System.Drawing.Point(89, 112);
            this.nudPassLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassLenght.Name = "nudPassLenght";
            this.nudPassLenght.Size = new System.Drawing.Size(39, 20);
            this.nudPassLenght.TabIndex = 3;
            this.nudPassLenght.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPassLenght.ValueChanged += new System.EventHandler(this.nudPassLenght_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина пароля";
            // 
            // clbGenerate
            // 
            this.clbGenerate.CheckOnClick = true;
            this.clbGenerate.FormattingEnabled = true;
            this.clbGenerate.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Символы"});
            this.clbGenerate.Location = new System.Drawing.Point(8, 15);
            this.clbGenerate.Name = "clbGenerate";
            this.clbGenerate.Size = new System.Drawing.Size(120, 64);
            this.clbGenerate.TabIndex = 0;
            // 
            // Note
            // 
            this.Note.Controls.Add(this.rtbxNotebad);
            this.Note.Location = new System.Drawing.Point(4, 22);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(276, 212);
            this.Note.TabIndex = 2;
            this.Note.Text = "Блокнот";
            this.Note.UseVisualStyleBackColor = true;
            // 
            // rtbxNotebad
            // 
            this.rtbxNotebad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbxNotebad.Location = new System.Drawing.Point(0, 0);
            this.rtbxNotebad.Name = "rtbxNotebad";
            this.rtbxNotebad.Size = new System.Drawing.Size(276, 212);
            this.rtbxNotebad.TabIndex = 0;
            this.rtbxNotebad.Text = "";
            // 
            // Schetchik
            // 
            this.Schetchik.Controls.Add(this.btnMinus);
            this.Schetchik.Controls.Add(this.btnReset);
            this.Schetchik.Controls.Add(this.btnPlus);
            this.Schetchik.Controls.Add(this.LbCount);
            this.Schetchik.Location = new System.Drawing.Point(4, 22);
            this.Schetchik.Name = "Schetchik";
            this.Schetchik.Padding = new System.Windows.Forms.Padding(3);
            this.Schetchik.Size = new System.Drawing.Size(276, 212);
            this.Schetchik.TabIndex = 0;
            this.Schetchik.Text = "Счетчик";
            this.Schetchik.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(167, 13);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(80, 36);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(125, 55);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(90, 13);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(71, 36);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbCount
            // 
            this.LbCount.AutoSize = true;
            this.LbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbCount.Location = new System.Drawing.Point(33, 25);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(21, 24);
            this.LbCount.TabIndex = 0;
            this.LbCount.Text = "0";
            this.LbCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // Random
            // 
            this.Random.Controls.Add(this.cbRandom);
            this.Random.Controls.Add(this.btnCopy);
            this.Random.Controls.Add(this.btnclear);
            this.Random.Controls.Add(this.txtgnrtr);
            this.Random.Controls.Add(this.lblRandom);
            this.Random.Controls.Add(this.lblTo);
            this.Random.Controls.Add(this.numericUpDown2);
            this.Random.Controls.Add(this.numericUpDown1);
            this.Random.Controls.Add(this.lblFrom);
            this.Random.Controls.Add(this.btnGenerate);
            this.Random.Location = new System.Drawing.Point(4, 22);
            this.Random.Name = "Random";
            this.Random.Padding = new System.Windows.Forms.Padding(3);
            this.Random.Size = new System.Drawing.Size(276, 212);
            this.Random.TabIndex = 1;
            this.Random.Text = "Генератор";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(163, 14);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(107, 17);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "Без повторений";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(153, 80);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(136, 159);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 29);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtgnrtr
            // 
            this.txtgnrtr.Location = new System.Drawing.Point(25, 63);
            this.txtgnrtr.Multiline = true;
            this.txtgnrtr.Name = "txtgnrtr";
            this.txtgnrtr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtgnrtr.Size = new System.Drawing.Size(105, 125);
            this.txtgnrtr.TabIndex = 6;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(130, 44);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 13);
            this.lblRandom.TabIndex = 5;
            this.lblRandom.Click += new System.EventHandler(this.lblRandom_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 39);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "До";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(32, 37);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(32, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(20, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "От";
            this.lblFrom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(78, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Random";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tBFrom
            // 
            this.tBFrom.Location = new System.Drawing.Point(37, 185);
            this.tBFrom.Name = "tBFrom";
            this.tBFrom.Size = new System.Drawing.Size(58, 20);
            this.tBFrom.TabIndex = 3;
            this.tBFrom.Text = "1";
            this.tBFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(101, 143);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(75, 20);
            this.tbTo.TabIndex = 4;
            // 
            // cbConvertTo
            // 
            this.cbConvertTo.FormattingEnabled = true;
            this.cbConvertTo.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "мили"});
            this.cbConvertTo.Location = new System.Drawing.Point(182, 114);
            this.cbConvertTo.Name = "cbConvertTo";
            this.cbConvertTo.Size = new System.Drawing.Size(79, 21);
            this.cbConvertTo.TabIndex = 5;
            this.cbConvertTo.Text = "мм";
            // 
            // btnChangeConv
            // 
            this.btnChangeConv.Location = new System.Drawing.Point(101, 112);
            this.btnChangeConv.Name = "btnChangeConv";
            this.btnChangeConv.Size = new System.Drawing.Size(75, 23);
            this.btnChangeConv.TabIndex = 6;
            this.btnChangeConv.Text = "<->";
            this.btnChangeConv.UseVisualStyleBackColor = true;
            this.btnChangeConv.Click += new System.EventHandler(this.btnChangeConv_Click);
            // 
            // cbMetrik
            // 
            this.cbMetrik.FormattingEnabled = true;
            this.cbMetrik.Items.AddRange(new object[] {
            "Длина",
            "Вес"});
            this.cbMetrik.Location = new System.Drawing.Point(101, 74);
            this.cbMetrik.Name = "cbMetrik";
            this.cbMetrik.Size = new System.Drawing.Size(66, 21);
            this.cbMetrik.TabIndex = 7;
            this.cbMetrik.Text = "Длина";
            this.cbMetrik.SelectedIndexChanged += new System.EventHandler(this.cbMetrik_SelectedIndexChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Test";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Test_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLenght)).EndInit();
            this.Note.ResumeLayout(false);
            this.Schetchik.ResumeLayout(false);
            this.Schetchik.PerformLayout();
            this.Random.ResumeLayout(false);
            this.Random.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Schetchik;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TabPage Random;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TextBox txtgnrtr;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TabPage Note;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsimInsData;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsTime;
        private System.Windows.Forms.RichTextBox rtbxNotebad;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeDate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox clbGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassLenght;
        private System.Windows.Forms.Button bGeneratePass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConvertTo;
        private System.Windows.Forms.ComboBox cbConvertFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tBFrom;
        private System.Windows.Forms.ComboBox cbConvertTo;
        private System.Windows.Forms.Button btnChangeConv;
        private System.Windows.Forms.ComboBox cbMetrik;
    }
}

