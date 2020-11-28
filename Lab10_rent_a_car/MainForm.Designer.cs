namespace Lab10_rent_a_car
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsMenuBox = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressesMenuBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesMenuBox = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsPage = new System.Windows.Forms.TabPage();
            this.nextClientButton = new System.Windows.Forms.Button();
            this.prevClientButton = new System.Windows.Forms.Button();
            this.clientsPagesBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newClient = new System.Windows.Forms.Button();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentsPage = new System.Windows.Forms.TabPage();
            this.nextRentButton = new System.Windows.Forms.Button();
            this.prevRentButton = new System.Windows.Forms.Button();
            this.rentStatusBox = new System.Windows.Forms.ComboBox();
            this.rentsPagesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.newRent = new System.Windows.Forms.Button();
            this.RentsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.saveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrongDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.notSavedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.notFilledStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.changedDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rentsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsFIOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.ClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.RentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentsGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(186, 103);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(0, 13);
            this.numLabel.TabIndex = 21;
            this.numLabel.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_save_3325027;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_cog_226584;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarsMenuBox,
            this.AddressesMenuBox,
            this.ServicesMenuBox,
            this.пользователиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_menu_alt_134216;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // CarsMenuBox
            // 
            this.CarsMenuBox.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_package_3325012;
            this.CarsMenuBox.Name = "CarsMenuBox";
            this.CarsMenuBox.Size = new System.Drawing.Size(210, 22);
            this.CarsMenuBox.Text = "Объекты аренды";
            this.CarsMenuBox.Click += new System.EventHandler(this.CarsMenuBox_Click);
            // 
            // AddressesMenuBox
            // 
            this.AddressesMenuBox.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_Location_4200779;
            this.AddressesMenuBox.Name = "AddressesMenuBox";
            this.AddressesMenuBox.Size = new System.Drawing.Size(210, 22);
            this.AddressesMenuBox.Text = "Пункты выдачи";
            this.AddressesMenuBox.Click += new System.EventHandler(this.AddressesMenuBox_Click);
            // 
            // ServicesMenuBox
            // 
            this.ServicesMenuBox.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_book_open_3325068;
            this.ServicesMenuBox.Name = "ServicesMenuBox";
            this.ServicesMenuBox.Size = new System.Drawing.Size(210, 22);
            this.ServicesMenuBox.Text = "Дополнительные услуги";
            this.ServicesMenuBox.Click += new System.EventHandler(this.ServicesMenuBox_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_users_3325168;
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // ClientsPage
            // 
            this.ClientsPage.Controls.Add(this.nextClientButton);
            this.ClientsPage.Controls.Add(this.prevClientButton);
            this.ClientsPage.Controls.Add(this.clientsPagesBox);
            this.ClientsPage.Controls.Add(this.label2);
            this.ClientsPage.Controls.Add(this.newClient);
            this.ClientsPage.Controls.Add(this.ClientsGrid);
            this.ClientsPage.Location = new System.Drawing.Point(4, 22);
            this.ClientsPage.Name = "ClientsPage";
            this.ClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsPage.Size = new System.Drawing.Size(1024, 373);
            this.ClientsPage.TabIndex = 1;
            this.ClientsPage.Text = "Клиенты";
            this.ClientsPage.UseVisualStyleBackColor = true;
            // 
            // nextClientButton
            // 
            this.nextClientButton.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_chevron_right_3325082;
            this.nextClientButton.Location = new System.Drawing.Point(524, 322);
            this.nextClientButton.Name = "nextClientButton";
            this.nextClientButton.Size = new System.Drawing.Size(100, 37);
            this.nextClientButton.TabIndex = 45;
            this.nextClientButton.UseVisualStyleBackColor = true;
            this.nextClientButton.Click += new System.EventHandler(this.nextClientButton_Click);
            // 
            // prevClientButton
            // 
            this.prevClientButton.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_chevron_left_3325081;
            this.prevClientButton.Location = new System.Drawing.Point(387, 322);
            this.prevClientButton.Name = "prevClientButton";
            this.prevClientButton.Size = new System.Drawing.Size(110, 37);
            this.prevClientButton.TabIndex = 46;
            this.prevClientButton.UseVisualStyleBackColor = true;
            this.prevClientButton.Click += new System.EventHandler(this.prevClientButton_Click);
            // 
            // clientsPagesBox
            // 
            this.clientsPagesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsPagesBox.FormattingEnabled = true;
            this.clientsPagesBox.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.clientsPagesBox.Location = new System.Drawing.Point(947, 329);
            this.clientsPagesBox.Name = "clientsPagesBox";
            this.clientsPagesBox.Size = new System.Drawing.Size(69, 21);
            this.clientsPagesBox.TabIndex = 44;
            this.clientsPagesBox.SelectedIndexChanged += new System.EventHandler(this.clientsPageBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Просмотр по";
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(8, 329);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(127, 23);
            this.newClient.TabIndex = 1;
            this.newClient.Text = "Добавить клиента";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToAddRows = false;
            this.ClientsGrid.AllowUserToDeleteRows = false;
            this.ClientsGrid.AllowUserToResizeColumns = false;
            this.ClientsGrid.AllowUserToResizeRows = false;
            this.ClientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.CarModel,
            this.Price,
            this.ClientAddress,
            this.Period});
            this.ClientsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ClientsGrid.Location = new System.Drawing.Point(3, 3);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientsGrid.Size = new System.Drawing.Size(1018, 309);
            this.ClientsGrid.TabIndex = 0;
            this.ClientsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsGrid_CellMouseDoubleClick);
            // 
            // FIO
            // 
            this.FIO.FillWeight = 112.6904F;
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // CarModel
            // 
            this.CarModel.FillWeight = 112.6904F;
            this.CarModel.HeaderText = "Паспорт";
            this.CarModel.Name = "CarModel";
            // 
            // Price
            // 
            this.Price.FillWeight = 112.6904F;
            this.Price.HeaderText = "Номер водительского удостоверения";
            this.Price.Name = "Price";
            // 
            // ClientAddress
            // 
            this.ClientAddress.FillWeight = 112.6904F;
            this.ClientAddress.HeaderText = "Категории прав";
            this.ClientAddress.Name = "ClientAddress";
            // 
            // Period
            // 
            this.Period.FillWeight = 112.6904F;
            this.Period.HeaderText = "Адрес клиента";
            this.Period.Name = "Period";
            // 
            // RentsPage
            // 
            this.RentsPage.Controls.Add(this.nextRentButton);
            this.RentsPage.Controls.Add(this.prevRentButton);
            this.RentsPage.Controls.Add(this.rentStatusBox);
            this.RentsPage.Controls.Add(this.rentsPagesBox);
            this.RentsPage.Controls.Add(this.label3);
            this.RentsPage.Controls.Add(this.label1);
            this.RentsPage.Controls.Add(this.settingsButton);
            this.RentsPage.Controls.Add(this.newRent);
            this.RentsPage.Controls.Add(this.RentsGrid);
            this.RentsPage.Location = new System.Drawing.Point(4, 22);
            this.RentsPage.Name = "RentsPage";
            this.RentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.RentsPage.Size = new System.Drawing.Size(1024, 373);
            this.RentsPage.TabIndex = 0;
            this.RentsPage.Text = "Аренды";
            this.RentsPage.UseVisualStyleBackColor = true;
            // 
            // nextRentButton
            // 
            this.nextRentButton.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_chevron_right_3325082;
            this.nextRentButton.Location = new System.Drawing.Point(524, 324);
            this.nextRentButton.Name = "nextRentButton";
            this.nextRentButton.Size = new System.Drawing.Size(100, 37);
            this.nextRentButton.TabIndex = 42;
            this.nextRentButton.UseVisualStyleBackColor = true;
            this.nextRentButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevRentButton
            // 
            this.prevRentButton.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_chevron_left_3325081;
            this.prevRentButton.Location = new System.Drawing.Point(387, 324);
            this.prevRentButton.Name = "prevRentButton";
            this.prevRentButton.Size = new System.Drawing.Size(110, 37);
            this.prevRentButton.TabIndex = 42;
            this.prevRentButton.UseVisualStyleBackColor = true;
            this.prevRentButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // rentStatusBox
            // 
            this.rentStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentStatusBox.FormattingEnabled = true;
            this.rentStatusBox.Items.AddRange(new object[] {
            "Все",
            "Активные",
            "Забронированные",
            "Завершенные",
            "Отмененные"});
            this.rentStatusBox.Location = new System.Drawing.Point(915, 318);
            this.rentStatusBox.Name = "rentStatusBox";
            this.rentStatusBox.Size = new System.Drawing.Size(101, 21);
            this.rentStatusBox.TabIndex = 41;
            this.rentStatusBox.SelectedIndexChanged += new System.EventHandler(this.rentStatusBox_SelectedIndexChanged);
            // 
            // rentsPagesBox
            // 
            this.rentsPagesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentsPagesBox.FormattingEnabled = true;
            this.rentsPagesBox.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.rentsPagesBox.Location = new System.Drawing.Point(947, 345);
            this.rentsPagesBox.Name = "rentsPagesBox";
            this.rentsPagesBox.Size = new System.Drawing.Size(69, 21);
            this.rentsPagesBox.TabIndex = 41;
            this.rentsPagesBox.SelectedIndexChanged += new System.EventHandler(this.pagesBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Просмотр по";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(304, 415);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(267, 23);
            this.settingsButton.TabIndex = 28;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // newRent
            // 
            this.newRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newRent.Location = new System.Drawing.Point(6, 330);
            this.newRent.Name = "newRent";
            this.newRent.Size = new System.Drawing.Size(133, 23);
            this.newRent.TabIndex = 32;
            this.newRent.Text = "Добавить аренду";
            this.newRent.UseVisualStyleBackColor = true;
            this.newRent.Click += new System.EventHandler(this.newRent_Click);
            // 
            // RentsGrid
            // 
            this.RentsGrid.AllowUserToAddRows = false;
            this.RentsGrid.AllowUserToDeleteRows = false;
            this.RentsGrid.AllowUserToResizeColumns = false;
            this.RentsGrid.AllowUserToResizeRows = false;
            this.RentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RentsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.RentsGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.RentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentsID,
            this.clientsFIOs,
            this.carsColumn,
            this.priceColumn,
            this.Column1,
            this.periodColumn,
            this.addressColumn,
            this.depositColumn});
            this.RentsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RentsGrid.Location = new System.Drawing.Point(3, 3);
            this.RentsGrid.MultiSelect = false;
            this.RentsGrid.Name = "RentsGrid";
            this.RentsGrid.ReadOnly = true;
            this.RentsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RentsGrid.Size = new System.Drawing.Size(1018, 309);
            this.RentsGrid.TabIndex = 29;
            this.RentsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentsGrid_CellMouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RentsPage);
            this.tabControl1.Controls.Add(this.ClientsPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 399);
            this.tabControl1.TabIndex = 29;
            // 
            // saveTimer
            // 
            this.saveTimer.Enabled = true;
            this.saveTimer.Interval = 180000;
            this.saveTimer.Tick += new System.EventHandler(this.saveTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Rent a car";
            this.notifyIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.settingsItem,
            this.aboutItem,
            this.exitItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(187, 92);
            this.contextMenu.Text = "Rent A Car";
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(186, 22);
            this.saveItem.Text = "Сохранить";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // settingsItem
            // 
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(186, 22);
            this.settingsItem.Text = "Настройки";
            this.settingsItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(186, 22);
            this.aboutItem.Text = "О программе";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(186, 22);
            this.exitItem.Text = "Закрыть программу";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStatus,
            this.wrongDataStatus,
            this.notSavedStatus,
            this.notFilledStatus,
            this.changedDataStatus,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1032, 22);
            this.statusStrip.TabIndex = 31;
            // 
            // saveStatus
            // 
            this.saveStatus.Name = "saveStatus";
            this.saveStatus.Size = new System.Drawing.Size(120, 17);
            this.saveStatus.Text = "Успешно сохранено";
            this.saveStatus.Visible = false;
            // 
            // wrongDataStatus
            // 
            this.wrongDataStatus.Name = "wrongDataStatus";
            this.wrongDataStatus.Size = new System.Drawing.Size(155, 17);
            this.wrongDataStatus.Text = "Введены неверные данные";
            this.wrongDataStatus.Visible = false;
            // 
            // notSavedStatus
            // 
            this.notSavedStatus.Name = "notSavedStatus";
            this.notSavedStatus.Size = new System.Drawing.Size(164, 17);
            this.notSavedStatus.Text = "Есть несохраненные данные";
            this.notSavedStatus.Visible = false;
            // 
            // notFilledStatus
            // 
            this.notFilledStatus.Name = "notFilledStatus";
            this.notFilledStatus.Size = new System.Drawing.Size(144, 17);
            this.notFilledStatus.Text = "Заполненны не все поля";
            this.notFilledStatus.Visible = false;
            // 
            // changedDataStatus
            // 
            this.changedDataStatus.Name = "changedDataStatus";
            this.changedDataStatus.Size = new System.Drawing.Size(162, 17);
            this.changedDataStatus.Text = "Данные успешно изменены";
            this.changedDataStatus.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // rentsID
            // 
            this.rentsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentsID.FillWeight = 61.8976F;
            this.rentsID.HeaderText = "Номер аренды";
            this.rentsID.Name = "rentsID";
            this.rentsID.ReadOnly = true;
            // 
            // clientsFIOs
            // 
            this.clientsFIOs.FillWeight = 136.3221F;
            this.clientsFIOs.HeaderText = "ФИО";
            this.clientsFIOs.Name = "clientsFIOs";
            this.clientsFIOs.ReadOnly = true;
            this.clientsFIOs.Width = 59;
            // 
            // carsColumn
            // 
            this.carsColumn.FillWeight = 136.3221F;
            this.carsColumn.HeaderText = "Объект";
            this.carsColumn.Name = "carsColumn";
            this.carsColumn.ReadOnly = true;
            this.carsColumn.Width = 70;
            // 
            // priceColumn
            // 
            this.priceColumn.FillWeight = 70.76933F;
            this.priceColumn.HeaderText = "Дата начала аренды";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата завершения аренды";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // periodColumn
            // 
            this.periodColumn.FillWeight = 57.07007F;
            this.periodColumn.HeaderText = "Срок аренды";
            this.periodColumn.Name = "periodColumn";
            this.periodColumn.ReadOnly = true;
            this.periodColumn.Width = 90;
            // 
            // addressColumn
            // 
            this.addressColumn.FillWeight = 136.3221F;
            this.addressColumn.HeaderText = "Пункт выдачи";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 94;
            // 
            // depositColumn
            // 
            this.depositColumn.FillWeight = 64.97462F;
            this.depositColumn.HeaderText = "Статус";
            this.depositColumn.Name = "depositColumn";
            this.depositColumn.ReadOnly = true;
            this.depositColumn.Width = 66;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 451);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ClientsPage.ResumeLayout(false);
            this.ClientsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.RentsPage.ResumeLayout(false);
            this.RentsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentsGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.TabPage ClientsPage;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.TabPage RentsPage;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.ToolStripMenuItem CarsMenuBox;
        private System.Windows.Forms.ToolStripMenuItem AddressesMenuBox;
        private System.Windows.Forms.ToolStripMenuItem ServicesMenuBox;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem settingsItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripStatusLabel saveStatus;
        private System.Windows.Forms.ToolStripStatusLabel wrongDataStatus;
        private System.Windows.Forms.ToolStripStatusLabel notSavedStatus;
        private System.Windows.Forms.ToolStripStatusLabel notFilledStatus;
        private System.Windows.Forms.ToolStripStatusLabel changedDataStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        internal System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button newRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RentsGrid;
        private System.Windows.Forms.Button nextRentButton;
        private System.Windows.Forms.Button prevRentButton;
        private System.Windows.Forms.ComboBox rentsPagesBox;
        private System.Windows.Forms.Button nextClientButton;
        private System.Windows.Forms.Button prevClientButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox clientsPagesBox;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ComboBox rentStatusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsFIOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositColumn;
    }
}