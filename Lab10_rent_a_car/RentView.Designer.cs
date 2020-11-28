namespace Lab10_rent_a_car
{
    partial class RentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentView));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addServicesListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.carBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secondAddressBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fdateBox = new System.Windows.Forms.TextBox();
            this.ftimeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sdateBox = new System.Windows.Forms.TextBox();
            this.stimeBox = new System.Windows.Forms.TextBox();
            this.measureLabel = new System.Windows.Forms.Label();
            this.objectMeasureLabel = new System.Windows.Forms.Label();
            this.endRentButton = new System.Windows.Forms.Button();
            this.carPic = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Залог:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Итого:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Срок аренды:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Адрес выдачи:";
            // 
            // addServicesListBox
            // 
            this.addServicesListBox.Enabled = false;
            this.addServicesListBox.FormattingEnabled = true;
            this.addServicesListBox.Location = new System.Drawing.Point(563, 19);
            this.addServicesListBox.Name = "addServicesListBox";
            this.addServicesListBox.Size = new System.Drawing.Size(207, 169);
            this.addServicesListBox.TabIndex = 62;
            this.addServicesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Объект:";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 364);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(235, 23);
            this.editButton.TabIndex = 64;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(65, 19);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.ReadOnly = true;
            this.FIOBox.Size = new System.Drawing.Size(195, 20);
            this.FIOBox.TabIndex = 72;
            this.FIOBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // carBox
            // 
            this.carBox.Location = new System.Drawing.Point(100, 55);
            this.carBox.Name = "carBox";
            this.carBox.ReadOnly = true;
            this.carBox.Size = new System.Drawing.Size(160, 20);
            this.carBox.TabIndex = 72;
            this.carBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(64, 91);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(137, 20);
            this.priceBox.TabIndex = 72;
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(68, 127);
            this.depositBox.Name = "depositBox";
            this.depositBox.ReadOnly = true;
            this.depositBox.Size = new System.Drawing.Size(192, 20);
            this.depositBox.TabIndex = 72;
            this.depositBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(373, 239);
            this.periodBox.Name = "periodBox";
            this.periodBox.ReadOnly = true;
            this.periodBox.Size = new System.Drawing.Size(92, 20);
            this.periodBox.TabIndex = 72;
            this.periodBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(106, 163);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(154, 20);
            this.addressBox.TabIndex = 72;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(335, 201);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(211, 20);
            this.totalBox.TabIndex = 72;
            this.totalBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Адрес возврата:";
            // 
            // secondAddressBox
            // 
            this.secondAddressBox.Location = new System.Drawing.Point(119, 201);
            this.secondAddressBox.Name = "secondAddressBox";
            this.secondAddressBox.ReadOnly = true;
            this.secondAddressBox.Size = new System.Drawing.Size(141, 20);
            this.secondAddressBox.TabIndex = 72;
            this.secondAddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(563, 220);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(207, 167);
            this.descriptionBox.TabIndex = 73;
            this.descriptionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Описание:";
            // 
            // fdateBox
            // 
            this.fdateBox.Location = new System.Drawing.Point(143, 276);
            this.fdateBox.Name = "fdateBox";
            this.fdateBox.ReadOnly = true;
            this.fdateBox.Size = new System.Drawing.Size(117, 20);
            this.fdateBox.TabIndex = 72;
            this.fdateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // ftimeBox
            // 
            this.ftimeBox.Location = new System.Drawing.Point(150, 313);
            this.ftimeBox.Name = "ftimeBox";
            this.ftimeBox.ReadOnly = true;
            this.ftimeBox.Size = new System.Drawing.Size(110, 20);
            this.ftimeBox.TabIndex = 72;
            this.ftimeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Дата начала аренды:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Время начала аренды:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Дата возврата:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Время возврата:";
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(72, 239);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(188, 20);
            this.statusBox.TabIndex = 72;
            this.statusBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Статус:";
            // 
            // sdateBox
            // 
            this.sdateBox.Location = new System.Drawing.Point(381, 276);
            this.sdateBox.Name = "sdateBox";
            this.sdateBox.ReadOnly = true;
            this.sdateBox.Size = new System.Drawing.Size(165, 20);
            this.sdateBox.TabIndex = 72;
            this.sdateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // stimeBox
            // 
            this.stimeBox.Location = new System.Drawing.Point(388, 316);
            this.stimeBox.Name = "stimeBox";
            this.stimeBox.ReadOnly = true;
            this.stimeBox.Size = new System.Drawing.Size(158, 20);
            this.stimeBox.TabIndex = 72;
            this.stimeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // measureLabel
            // 
            this.measureLabel.AutoSize = true;
            this.measureLabel.Location = new System.Drawing.Point(471, 242);
            this.measureLabel.Name = "measureLabel";
            this.measureLabel.Size = new System.Drawing.Size(31, 13);
            this.measureLabel.TabIndex = 75;
            this.measureLabel.Text = "дней";
            // 
            // objectMeasureLabel
            // 
            this.objectMeasureLabel.AutoSize = true;
            this.objectMeasureLabel.Location = new System.Drawing.Point(207, 94);
            this.objectMeasureLabel.Name = "objectMeasureLabel";
            this.objectMeasureLabel.Size = new System.Drawing.Size(40, 13);
            this.objectMeasureLabel.TabIndex = 56;
            this.objectMeasureLabel.Text = "в день";
            // 
            // endRentButton
            // 
            this.endRentButton.Location = new System.Drawing.Point(290, 364);
            this.endRentButton.Name = "endRentButton";
            this.endRentButton.Size = new System.Drawing.Size(175, 23);
            this.endRentButton.TabIndex = 64;
            this.endRentButton.Text = "Завершить";
            this.endRentButton.UseVisualStyleBackColor = true;
            this.endRentButton.Click += new System.EventHandler(this.endRentButton_Click);
            this.endRentButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // carPic
            // 
            this.carPic.Image = global::Lab10_rent_a_car.Properties.Resources.defaultImage;
            this.carPic.Location = new System.Drawing.Point(290, 19);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(256, 169);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPic.TabIndex = 71;
            this.carPic.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(488, 364);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(58, 23);
            this.deleteButton.TabIndex = 65;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            // 
            // RentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.measureLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.stimeBox);
            this.Controls.Add(this.sdateBox);
            this.Controls.Add(this.ftimeBox);
            this.Controls.Add(this.fdateBox);
            this.Controls.Add(this.secondAddressBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.carPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objectMeasureLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addServicesListBox);
            this.Controls.Add(this.endRentButton);
            this.Controls.Add(this.editButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аренда";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentView_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox addServicesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox carBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secondAddressBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fdateBox;
        private System.Windows.Forms.TextBox ftimeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sdateBox;
        private System.Windows.Forms.TextBox stimeBox;
        private System.Windows.Forms.Label measureLabel;
        private System.Windows.Forms.Label objectMeasureLabel;
        public System.Windows.Forms.TextBox statusBox;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button editButton;
        public System.Windows.Forms.Button endRentButton;
    }
}