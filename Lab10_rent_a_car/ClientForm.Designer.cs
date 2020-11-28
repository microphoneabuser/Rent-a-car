namespace Lab10_rent_a_car
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carsBox = new System.Windows.Forms.ComboBox();
            this.carPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pricesBox = new System.Windows.Forms.ComboBox();
            this.depositsBox = new System.Windows.Forms.ComboBox();
            this.periodsBox = new System.Windows.Forms.ComboBox();
            this.addressesBox = new System.Windows.Forms.ComboBox();
            this.addServicesListBox = new System.Windows.Forms.CheckedListBox();
            this.previous = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.backToListButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // clientFIO
            // 
            this.clientFIO.Location = new System.Drawing.Point(67, 21);
            this.clientFIO.Name = "clientFIO";
            this.clientFIO.Size = new System.Drawing.Size(238, 20);
            this.clientFIO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автомобиль:";
            // 
            // carsBox
            // 
            this.carsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsBox.Location = new System.Drawing.Point(102, 75);
            this.carsBox.Name = "carsBox";
            this.carsBox.Size = new System.Drawing.Size(203, 21);
            this.carsBox.TabIndex = 3;
            // 
            // carPic
            // 
            this.carPic.Location = new System.Drawing.Point(342, 53);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(236, 150);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPic.TabIndex = 4;
            this.carPic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Залог:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Срок аренды:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Адрес:";
            // 
            // pricesBox
            // 
            this.pricesBox.FormattingEnabled = true;
            this.pricesBox.Location = new System.Drawing.Point(67, 125);
            this.pricesBox.Name = "pricesBox";
            this.pricesBox.Size = new System.Drawing.Size(95, 21);
            this.pricesBox.TabIndex = 9;
            this.pricesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricesBox_KeyPress);
            // 
            // depositsBox
            // 
            this.depositsBox.FormattingEnabled = true;
            this.depositsBox.Location = new System.Drawing.Point(217, 125);
            this.depositsBox.Name = "depositsBox";
            this.depositsBox.Size = new System.Drawing.Size(88, 21);
            this.depositsBox.TabIndex = 10;
            this.depositsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositsBox_KeyPress);
            // 
            // periodsBox
            // 
            this.periodsBox.FormattingEnabled = true;
            this.periodsBox.Location = new System.Drawing.Point(149, 182);
            this.periodsBox.Name = "periodsBox";
            this.periodsBox.Size = new System.Drawing.Size(156, 21);
            this.periodsBox.TabIndex = 11;
            this.periodsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodsBox_KeyPress);
            // 
            // addressesBox
            // 
            this.addressesBox.FormattingEnabled = true;
            this.addressesBox.Location = new System.Drawing.Point(72, 290);
            this.addressesBox.Name = "addressesBox";
            this.addressesBox.Size = new System.Drawing.Size(233, 21);
            this.addressesBox.TabIndex = 12;
            // 
            // addServicesListBox
            // 
            this.addServicesListBox.FormattingEnabled = true;
            this.addServicesListBox.Location = new System.Drawing.Point(342, 212);
            this.addServicesListBox.Name = "addServicesListBox";
            this.addServicesListBox.Size = new System.Drawing.Size(236, 109);
            this.addServicesListBox.TabIndex = 13;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(28, 340);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 14;
            this.previous.Text = "<<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(123, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(364, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(342, 19);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(145, 23);
            this.newClient.TabIndex = 17;
            this.newClient.Text = "Создать нового клиента";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(503, 19);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(75, 23);
            this.deleteClient.TabIndex = 18;
            this.deleteClient.Text = "Удалить";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(503, 340);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 19;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // backToListButton
            // 
            this.backToListButton.Location = new System.Drawing.Point(28, 388);
            this.backToListButton.Name = "backToListButton";
            this.backToListButton.Size = new System.Drawing.Size(550, 23);
            this.backToListButton.TabIndex = 20;
            this.backToListButton.Text = "Вернуться к списку клиентов";
            this.backToListButton.UseVisualStyleBackColor = true;
            this.backToListButton.Click += new System.EventHandler(this.backToListButton_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Итого:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(73, 238);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(68, 18);
            this.cost.TabIndex = 23;
            this.cost.Text = "0 рублей";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(230, 235);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 24;
            this.calcButton.Text = "Посчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 423);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.backToListButton);
            this.Controls.Add(this.next);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.addServicesListBox);
            this.Controls.Add(this.addressesBox);
            this.Controls.Add(this.periodsBox);
            this.Controls.Add(this.depositsBox);
            this.Controls.Add(this.pricesBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carPic);
            this.Controls.Add(this.carsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientFIO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox carPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pricesBox;
        private System.Windows.Forms.ComboBox depositsBox;
        private System.Windows.Forms.ComboBox periodsBox;
        private System.Windows.Forms.ComboBox addressesBox;
        private System.Windows.Forms.CheckedListBox addServicesListBox;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button backToListButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.ComboBox carsBox;
    }
}