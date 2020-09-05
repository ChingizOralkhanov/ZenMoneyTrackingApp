namespace ZenMoney
{
    partial class formMain
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonExpences = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTimeBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutTabs = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.ReportWord = new System.Windows.Forms.Button();
            this.generateButtton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balanceBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceTitle = new System.Windows.Forms.Label();
            this.expenceBox = new System.Windows.Forms.PictureBox();
            this.expendituresNumber = new System.Windows.Forms.Label();
            this.expendituresTitle = new System.Windows.Forms.Label();
            this.incomeBox = new System.Windows.Forms.PictureBox();
            this.IncomeNumber = new System.Windows.Forms.Label();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.expencesTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addExpences = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.incomeTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.accountTab = new System.Windows.Forms.TabPage();
            this.ReportPDF = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.layoutTabs.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBox)).BeginInit();
            this.expencesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.incomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.indicator);
            this.panelHeader.Controls.Add(this.buttonAccount);
            this.panelHeader.Controls.Add(this.buttonExpences);
            this.panelHeader.Controls.Add(this.buttonIncome);
            this.panelHeader.Controls.Add(this.buttonDashboard);
            this.panelHeader.Controls.Add(this.panelTitleBar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 91);
            this.panelHeader.TabIndex = 3;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.indicator.Location = new System.Drawing.Point(24, 86);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(114, 5);
            this.indicator.TabIndex = 8;
            this.indicator.TabStop = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Location = new System.Drawing.Point(429, 61);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(114, 23);
            this.buttonAccount.TabIndex = 7;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.ButtonAccount_Click);
            // 
            // buttonExpences
            // 
            this.buttonExpences.BackColor = System.Drawing.Color.Transparent;
            this.buttonExpences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExpences.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExpences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpences.Location = new System.Drawing.Point(151, 61);
            this.buttonExpences.Name = "buttonExpences";
            this.buttonExpences.Size = new System.Drawing.Size(114, 23);
            this.buttonExpences.TabIndex = 6;
            this.buttonExpences.Text = "Expences";
            this.buttonExpences.UseVisualStyleBackColor = false;
            this.buttonExpences.Click += new System.EventHandler(this.ButtonExpences_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.BackColor = System.Drawing.Color.Transparent;
            this.buttonIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIncome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncome.Location = new System.Drawing.Point(290, 61);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(114, 23);
            this.buttonIncome.TabIndex = 5;
            this.buttonIncome.Text = "Income";
            this.buttonIncome.UseVisualStyleBackColor = false;
            this.buttonIncome.Click += new System.EventHandler(this.ButtonIncome_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.Location = new System.Drawing.Point(24, 61);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(114, 23);
            this.buttonDashboard.TabIndex = 4;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(94)))), ((int)(((byte)(194)))));
            this.panelTitleBar.Controls.Add(this.dateTimePicker1);
            this.panelTitleBar.Controls.Add(this.DateTimeBox);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 55);
            this.panelTitleBar.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 9, 17, 43, 49, 0);
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.AcceptsTab = true;
            this.DateTimeBox.Location = new System.Drawing.Point(646, 12);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.Size = new System.Drawing.Size(142, 23);
            this.DateTimeBox.TabIndex = 3;
            this.DateTimeBox.Text = "";
            this.DateTimeBox.TextChanged += new System.EventHandler(this.DateTimeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZMoney";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZenMoney.Properties.Resources.icons8_price_64px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.layoutTabs);
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 354);
            this.panel1.TabIndex = 4;
            // 
            // layoutTabs
            // 
            this.layoutTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.layoutTabs.Controls.Add(this.dashboardTab);
            this.layoutTabs.Controls.Add(this.expencesTab);
            this.layoutTabs.Controls.Add(this.incomeTab);
            this.layoutTabs.Controls.Add(this.accountTab);
            this.layoutTabs.Location = new System.Drawing.Point(0, 3);
            this.layoutTabs.Name = "layoutTabs";
            this.layoutTabs.SelectedIndex = 0;
            this.layoutTabs.Size = new System.Drawing.Size(800, 351);
            this.layoutTabs.TabIndex = 1;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.ReportPDF);
            this.dashboardTab.Controls.Add(this.ReportWord);
            this.dashboardTab.Controls.Add(this.generateButtton);
            this.dashboardTab.Controls.Add(this.panel2);
            this.dashboardTab.Location = new System.Drawing.Point(4, 4);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(792, 325);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // ReportWord
            // 
            this.ReportWord.Location = new System.Drawing.Point(3, 158);
            this.ReportWord.Name = "ReportWord";
            this.ReportWord.Size = new System.Drawing.Size(135, 23);
            this.ReportWord.TabIndex = 3;
            this.ReportWord.Text = "Создать отчет word";
            this.ReportWord.UseVisualStyleBackColor = true;
            this.ReportWord.Click += new System.EventHandler(this.ReportWord_Click);
            // 
            // generateButtton
            // 
            this.generateButtton.Location = new System.Drawing.Point(3, 129);
            this.generateButtton.Name = "generateButtton";
            this.generateButtton.Size = new System.Drawing.Size(135, 23);
            this.generateButtton.TabIndex = 2;
            this.generateButtton.Text = "Создать отчет xls";
            this.generateButtton.UseVisualStyleBackColor = true;
            this.generateButtton.Click += new System.EventHandler(this.GenerateButtton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.balanceBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.balanceTitle);
            this.panel2.Controls.Add(this.expenceBox);
            this.panel2.Controls.Add(this.expendituresNumber);
            this.panel2.Controls.Add(this.expendituresTitle);
            this.panel2.Controls.Add(this.incomeBox);
            this.panel2.Controls.Add(this.IncomeNumber);
            this.panel2.Controls.Add(this.IncomeLabel);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 117);
            this.panel2.TabIndex = 1;
            // 
            // balanceBox
            // 
            this.balanceBox.Image = global::ZenMoney.Properties.Resources.icons8_money_bag_80px_2;
            this.balanceBox.Location = new System.Drawing.Point(352, 0);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(58, 70);
            this.balanceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balanceBox.TabIndex = 8;
            this.balanceBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(416, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // balanceTitle
            // 
            this.balanceTitle.AutoSize = true;
            this.balanceTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.balanceTitle.Location = new System.Drawing.Point(416, 14);
            this.balanceTitle.Name = "balanceTitle";
            this.balanceTitle.Size = new System.Drawing.Size(73, 13);
            this.balanceTitle.TabIndex = 6;
            this.balanceTitle.Text = "Total Balance";
            // 
            // expenceBox
            // 
            this.expenceBox.Image = global::ZenMoney.Properties.Resources.icons8_request_money_100px;
            this.expenceBox.Location = new System.Drawing.Point(176, 0);
            this.expenceBox.Name = "expenceBox";
            this.expenceBox.Size = new System.Drawing.Size(60, 70);
            this.expenceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expenceBox.TabIndex = 5;
            this.expenceBox.TabStop = false;
            // 
            // expendituresNumber
            // 
            this.expendituresNumber.AutoSize = true;
            this.expendituresNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.expendituresNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expendituresNumber.Location = new System.Drawing.Point(242, 36);
            this.expendituresNumber.Name = "expendituresNumber";
            this.expendituresNumber.Size = new System.Drawing.Size(28, 13);
            this.expendituresNumber.TabIndex = 4;
            this.expendituresNumber.Text = "000";
            // 
            // expendituresTitle
            // 
            this.expendituresTitle.AutoSize = true;
            this.expendituresTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.expendituresTitle.Location = new System.Drawing.Point(242, 14);
            this.expendituresTitle.Name = "expendituresTitle";
            this.expendituresTitle.Size = new System.Drawing.Size(95, 13);
            this.expendituresTitle.TabIndex = 3;
            this.expendituresTitle.Text = "Total Expenditures";
            // 
            // incomeBox
            // 
            this.incomeBox.Image = global::ZenMoney.Properties.Resources.icons8_initiate_money_transfer_100px;
            this.incomeBox.Location = new System.Drawing.Point(3, 0);
            this.incomeBox.Name = "incomeBox";
            this.incomeBox.Size = new System.Drawing.Size(57, 70);
            this.incomeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incomeBox.TabIndex = 2;
            this.incomeBox.TabStop = false;
            // 
            // IncomeNumber
            // 
            this.IncomeNumber.AutoSize = true;
            this.IncomeNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IncomeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeNumber.Location = new System.Drawing.Point(66, 36);
            this.IncomeNumber.Name = "IncomeNumber";
            this.IncomeNumber.Size = new System.Drawing.Size(28, 13);
            this.IncomeNumber.TabIndex = 1;
            this.IncomeNumber.Text = "000";
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IncomeLabel.Location = new System.Drawing.Point(66, 14);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(69, 13);
            this.IncomeLabel.TabIndex = 0;
            this.IncomeLabel.Text = "Total Income";
            // 
            // expencesTab
            // 
            this.expencesTab.Controls.Add(this.dataGridView1);
            this.expencesTab.Controls.Add(this.addExpences);
            this.expencesTab.Controls.Add(this.searchBox);
            this.expencesTab.Location = new System.Drawing.Point(4, 4);
            this.expencesTab.Name = "expencesTab";
            this.expencesTab.Padding = new System.Windows.Forms.Padding(3);
            this.expencesTab.Size = new System.Drawing.Size(792, 325);
            this.expencesTab.TabIndex = 1;
            this.expencesTab.Text = "Expences";
            this.expencesTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(17, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 259);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Number";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Time";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Amount";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "On";
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Type";
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // addExpences
            // 
            this.addExpences.Location = new System.Drawing.Point(636, 6);
            this.addExpences.Name = "addExpences";
            this.addExpences.Size = new System.Drawing.Size(148, 23);
            this.addExpences.TabIndex = 3;
            this.addExpences.Text = "Add Expence";
            this.addExpences.UseVisualStyleBackColor = true;
            this.addExpences.Click += new System.EventHandler(this.AddExpences_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(17, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(114, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search Transaction";
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // incomeTab
            // 
            this.incomeTab.Controls.Add(this.dataGridView3);
            this.incomeTab.Controls.Add(this.button1);
            this.incomeTab.Controls.Add(this.dataGridView2);
            this.incomeTab.Location = new System.Drawing.Point(4, 4);
            this.incomeTab.Name = "incomeTab";
            this.incomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.incomeTab.Size = new System.Drawing.Size(792, 325);
            this.incomeTab.TabIndex = 2;
            this.incomeTab.Text = "Income";
            this.incomeTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView3.Location = new System.Drawing.Point(18, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(763, 250);
            this.dataGridView3.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Source";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Income";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(764, 250);
            this.dataGridView2.TabIndex = 0;
            // 
            // accountTab
            // 
            this.accountTab.Location = new System.Drawing.Point(4, 4);
            this.accountTab.Name = "accountTab";
            this.accountTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountTab.Size = new System.Drawing.Size(792, 325);
            this.accountTab.TabIndex = 3;
            this.accountTab.Text = "Account";
            this.accountTab.UseVisualStyleBackColor = true;
            // 
            // ReportPDF
            // 
            this.ReportPDF.Location = new System.Drawing.Point(3, 188);
            this.ReportPDF.Name = "ReportPDF";
            this.ReportPDF.Size = new System.Drawing.Size(135, 23);
            this.ReportPDF.TabIndex = 4;
            this.ReportPDF.Text = "Создать отчет pdf";
            this.ReportPDF.UseVisualStyleBackColor = true;
            this.ReportPDF.Click += new System.EventHandler(this.ReportPDF_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.layoutTabs.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBox)).EndInit();
            this.expencesTab.ResumeLayout(false);
            this.expencesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.incomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonExpences;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.RichTextBox DateTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox indicator;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl layoutTabs;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox balanceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balanceTitle;
        private System.Windows.Forms.PictureBox expenceBox;
        private System.Windows.Forms.Label expendituresNumber;
        private System.Windows.Forms.Label expendituresTitle;
        private System.Windows.Forms.PictureBox incomeBox;
        private System.Windows.Forms.Label IncomeNumber;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.TabPage expencesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button addExpences;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TabPage incomeTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage accountTab;
        private System.Windows.Forms.Button generateButtton;
        private System.Windows.Forms.Button ReportWord;
        private System.Windows.Forms.Button ReportPDF;
    }
}

