using LibaryWord;

namespace WinFormsAppLab3
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridLanguageWords = new System.Windows.Forms.DataGridView();
            this.Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CancelButtonTab1 = new System.Windows.Forms.Button();
            this.SaveButtonTab1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.practiceButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.NumberOfLanguage = new System.Windows.Forms.NumericUpDown();
            this.CanelButtonTab2 = new System.Windows.Forms.Button();
            this.SavebuttonTab2 = new System.Windows.Forms.Button();
            this.Language9Label = new System.Windows.Forms.Label();
            this.Language9TextBox = new System.Windows.Forms.TextBox();
            this.Language8Label = new System.Windows.Forms.Label();
            this.Language8TextBox = new System.Windows.Forms.TextBox();
            this.Language7Label = new System.Windows.Forms.Label();
            this.Language7TextBox = new System.Windows.Forms.TextBox();
            this.Language6Label = new System.Windows.Forms.Label();
            this.Language6TextBox = new System.Windows.Forms.TextBox();
            this.Language5Label = new System.Windows.Forms.Label();
            this.Language5TextBox = new System.Windows.Forms.TextBox();
            this.Language4Label = new System.Windows.Forms.Label();
            this.Language4TextBox = new System.Windows.Forms.TextBox();
            this.Language3Label = new System.Windows.Forms.Label();
            this.Language2Label = new System.Windows.Forms.Label();
            this.Language1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Language3TextBox = new System.Windows.Forms.TextBox();
            this.Language2TextBox = new System.Windows.Forms.TextBox();
            this.Language1TextBox = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.StatisticLabelTab3 = new System.Windows.Forms.Label();
            this.falseCorrectLabelTab3 = new System.Windows.Forms.Label();
            this.submitButtonTab3 = new System.Windows.Forms.Button();
            this.EndPracticeButtonTab3 = new System.Windows.Forms.Button();
            this.CancelButtonTab3 = new System.Windows.Forms.Button();
            this.PracticeAnswerTextBox = new System.Windows.Forms.TextBox();
            this.TranslateLabelTab3 = new System.Windows.Forms.Label();
            this.PracticeLabelTab3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanguageWords)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLanguage)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(782, 425);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(8, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridLanguageWords
            // 
            this.dataGridLanguageWords.AllowUserToAddRows = false;
            this.dataGridLanguageWords.AllowUserToDeleteRows = false;
            this.dataGridLanguageWords.AllowUserToResizeColumns = false;
            this.dataGridLanguageWords.AllowUserToResizeRows = false;
            this.dataGridLanguageWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLanguageWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLanguageWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLanguageWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Languages,
            this.Language2});
            this.dataGridLanguageWords.Location = new System.Drawing.Point(194, 39);
            this.dataGridLanguageWords.Name = "dataGridLanguageWords";
            this.dataGridLanguageWords.ReadOnly = true;
            this.dataGridLanguageWords.RowHeadersVisible = false;
            this.dataGridLanguageWords.RowHeadersWidth = 51;
            this.dataGridLanguageWords.RowTemplate.Height = 29;
            this.dataGridLanguageWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLanguageWords.Size = new System.Drawing.Size(424, 324);
            this.dataGridLanguageWords.TabIndex = 3;
            this.dataGridLanguageWords.Visible = false;
            this.dataGridLanguageWords.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLanguageWords_CellEndEdit);
            // 
            // Languages
            // 
            this.Languages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Languages.HeaderText = "Language1";
            this.Languages.MinimumWidth = 6;
            this.Languages.Name = "Languages";
            this.Languages.ReadOnly = true;
            // 
            // Language2
            // 
            this.Language2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Language2.HeaderText = "Language2";
            this.Language2.MinimumWidth = 6;
            this.Language2.Name = "Language2";
            this.Language2.ReadOnly = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(782, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(782, 453);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 425);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.CancelButtonTab1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.SaveButtonTab1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.practiceButton);
            this.tabPage1.Controls.Add(this.dataGridLanguageWords);
            this.tabPage1.Controls.Add(this.removeButton);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // CancelButtonTab1
            // 
            this.CancelButtonTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButtonTab1.Location = new System.Drawing.Point(647, 334);
            this.CancelButtonTab1.Name = "CancelButtonTab1";
            this.CancelButtonTab1.Size = new System.Drawing.Size(94, 29);
            this.CancelButtonTab1.TabIndex = 10;
            this.CancelButtonTab1.Text = "Cancel";
            this.CancelButtonTab1.UseVisualStyleBackColor = true;
            this.CancelButtonTab1.Visible = false;
            this.CancelButtonTab1.Click += new System.EventHandler(this.CancelButtonTab1_Click);
            // 
            // SaveButtonTab1
            // 
            this.SaveButtonTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButtonTab1.Location = new System.Drawing.Point(647, 175);
            this.SaveButtonTab1.Name = "SaveButtonTab1";
            this.SaveButtonTab1.Size = new System.Drawing.Size(94, 29);
            this.SaveButtonTab1.TabIndex = 7;
            this.SaveButtonTab1.Text = "Save";
            this.SaveButtonTab1.UseVisualStyleBackColor = true;
            this.SaveButtonTab1.Visible = false;
            this.SaveButtonTab1.Click += new System.EventHandler(this.saveButtonTab1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a List:";
            // 
            // practiceButton
            // 
            this.practiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.practiceButton.Location = new System.Drawing.Point(647, 129);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(94, 29);
            this.practiceButton.TabIndex = 6;
            this.practiceButton.Text = "Practice";
            this.practiceButton.UseVisualStyleBackColor = true;
            this.practiceButton.Visible = false;
            this.practiceButton.Click += new System.EventHandler(this.practiceButtonTab1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(647, 83);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 29);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButtonTab1_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(647, 39);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButtonTab1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.NumberOfLanguage);
            this.tabPage2.Controls.Add(this.CanelButtonTab2);
            this.tabPage2.Controls.Add(this.SavebuttonTab2);
            this.tabPage2.Controls.Add(this.Language9Label);
            this.tabPage2.Controls.Add(this.Language9TextBox);
            this.tabPage2.Controls.Add(this.Language8Label);
            this.tabPage2.Controls.Add(this.Language8TextBox);
            this.tabPage2.Controls.Add(this.Language7Label);
            this.tabPage2.Controls.Add(this.Language7TextBox);
            this.tabPage2.Controls.Add(this.Language6Label);
            this.tabPage2.Controls.Add(this.Language6TextBox);
            this.tabPage2.Controls.Add(this.Language5Label);
            this.tabPage2.Controls.Add(this.Language5TextBox);
            this.tabPage2.Controls.Add(this.Language4Label);
            this.tabPage2.Controls.Add(this.Language4TextBox);
            this.tabPage2.Controls.Add(this.Language3Label);
            this.tabPage2.Controls.Add(this.Language2Label);
            this.tabPage2.Controls.Add(this.Language1Label);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Language3TextBox);
            this.tabPage2.Controls.Add(this.Language2TextBox);
            this.tabPage2.Controls.Add(this.Language1TextBox);
            this.tabPage2.Controls.Add(this.FileNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(557, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Enter number of language:";
            // 
            // NumberOfLanguage
            // 
            this.NumberOfLanguage.Location = new System.Drawing.Point(557, 38);
            this.NumberOfLanguage.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumberOfLanguage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberOfLanguage.Name = "NumberOfLanguage";
            this.NumberOfLanguage.ReadOnly = true;
            this.NumberOfLanguage.Size = new System.Drawing.Size(125, 27);
            this.NumberOfLanguage.TabIndex = 25;
            this.NumberOfLanguage.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumberOfLanguage.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CanelButtonTab2
            // 
            this.CanelButtonTab2.Location = new System.Drawing.Point(97, 281);
            this.CanelButtonTab2.Name = "CanelButtonTab2";
            this.CanelButtonTab2.Size = new System.Drawing.Size(125, 43);
            this.CanelButtonTab2.TabIndex = 24;
            this.CanelButtonTab2.Text = "Cancel";
            this.CanelButtonTab2.UseVisualStyleBackColor = true;
            this.CanelButtonTab2.Click += new System.EventHandler(this.cancelButtonTab2_Click);
            // 
            // SavebuttonTab2
            // 
            this.SavebuttonTab2.Enabled = false;
            this.SavebuttonTab2.Location = new System.Drawing.Point(557, 281);
            this.SavebuttonTab2.Name = "SavebuttonTab2";
            this.SavebuttonTab2.Size = new System.Drawing.Size(125, 43);
            this.SavebuttonTab2.TabIndex = 23;
            this.SavebuttonTab2.Text = "Save";
            this.SavebuttonTab2.UseVisualStyleBackColor = true;
            this.SavebuttonTab2.Click += new System.EventHandler(this.saveButtonTab2_Click);
            // 
            // Language9Label
            // 
            this.Language9Label.AutoSize = true;
            this.Language9Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language9Label.Location = new System.Drawing.Point(557, 185);
            this.Language9Label.Name = "Language9Label";
            this.Language9Label.Size = new System.Drawing.Size(89, 20);
            this.Language9Label.TabIndex = 22;
            this.Language9Label.Text = "Language 9:";
            this.Language9Label.Visible = false;
            // 
            // Language9TextBox
            // 
            this.Language9TextBox.Location = new System.Drawing.Point(557, 208);
            this.Language9TextBox.Name = "Language9TextBox";
            this.Language9TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language9TextBox.TabIndex = 21;
            this.Language9TextBox.Visible = false;
            // 
            // Language8Label
            // 
            this.Language8Label.AutoSize = true;
            this.Language8Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language8Label.Location = new System.Drawing.Point(557, 133);
            this.Language8Label.Name = "Language8Label";
            this.Language8Label.Size = new System.Drawing.Size(89, 20);
            this.Language8Label.TabIndex = 20;
            this.Language8Label.Text = "Language 8:";
            this.Language8Label.Visible = false;
            // 
            // Language8TextBox
            // 
            this.Language8TextBox.Location = new System.Drawing.Point(557, 156);
            this.Language8TextBox.Name = "Language8TextBox";
            this.Language8TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language8TextBox.TabIndex = 19;
            this.Language8TextBox.Visible = false;
            // 
            // Language7Label
            // 
            this.Language7Label.AutoSize = true;
            this.Language7Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language7Label.Location = new System.Drawing.Point(557, 80);
            this.Language7Label.Name = "Language7Label";
            this.Language7Label.Size = new System.Drawing.Size(89, 20);
            this.Language7Label.TabIndex = 18;
            this.Language7Label.Text = "Language 7:";
            this.Language7Label.Visible = false;
            // 
            // Language7TextBox
            // 
            this.Language7TextBox.Location = new System.Drawing.Point(557, 103);
            this.Language7TextBox.Name = "Language7TextBox";
            this.Language7TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language7TextBox.TabIndex = 17;
            this.Language7TextBox.Visible = false;
            // 
            // Language6Label
            // 
            this.Language6Label.AutoSize = true;
            this.Language6Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language6Label.Location = new System.Drawing.Point(322, 185);
            this.Language6Label.Name = "Language6Label";
            this.Language6Label.Size = new System.Drawing.Size(89, 20);
            this.Language6Label.TabIndex = 16;
            this.Language6Label.Text = "Language 6:";
            this.Language6Label.Visible = false;
            // 
            // Language6TextBox
            // 
            this.Language6TextBox.Location = new System.Drawing.Point(322, 208);
            this.Language6TextBox.Name = "Language6TextBox";
            this.Language6TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language6TextBox.TabIndex = 15;
            this.Language6TextBox.Visible = false;
            // 
            // Language5Label
            // 
            this.Language5Label.AutoSize = true;
            this.Language5Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language5Label.Location = new System.Drawing.Point(322, 133);
            this.Language5Label.Name = "Language5Label";
            this.Language5Label.Size = new System.Drawing.Size(89, 20);
            this.Language5Label.TabIndex = 14;
            this.Language5Label.Text = "Language 5:";
            this.Language5Label.Visible = false;
            // 
            // Language5TextBox
            // 
            this.Language5TextBox.Location = new System.Drawing.Point(322, 156);
            this.Language5TextBox.Name = "Language5TextBox";
            this.Language5TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language5TextBox.TabIndex = 13;
            this.Language5TextBox.Visible = false;
            // 
            // Language4Label
            // 
            this.Language4Label.AutoSize = true;
            this.Language4Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language4Label.Location = new System.Drawing.Point(322, 80);
            this.Language4Label.Name = "Language4Label";
            this.Language4Label.Size = new System.Drawing.Size(89, 20);
            this.Language4Label.TabIndex = 12;
            this.Language4Label.Text = "Language 4:";
            this.Language4Label.Visible = false;
            // 
            // Language4TextBox
            // 
            this.Language4TextBox.Location = new System.Drawing.Point(322, 103);
            this.Language4TextBox.Name = "Language4TextBox";
            this.Language4TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language4TextBox.TabIndex = 11;
            this.Language4TextBox.Visible = false;
            // 
            // Language3Label
            // 
            this.Language3Label.AutoSize = true;
            this.Language3Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language3Label.Location = new System.Drawing.Point(97, 185);
            this.Language3Label.Name = "Language3Label";
            this.Language3Label.Size = new System.Drawing.Size(89, 20);
            this.Language3Label.TabIndex = 10;
            this.Language3Label.Text = "Language 3:";
            this.Language3Label.Visible = false;
            // 
            // Language2Label
            // 
            this.Language2Label.AutoSize = true;
            this.Language2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language2Label.Location = new System.Drawing.Point(97, 132);
            this.Language2Label.Name = "Language2Label";
            this.Language2Label.Size = new System.Drawing.Size(89, 20);
            this.Language2Label.TabIndex = 9;
            this.Language2Label.Text = "Language 2:";
            // 
            // Language1Label
            // 
            this.Language1Label.AutoSize = true;
            this.Language1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Language1Label.Location = new System.Drawing.Point(97, 80);
            this.Language1Label.Name = "Language1Label";
            this.Language1Label.Size = new System.Drawing.Size(89, 20);
            this.Language1Label.TabIndex = 8;
            this.Language1Label.Text = "Language 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(322, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Filename:";
            // 
            // Language3TextBox
            // 
            this.Language3TextBox.Location = new System.Drawing.Point(97, 208);
            this.Language3TextBox.Name = "Language3TextBox";
            this.Language3TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language3TextBox.TabIndex = 3;
            this.Language3TextBox.Visible = false;
            // 
            // Language2TextBox
            // 
            this.Language2TextBox.Location = new System.Drawing.Point(97, 156);
            this.Language2TextBox.Name = "Language2TextBox";
            this.Language2TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language2TextBox.TabIndex = 2;
            this.Language2TextBox.TextChanged += new System.EventHandler(this.Language2TextBox_TextChanged);
            // 
            // Language1TextBox
            // 
            this.Language1TextBox.Location = new System.Drawing.Point(97, 103);
            this.Language1TextBox.Name = "Language1TextBox";
            this.Language1TextBox.Size = new System.Drawing.Size(125, 27);
            this.Language1TextBox.TabIndex = 1;
            this.Language1TextBox.TextChanged += new System.EventHandler(this.Language1TextBox_TextChanged);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(322, 38);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.FileNameTextBox.TabIndex = 0;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.StatisticLabelTab3);
            this.tabPage3.Controls.Add(this.falseCorrectLabelTab3);
            this.tabPage3.Controls.Add(this.submitButtonTab3);
            this.tabPage3.Controls.Add(this.EndPracticeButtonTab3);
            this.tabPage3.Controls.Add(this.CancelButtonTab3);
            this.tabPage3.Controls.Add(this.PracticeAnswerTextBox);
            this.tabPage3.Controls.Add(this.TranslateLabelTab3);
            this.tabPage3.Controls.Add(this.PracticeLabelTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // StatisticLabelTab3
            // 
            this.StatisticLabelTab3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticLabelTab3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatisticLabelTab3.Location = new System.Drawing.Point(595, 33);
            this.StatisticLabelTab3.Name = "StatisticLabelTab3";
            this.StatisticLabelTab3.Size = new System.Drawing.Size(125, 165);
            this.StatisticLabelTab3.TabIndex = 7;
            this.StatisticLabelTab3.Text = "label3";
            this.StatisticLabelTab3.Visible = false;
            // 
            // falseCorrectLabelTab3
            // 
            this.falseCorrectLabelTab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.falseCorrectLabelTab3.AutoSize = true;
            this.falseCorrectLabelTab3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.falseCorrectLabelTab3.ForeColor = System.Drawing.Color.Lime;
            this.falseCorrectLabelTab3.Location = new System.Drawing.Point(595, 245);
            this.falseCorrectLabelTab3.Name = "falseCorrectLabelTab3";
            this.falseCorrectLabelTab3.Size = new System.Drawing.Size(110, 33);
            this.falseCorrectLabelTab3.TabIndex = 6;
            this.falseCorrectLabelTab3.Text = "Correct!";
            this.falseCorrectLabelTab3.Visible = false;
            // 
            // submitButtonTab3
            // 
            this.submitButtonTab3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitButtonTab3.Location = new System.Drawing.Point(342, 314);
            this.submitButtonTab3.Name = "submitButtonTab3";
            this.submitButtonTab3.Size = new System.Drawing.Size(94, 29);
            this.submitButtonTab3.TabIndex = 5;
            this.submitButtonTab3.Text = "Submit";
            this.submitButtonTab3.UseVisualStyleBackColor = true;
            this.submitButtonTab3.Click += new System.EventHandler(this.submitButtonTab3_Click);
            // 
            // EndPracticeButtonTab3
            // 
            this.EndPracticeButtonTab3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndPracticeButtonTab3.Location = new System.Drawing.Point(595, 314);
            this.EndPracticeButtonTab3.Name = "EndPracticeButtonTab3";
            this.EndPracticeButtonTab3.Size = new System.Drawing.Size(125, 29);
            this.EndPracticeButtonTab3.TabIndex = 4;
            this.EndPracticeButtonTab3.Text = "End Practice";
            this.EndPracticeButtonTab3.UseVisualStyleBackColor = true;
            this.EndPracticeButtonTab3.Click += new System.EventHandler(this.EndPracticeButtonTab3_Click);
            // 
            // CancelButtonTab3
            // 
            this.CancelButtonTab3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButtonTab3.Location = new System.Drawing.Point(53, 314);
            this.CancelButtonTab3.Name = "CancelButtonTab3";
            this.CancelButtonTab3.Size = new System.Drawing.Size(94, 29);
            this.CancelButtonTab3.TabIndex = 3;
            this.CancelButtonTab3.Text = "Cancel";
            this.CancelButtonTab3.UseVisualStyleBackColor = true;
            this.CancelButtonTab3.Click += new System.EventHandler(this.button1_Click);
            // 
            // PracticeAnswerTextBox
            // 
            this.PracticeAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PracticeAnswerTextBox.Location = new System.Drawing.Point(215, 245);
            this.PracticeAnswerTextBox.Name = "PracticeAnswerTextBox";
            this.PracticeAnswerTextBox.Size = new System.Drawing.Size(342, 27);
            this.PracticeAnswerTextBox.TabIndex = 2;
            this.PracticeAnswerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticeAnswerTextBox_KeyDown);
            // 
            // TranslateLabelTab3
            // 
            this.TranslateLabelTab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TranslateLabelTab3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TranslateLabelTab3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TranslateLabelTab3.Location = new System.Drawing.Point(53, 160);
            this.TranslateLabelTab3.Name = "TranslateLabelTab3";
            this.TranslateLabelTab3.Size = new System.Drawing.Size(584, 38);
            this.TranslateLabelTab3.TabIndex = 1;
            this.TranslateLabelTab3.Text = "Translate This to That:";
            // 
            // PracticeLabelTab3
            // 
            this.PracticeLabelTab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PracticeLabelTab3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PracticeLabelTab3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PracticeLabelTab3.Location = new System.Drawing.Point(215, 26);
            this.PracticeLabelTab3.Name = "PracticeLabelTab3";
            this.PracticeLabelTab3.Size = new System.Drawing.Size(342, 91);
            this.PracticeLabelTab3.TabIndex = 0;
            this.PracticeLabelTab3.Text = "Practice!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanguageWords)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfLanguage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ListBox listBox1;
        public DataGridView dataGridLanguageWords;
        private DataGridViewTextBoxColumn Languages;
        private DataGridViewTextBoxColumn Language2;
        private ToolStripContainer toolStripContainer1;
        private Button SaveButtonTab1;
        private Button practiceButton;
        private Button removeButton;
        private Button addButton;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label Language3Label;
        private Label Language2Label;
        private Label Language1Label;
        private Label label2;
        private TextBox Language3TextBox;
        private TextBox Language2TextBox;
        private TextBox Language1TextBox;
        private TextBox FileNameTextBox;
        private Label label12;
        private NumericUpDown NumberOfLanguage;
        private Button CanelButtonTab2;
        private Button SavebuttonTab2;
        private Label Language9Label;
        private TextBox Language9TextBox;
        private Label Language8Label;
        private TextBox Language8TextBox;
        private Label Language7Label;
        private TextBox Language7TextBox;
        private Label Language6Label;
        private TextBox Language6TextBox;
        private Label Language5Label;
        private TextBox Language5TextBox;
        private Label Language4Label;
        private TextBox Language4TextBox;
        private TabPage tabPage3;
        private TextBox PracticeAnswerTextBox;
        private Label TranslateLabelTab3;
        private Label PracticeLabelTab3;
        private SaveFileDialog saveFileDialog1;
        private Button CancelButtonTab1;
        private Button EndPracticeButtonTab3;
        private Button CancelButtonTab3;
        private Button submitButtonTab3;
        private Label falseCorrectLabelTab3;
        private Label StatisticLabelTab3;
    }
}