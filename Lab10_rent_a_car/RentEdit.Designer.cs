namespace Lab10_rent_a_car
{
    partial class RentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.objectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressesBox = new System.Windows.Forms.ComboBox();
            this.addServicesListBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clientFIO = new System.Windows.Forms.ComboBox();
            this.docB = new System.Windows.Forms.RadioButton();
            this.moneyB = new System.Windows.Forms.RadioButton();
            this.productB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.secondAddressBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.objectMeasureLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timePicker2 = new System.Windows.Forms.DateTimePicker();
            this.hoursBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.minutesBox = new System.Windows.Forms.NumericUpDown();
            this.todayButton = new System.Windows.Forms.Button();
            this.inStockBox = new System.Windows.Forms.TextBox();
            this.labelInStock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.measureBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ФИО:";
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(101, 178);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(203, 20);
            this.depositBox.TabIndex = 49;
            this.depositBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Объект:";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(68, 100);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(137, 20);
            this.priceBox.TabIndex = 48;
            this.priceBox.TextChanged += new System.EventHandler(this.Calculator);
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricesBox_KeyPress);
            this.priceBox.Leave += new System.EventHandler(this.BoundPrice);
            // 
            // objectBox
            // 
            this.objectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectBox.Location = new System.Drawing.Point(103, 58);
            this.objectBox.Name = "objectBox";
            this.objectBox.Size = new System.Drawing.Size(201, 21);
            this.objectBox.TabIndex = 34;
            this.objectBox.SelectedIndexChanged += new System.EventHandler(this.CarPic);
            this.objectBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Цена:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(380, 379);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(68, 18);
            this.cost.TabIndex = 46;
            this.cost.Text = "0 рублей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Тип залога:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Итого:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Адрес выдачи:";
            // 
            // addressesBox
            // 
            this.addressesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressesBox.FormattingEnabled = true;
            this.addressesBox.Location = new System.Drawing.Point(124, 220);
            this.addressesBox.Name = "addressesBox";
            this.addressesBox.Size = new System.Drawing.Size(180, 21);
            this.addressesBox.TabIndex = 40;
            this.addressesBox.SelectedIndexChanged += new System.EventHandler(this.addressesBox_SelectedIndexChanged);
            this.addressesBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // addServicesListBox
            // 
            this.addServicesListBox.CheckOnClick = true;
            this.addServicesListBox.FormattingEnabled = true;
            this.addServicesListBox.Location = new System.Drawing.Point(644, 18);
            this.addServicesListBox.Name = "addServicesListBox";
            this.addServicesListBox.Size = new System.Drawing.Size(236, 184);
            this.addServicesListBox.TabIndex = 41;
            this.addServicesListBox.SelectedIndexChanged += new System.EventHandler(this.Calculator);
            this.addServicesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(29, 379);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(275, 23);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // clientFIO
            // 
            this.clientFIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientFIO.Location = new System.Drawing.Point(72, 18);
            this.clientFIO.Name = "clientFIO";
            this.clientFIO.Size = new System.Drawing.Size(232, 21);
            this.clientFIO.TabIndex = 34;
            this.clientFIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // docB
            // 
            this.docB.AutoSize = true;
            this.docB.Location = new System.Drawing.Point(99, 142);
            this.docB.Name = "docB";
            this.docB.Size = new System.Drawing.Size(76, 17);
            this.docB.TabIndex = 51;
            this.docB.TabStop = true;
            this.docB.Text = "Документ";
            this.docB.UseVisualStyleBackColor = true;
            this.docB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // moneyB
            // 
            this.moneyB.AutoSize = true;
            this.moneyB.Location = new System.Drawing.Point(181, 142);
            this.moneyB.Name = "moneyB";
            this.moneyB.Size = new System.Drawing.Size(63, 17);
            this.moneyB.TabIndex = 51;
            this.moneyB.TabStop = true;
            this.moneyB.Text = "Деньги";
            this.moneyB.UseVisualStyleBackColor = true;
            this.moneyB.CheckedChanged += new System.EventHandler(this.moneyB_CheckedChanged);
            this.moneyB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // productB
            // 
            this.productB.AutoSize = true;
            this.productB.Location = new System.Drawing.Point(250, 142);
            this.productB.Name = "productB";
            this.productB.Size = new System.Drawing.Size(56, 17);
            this.productB.TabIndex = 51;
            this.productB.TabStop = true;
            this.productB.Text = "Товар";
            this.productB.UseVisualStyleBackColor = true;
            this.productB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Залог:";
            // 
            // secondAddressBox
            // 
            this.secondAddressBox.Location = new System.Drawing.Point(123, 260);
            this.secondAddressBox.Name = "secondAddressBox";
            this.secondAddressBox.Size = new System.Drawing.Size(181, 20);
            this.secondAddressBox.TabIndex = 91;
            this.secondAddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Срок аренды:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Дата возврата:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Статус:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Дата начала аренды:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Адрес возврата:";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Активная",
            "Забронирована",
            "Завершена",
            "Отменена"});
            this.statusBox.Location = new System.Drawing.Point(120, 298);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(184, 21);
            this.statusBox.TabIndex = 40;
            this.statusBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // datePicker1
            // 
            this.datePicker1.Location = new System.Drawing.Point(455, 217);
            this.datePicker1.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(173, 20);
            this.datePicker1.TabIndex = 93;
            this.datePicker1.Value = new System.DateTime(2020, 5, 8, 18, 57, 34, 0);
            this.datePicker1.ValueChanged += new System.EventHandler(this.datePicker1_ValueChanged);
            this.datePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // datePicker2
            // 
            this.datePicker2.Enabled = false;
            this.datePicker2.Location = new System.Drawing.Point(455, 257);
            this.datePicker2.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePicker2.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(173, 20);
            this.datePicker2.TabIndex = 93;
            this.datePicker2.Value = new System.DateTime(2020, 5, 8, 18, 57, 34, 0);
            this.datePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // numericUpDown
            // 
            this.numericUpDown.DecimalPlaces = 1;
            this.numericUpDown.Location = new System.Drawing.Point(107, 339);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown.TabIndex = 94;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.numericUpDown.VisibleChanged += new System.EventHandler(this.numericUpDown_VisibleChanged);
            this.numericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(644, 239);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(236, 155);
            this.descriptionBox.TabIndex = 96;
            this.descriptionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Описание:";
            // 
            // objectMeasureLabel
            // 
            this.objectMeasureLabel.AutoSize = true;
            this.objectMeasureLabel.Location = new System.Drawing.Point(211, 103);
            this.objectMeasureLabel.Name = "objectMeasureLabel";
            this.objectMeasureLabel.Size = new System.Drawing.Size(40, 13);
            this.objectMeasureLabel.TabIndex = 35;
            this.objectMeasureLabel.Text = "в день";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Время возврата:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Время начала аренды:";
            // 
            // timePicker2
            // 
            this.timePicker2.Enabled = false;
            this.timePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker2.Location = new System.Drawing.Point(455, 339);
            this.timePicker2.Name = "timePicker2";
            this.timePicker2.Size = new System.Drawing.Size(173, 20);
            this.timePicker2.TabIndex = 101;
            this.timePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(462, 299);
            this.hoursBox.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(36, 20);
            this.hoursBox.TabIndex = 94;
            this.hoursBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursBox.ValueChanged += new System.EventHandler(this.hoursBox_ValueChanged);
            this.hoursBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = ":";
            // 
            // minutesBox
            // 
            this.minutesBox.Location = new System.Drawing.Point(520, 299);
            this.minutesBox.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(36, 20);
            this.minutesBox.TabIndex = 94;
            this.minutesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minutesBox.ValueChanged += new System.EventHandler(this.minutesBox_ValueChanged);
            this.minutesBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // todayButton
            // 
            this.todayButton.Location = new System.Drawing.Point(562, 290);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(66, 43);
            this.todayButton.TabIndex = 103;
            this.todayButton.Text = "Текущая дата";
            this.todayButton.UseVisualStyleBackColor = true;
            this.todayButton.Visible = false;
            this.todayButton.Click += new System.EventHandler(this.todayButton_Click);
            this.todayButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // inStockBox
            // 
            this.inStockBox.Location = new System.Drawing.Point(214, 80);
            this.inStockBox.Name = "inStockBox";
            this.inStockBox.ReadOnly = true;
            this.inStockBox.Size = new System.Drawing.Size(26, 20);
            this.inStockBox.TabIndex = 104;
            this.inStockBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            // 
            // labelInStock
            // 
            this.labelInStock.AutoSize = true;
            this.labelInStock.Location = new System.Drawing.Point(110, 82);
            this.labelInStock.Name = "labelInStock";
            this.labelInStock.Size = new System.Drawing.Size(98, 13);
            this.labelInStock.TabIndex = 35;
            this.labelInStock.Text = "Кол-во на складе:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab10_rent_a_car.Properties.Resources.defaultImage;
            this.pictureBox1.Location = new System.Drawing.Point(337, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(192, 338);
            this.measureBox.Name = "measureBox";
            this.measureBox.ReadOnly = true;
            this.measureBox.Size = new System.Drawing.Size(112, 20);
            this.measureBox.TabIndex = 105;
            this.measureBox.TextChanged += new System.EventHandler(this.measureBox_SelectedIndexChanged);
            // 
            // RentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(910, 413);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.inStockBox);
            this.Controls.Add(this.todayButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timePicker2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.datePicker2);
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.secondAddressBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.productB);
            this.Controls.Add(this.moneyB);
            this.Controls.Add(this.docB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.clientFIO);
            this.Controls.Add(this.objectBox);
            this.Controls.Add(this.objectMeasureLabel);
            this.Controls.Add(this.labelInStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.addressesBox);
            this.Controls.Add(this.addServicesListBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentEdit_FormClosed);
            this.Load += new System.EventHandler(this.RentEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox objectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addressesBox;
        private System.Windows.Forms.CheckedListBox addServicesListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox clientFIO;
        private System.Windows.Forms.RadioButton docB;
        private System.Windows.Forms.RadioButton moneyB;
        private System.Windows.Forms.RadioButton productB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secondAddressBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label objectMeasureLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker timePicker2;
        private System.Windows.Forms.NumericUpDown hoursBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown minutesBox;
        private System.Windows.Forms.Button todayButton;
        private System.Windows.Forms.TextBox inStockBox;
        private System.Windows.Forms.Label labelInStock;
        private System.Windows.Forms.TextBox measureBox;
    }
}