namespace TaxiIS
{
    partial class MainForm
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxEditDriver = new System.Windows.Forms.ComboBox();
            this.textBoxEditDateTime = new System.Windows.Forms.TextBox();
            this.textBoxEditDestination = new System.Windows.Forms.TextBox();
            this.textBoxEditPickup = new System.Windows.Forms.TextBox();
            this.numericUpDownEditPrice = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxAddDriver = new System.Windows.Forms.ComboBox();
            this.textBoxAddDateTime = new System.Windows.Forms.TextBox();
            this.textBoxAddDestination = new System.Windows.Forms.TextBox();
            this.textBoxAddPickup = new System.Windows.Forms.TextBox();
            this.numericUpDownAddPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelSearchCount = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.colPickup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.panelSearchClients = new System.Windows.Forms.Panel();
            this.labelSearchCountClients = new System.Windows.Forms.Label();
            this.textBoxFilterClients = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxSearchClients = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxFilterClients = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exportPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPrice)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelSearchClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDBToolStripMenuItem,
            this.openDBToolStripMenuItem,
            this.saveDBToolStripMenuItem,
            this.deleteDBToolStripMenuItem,
            this.exportPDFToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createDBToolStripMenuItem
            // 
            this.createDBToolStripMenuItem.Name = "createDBToolStripMenuItem";
            this.createDBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createDBToolStripMenuItem.Text = "Создать БД";
            this.createDBToolStripMenuItem.Click += new System.EventHandler(this.createDBToolStripMenuItem_Click);
            // 
            // openDBToolStripMenuItem
            // 
            this.openDBToolStripMenuItem.Name = "openDBToolStripMenuItem";
            this.openDBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openDBToolStripMenuItem.Text = "Открыть БД";
            this.openDBToolStripMenuItem.Click += new System.EventHandler(this.openDBToolStripMenuItem_Click);
            // 
            // saveDBToolStripMenuItem
            // 
            this.saveDBToolStripMenuItem.Name = "saveDBToolStripMenuItem";
            this.saveDBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveDBToolStripMenuItem.Text = "Сохранить БД";
            this.saveDBToolStripMenuItem.Click += new System.EventHandler(this.saveDBToolStripMenuItem_Click);
            // 
            // deleteDBToolStripMenuItem
            // 
            this.deleteDBToolStripMenuItem.Name = "deleteDBToolStripMenuItem";
            this.deleteDBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteDBToolStripMenuItem.Text = "Удалить БД";
            this.deleteDBToolStripMenuItem.Click += new System.EventHandler(this.deleteDBToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.driversToolStripMenuItem.Text = "Водители";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 784);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.comboBoxEditDriver);
            this.tabPage1.Controls.Add(this.textBoxEditDateTime);
            this.tabPage1.Controls.Add(this.textBoxEditDestination);
            this.tabPage1.Controls.Add(this.textBoxEditPickup);
            this.tabPage1.Controls.Add(this.numericUpDownEditPrice);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.comboBoxAddDriver);
            this.tabPage1.Controls.Add(this.textBoxAddDateTime);
            this.tabPage1.Controls.Add(this.textBoxAddDestination);
            this.tabPage1.Controls.Add(this.textBoxAddPickup);
            this.tabPage1.Controls.Add(this.numericUpDownAddPrice);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.panelSearch);
            this.tabPage1.Controls.Add(this.dataGridViewOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 755);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            // 
            // comboBoxEditDriver
            // 
            this.comboBoxEditDriver.FormattingEnabled = true;
            this.comboBoxEditDriver.Location = new System.Drawing.Point(600, 710);
            this.comboBoxEditDriver.Name = "comboBoxEditDriver";
            this.comboBoxEditDriver.Size = new System.Drawing.Size(143, 24);
            this.comboBoxEditDriver.TabIndex = 29;
            // 
            // textBoxEditDateTime
            // 
            this.textBoxEditDateTime.Location = new System.Drawing.Point(600, 638);
            this.textBoxEditDateTime.Name = "textBoxEditDateTime";
            this.textBoxEditDateTime.Size = new System.Drawing.Size(143, 22);
            this.textBoxEditDateTime.TabIndex = 28;
            // 
            // textBoxEditDestination
            // 
            this.textBoxEditDestination.Location = new System.Drawing.Point(600, 602);
            this.textBoxEditDestination.Name = "textBoxEditDestination";
            this.textBoxEditDestination.Size = new System.Drawing.Size(143, 22);
            this.textBoxEditDestination.TabIndex = 27;
            // 
            // textBoxEditPickup
            // 
            this.textBoxEditPickup.Location = new System.Drawing.Point(600, 566);
            this.textBoxEditPickup.Name = "textBoxEditPickup";
            this.textBoxEditPickup.Size = new System.Drawing.Size(143, 22);
            this.textBoxEditPickup.TabIndex = 26;
            // 
            // numericUpDownEditPrice
            // 
            this.numericUpDownEditPrice.Location = new System.Drawing.Point(600, 674);
            this.numericUpDownEditPrice.Name = "numericUpDownEditPrice";
            this.numericUpDownEditPrice.Size = new System.Drawing.Size(143, 22);
            this.numericUpDownEditPrice.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Водитель";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 674);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Стоимость";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Дата и время";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(430, 602);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Адрес назначения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(430, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Адрес подачи";
            // 
            // comboBoxAddDriver
            // 
            this.comboBoxAddDriver.FormattingEnabled = true;
            this.comboBoxAddDriver.Location = new System.Drawing.Point(177, 705);
            this.comboBoxAddDriver.Name = "comboBoxAddDriver";
            this.comboBoxAddDriver.Size = new System.Drawing.Size(143, 24);
            this.comboBoxAddDriver.TabIndex = 19;
            // 
            // textBoxAddDateTime
            // 
            this.textBoxAddDateTime.Location = new System.Drawing.Point(177, 637);
            this.textBoxAddDateTime.Name = "textBoxAddDateTime";
            this.textBoxAddDateTime.Size = new System.Drawing.Size(143, 22);
            this.textBoxAddDateTime.TabIndex = 18;
            // 
            // textBoxAddDestination
            // 
            this.textBoxAddDestination.Location = new System.Drawing.Point(177, 603);
            this.textBoxAddDestination.Name = "textBoxAddDestination";
            this.textBoxAddDestination.Size = new System.Drawing.Size(143, 22);
            this.textBoxAddDestination.TabIndex = 17;
            // 
            // textBoxAddPickup
            // 
            this.textBoxAddPickup.Location = new System.Drawing.Point(177, 569);
            this.textBoxAddPickup.Name = "textBoxAddPickup";
            this.textBoxAddPickup.Size = new System.Drawing.Size(143, 22);
            this.textBoxAddPickup.TabIndex = 16;
            // 
            // numericUpDownAddPrice
            // 
            this.numericUpDownAddPrice.Location = new System.Drawing.Point(177, 671);
            this.numericUpDownAddPrice.Name = "numericUpDownAddPrice";
            this.numericUpDownAddPrice.Size = new System.Drawing.Size(143, 22);
            this.numericUpDownAddPrice.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 705);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Водитель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Стоимость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата и время";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес назначения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Адрес подачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(470, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Редактирование заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(93, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Добавление заказа";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(474, 471);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(173, 37);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить заказ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(474, 427);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(173, 37);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редактировать заказ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(474, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 37);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить заказ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.labelSearchCount);
            this.panelSearch.Controls.Add(this.textBoxFilter);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.comboBoxFilter);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Location = new System.Drawing.Point(7, 380);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(313, 146);
            this.panelSearch.TabIndex = 3;
            // 
            // labelSearchCount
            // 
            this.labelSearchCount.AutoSize = true;
            this.labelSearchCount.Location = new System.Drawing.Point(12, 114);
            this.labelSearchCount.Name = "labelSearchCount";
            this.labelSearchCount.Size = new System.Drawing.Size(78, 16);
            this.labelSearchCount.TabIndex = 6;
            this.labelSearchCount.Text = "Найдено: 0";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(153, 75);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilter.TabIndex = 5;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фильтр";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(153, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Адрес подачи",
            "Адрес назначения",
            "Дата и время",
            "Стоимость",
            "Водитель",
            "Госномер"});
            this.comboBoxFilter.Location = new System.Drawing.Point(153, 9);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Критерий поиска";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPickup,
            this.colDestination,
            this.colDateTime,
            this.colPrice,
            this.colDriver,
            this.colPlate});
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(768, 367);
            this.dataGridViewOrders.TabIndex = 2;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // colPickup
            // 
            this.colPickup.HeaderText = "Адрес подачи";
            this.colPickup.MinimumWidth = 6;
            this.colPickup.Name = "colPickup";
            this.colPickup.ReadOnly = true;
            // 
            // colDestination
            // 
            this.colDestination.HeaderText = "Адрес назначения";
            this.colDestination.MinimumWidth = 6;
            this.colDestination.Name = "colDestination";
            this.colDestination.ReadOnly = true;
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Дата и время";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Стоимость";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDriver
            // 
            this.colDriver.HeaderText = "Водитель";
            this.colDriver.MinimumWidth = 6;
            this.colDriver.Name = "colDriver";
            this.colDriver.ReadOnly = true;
            // 
            // colPlate
            // 
            this.colPlate.HeaderText = "Госномер";
            this.colPlate.MinimumWidth = 6;
            this.colPlate.Name = "colPlate";
            this.colPlate.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.panelSearchClients);
            this.tabPage2.Controls.Add(this.buttonDeleteClient);
            this.tabPage2.Controls.Add(this.buttonEditClient);
            this.tabPage2.Controls.Add(this.buttonAddClient);
            this.tabPage2.Controls.Add(this.textBoxClientPhone);
            this.tabPage2.Controls.Add(this.textBoxClientName);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.dataGridViewClients);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 755);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(262, 536);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(269, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Добавление / Редактирование";
            // 
            // panelSearchClients
            // 
            this.panelSearchClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchClients.Controls.Add(this.labelSearchCountClients);
            this.panelSearchClients.Controls.Add(this.textBoxFilterClients);
            this.panelSearchClients.Controls.Add(this.label19);
            this.panelSearchClients.Controls.Add(this.textBoxSearchClients);
            this.panelSearchClients.Controls.Add(this.label20);
            this.panelSearchClients.Controls.Add(this.comboBoxFilterClients);
            this.panelSearchClients.Controls.Add(this.label21);
            this.panelSearchClients.Location = new System.Drawing.Point(6, 376);
            this.panelSearchClients.Name = "panelSearchClients";
            this.panelSearchClients.Size = new System.Drawing.Size(313, 146);
            this.panelSearchClients.TabIndex = 25;
            // 
            // labelSearchCountClients
            // 
            this.labelSearchCountClients.AutoSize = true;
            this.labelSearchCountClients.Location = new System.Drawing.Point(12, 114);
            this.labelSearchCountClients.Name = "labelSearchCountClients";
            this.labelSearchCountClients.Size = new System.Drawing.Size(78, 16);
            this.labelSearchCountClients.TabIndex = 6;
            this.labelSearchCountClients.Text = "Найдено: 0";
            // 
            // textBoxFilterClients
            // 
            this.textBoxFilterClients.Location = new System.Drawing.Point(153, 75);
            this.textBoxFilterClients.Name = "textBoxFilterClients";
            this.textBoxFilterClients.Size = new System.Drawing.Size(100, 22);
            this.textBoxFilterClients.TabIndex = 5;
            this.textBoxFilterClients.TextChanged += new System.EventHandler(this.textBoxFilterClients_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Фильтр";
            // 
            // textBoxSearchClients
            // 
            this.textBoxSearchClients.Location = new System.Drawing.Point(153, 43);
            this.textBoxSearchClients.Name = "textBoxSearchClients";
            this.textBoxSearchClients.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearchClients.TabIndex = 3;
            this.textBoxSearchClients.TextChanged += new System.EventHandler(this.textBoxSearchClients_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Поиск";
            // 
            // comboBoxFilterClients
            // 
            this.comboBoxFilterClients.FormattingEnabled = true;
            this.comboBoxFilterClients.Items.AddRange(new object[] {
            "ФИО",
            "Телефон"});
            this.comboBoxFilterClients.Location = new System.Drawing.Point(153, 9);
            this.comboBoxFilterClients.Name = "comboBoxFilterClients";
            this.comboBoxFilterClients.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilterClients.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Критерий поиска";
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(481, 474);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(173, 37);
            this.buttonDeleteClient.TabIndex = 24;
            this.buttonDeleteClient.Text = "Удалить клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(481, 430);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(173, 37);
            this.buttonEditClient.TabIndex = 23;
            this.buttonEditClient.Text = "Редактировать клиента";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(481, 386);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(173, 37);
            this.buttonAddClient.TabIndex = 22;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(410, 615);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(143, 22);
            this.textBoxClientPhone.TabIndex = 21;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(410, 581);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(143, 22);
            this.textBoxClientName.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 615);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Телефон";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 581);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "ФИО клиента";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientName,
            this.colClientPhone});
            this.dataGridViewClients.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(768, 364);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewClients_SelectionChanged);
            // 
            // colClientName
            // 
            this.colClientName.HeaderText = "ФИО";
            this.colClientName.MinimumWidth = 6;
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colClientPhone
            // 
            this.colClientPhone.HeaderText = "Телефон";
            this.colClientPhone.MinimumWidth = 6;
            this.colClientPhone.Name = "colClientPhone";
            this.colClientPhone.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // exportPDFToolStripMenuItem
            // 
            this.exportPDFToolStripMenuItem.Name = "exportPDFToolStripMenuItem";
            this.exportPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportPDFToolStripMenuItem.Text = "Экспорт в PDF";
            this.exportPDFToolStripMenuItem.Click += new System.EventHandler(this.exportPDFToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 820);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Такси ИС";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPrice)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelSearchClients.ResumeLayout(false);
            this.panelSearchClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlate;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientPhone;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label labelSearchCount;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxEditDriver;
        private System.Windows.Forms.TextBox textBoxEditDateTime;
        private System.Windows.Forms.TextBox textBoxEditDestination;
        private System.Windows.Forms.TextBox textBoxEditPickup;
        private System.Windows.Forms.NumericUpDown numericUpDownEditPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxAddDriver;
        private System.Windows.Forms.TextBox textBoxAddDateTime;
        private System.Windows.Forms.TextBox textBoxAddDestination;
        private System.Windows.Forms.TextBox textBoxAddPickup;
        private System.Windows.Forms.NumericUpDown numericUpDownAddPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelSearchClients;
        private System.Windows.Forms.Label labelSearchCountClients;
        private System.Windows.Forms.TextBox textBoxFilterClients;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxSearchClients;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxFilterClients;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exportPDFToolStripMenuItem;
    }
}

