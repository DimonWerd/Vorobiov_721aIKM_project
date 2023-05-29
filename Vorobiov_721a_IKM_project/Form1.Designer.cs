
namespace Vorobiov_721a_IKM_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.tbInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.проНакопичувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.dgwOpen = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StackText = new System.Windows.Forms.Label();
            this.LabelStack = new System.Windows.Forms.Label();
            this.Stacktb = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.QueueText = new System.Windows.Forms.Label();
            this.LabelQueue = new System.Windows.Forms.Label();
            this.Queuetb = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(353, 312);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(94, 29);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Пуск";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tClock
            // 
            this.tClock.Interval = 25000;
            this.tClock.Tick += new System.EventHandler(this.tClock_Tick);
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(338, 212);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(125, 27);
            this.tbInput.TabIndex = 2;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.роботаToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийToolStripMenuItem,
            this.toolStripSeparator1,
            this.відкритиToolStripMenuItem,
            this.toolStripSeparator2,
            this.зберегтиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.toolStripSeparator3,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            this.новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            this.новийToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новийToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.новийToolStripMenuItem.Text = "Новий";
            this.новийToolStripMenuItem.Click += new System.EventHandler(this.новийToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // роботаToolStripMenuItem
            // 
            this.роботаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пускToolStripMenuItem,
            this.toolStripSeparator4,
            this.проНакопичувачіToolStripMenuItem});
            this.роботаToolStripMenuItem.Name = "роботаToolStripMenuItem";
            this.роботаToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.роботаToolStripMenuItem.Text = "Робота";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.bStart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(216, 6);
            // 
            // проНакопичувачіToolStripMenuItem
            // 
            this.проНакопичувачіToolStripMenuItem.Name = "проНакопичувачіToolStripMenuItem";
            this.проНакопичувачіToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.проНакопичувачіToolStripMenuItem.Text = "Про накопичувачі";
            this.проНакопичувачіToolStripMenuItem.Click += new System.EventHandler(this.проНакопичувачіToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "Wer";
            this.sfdSave.Filter = "working files|*.Wer|All files|*.*";
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "Wer";
            this.ofdOpen.FileName = "openFileDialog1";
            this.ofdOpen.Filter = "working files|*.Wer|All files|*.*";
            // 
            // dgwOpen
            // 
            this.dgwOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOpen.Location = new System.Drawing.Point(563, 50);
            this.dgwOpen.Name = "dgwOpen";
            this.dgwOpen.RowHeadersWidth = 51;
            this.dgwOpen.RowTemplate.Height = 29;
            this.dgwOpen.Size = new System.Drawing.Size(590, 291);
            this.dgwOpen.TabIndex = 4;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(806, 362);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(94, 29);
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(743, 397);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(221, 27);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 393);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Введення даних";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 27);
            this.textBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1144, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Робота з файлами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(646, 323);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(757, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 27);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1144, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Стек / Черга»";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.StackText);
            this.splitContainer1.Panel1.Controls.Add(this.LabelStack);
            this.splitContainer1.Panel1.Controls.Add(this.Stacktb);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.QueueText);
            this.splitContainer1.Panel2.Controls.Add(this.LabelQueue);
            this.splitContainer1.Panel2.Controls.Add(this.Queuetb);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 360);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 0;
            // 
            // StackText
            // 
            this.StackText.AutoSize = true;
            this.StackText.Location = new System.Drawing.Point(276, 47);
            this.StackText.Name = "StackText";
            this.StackText.Size = new System.Drawing.Size(39, 20);
            this.StackText.TabIndex = 5;
            this.StackText.Text = "Стек";
            // 
            // LabelStack
            // 
            this.LabelStack.AutoSize = true;
            this.LabelStack.Location = new System.Drawing.Point(276, 291);
            this.LabelStack.Name = "LabelStack";
            this.LabelStack.Size = new System.Drawing.Size(50, 20);
            this.LabelStack.TabIndex = 4;
            this.LabelStack.Text = "label2";
            // 
            // Stacktb
            // 
            this.Stacktb.Location = new System.Drawing.Point(149, 119);
            this.Stacktb.Name = "Stacktb";
            this.Stacktb.Size = new System.Drawing.Size(282, 27);
            this.Stacktb.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Peek";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Pop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Push";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // QueueText
            // 
            this.QueueText.AutoSize = true;
            this.QueueText.Location = new System.Drawing.Point(264, 48);
            this.QueueText.Name = "QueueText";
            this.QueueText.Size = new System.Drawing.Size(50, 20);
            this.QueueText.TabIndex = 11;
            this.QueueText.Text = "Черга";
            // 
            // LabelQueue
            // 
            this.LabelQueue.AutoSize = true;
            this.LabelQueue.Location = new System.Drawing.Point(264, 292);
            this.LabelQueue.Name = "LabelQueue";
            this.LabelQueue.Size = new System.Drawing.Size(50, 20);
            this.LabelQueue.TabIndex = 10;
            this.LabelQueue.Text = "label2";
            // 
            // Queuetb
            // 
            this.Queuetb.Location = new System.Drawing.Point(137, 120);
            this.Queuetb.Name = "Queuetb";
            this.Queuetb.Size = new System.Drawing.Size(282, 27);
            this.Queuetb.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(435, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 8;
            this.button6.Text = "Peek_q";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(241, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Dequeue";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(29, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 6;
            this.button8.Text = "Enqueue";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.dgwOpen);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOpen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem проНакопичувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.DataGridView dgwOpen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label StackText;
        private System.Windows.Forms.Label LabelStack;
        private System.Windows.Forms.TextBox Stacktb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label QueueText;
        private System.Windows.Forms.Label LabelQueue;
        private System.Windows.Forms.TextBox Queuetb;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

