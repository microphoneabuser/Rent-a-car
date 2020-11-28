namespace Lab10_rent_a_car
{
    partial class ObjectEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectEdit));
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadPicButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.damageBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.inStockBox = new System.Windows.Forms.NumericUpDown();
            this.inRentBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.repairBox = new System.Windows.Forms.NumericUpDown();
            this.measureBox = new System.Windows.Forms.ComboBox();
            this.minTBox = new System.Windows.Forms.NumericUpDown();
            this.maxTBox = new System.Windows.Forms.NumericUpDown();
            this.measureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inStockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(300, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(247, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // loadPicButton
            // 
            this.loadPicButton.Location = new System.Drawing.Point(47, 271);
            this.loadPicButton.Name = "loadPicButton";
            this.loadPicButton.Size = new System.Drawing.Size(247, 23);
            this.loadPicButton.TabIndex = 6;
            this.loadPicButton.Text = "Загрузить фото объекта";
            this.loadPicButton.UseVisualStyleBackColor = true;
            this.loadPicButton.Click += new System.EventHandler(this.loadPicButton_Click);
            this.loadPicButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(114, 102);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(96, 20);
            this.priceBox.TabIndex = 29;
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // damageBox
            // 
            this.damageBox.Location = new System.Drawing.Point(286, 188);
            this.damageBox.Multiline = true;
            this.damageBox.Name = "damageBox";
            this.damageBox.Size = new System.Drawing.Size(279, 62);
            this.damageBox.TabIndex = 37;
            this.damageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(286, 105);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(279, 60);
            this.descriptionBox.TabIndex = 33;
            this.descriptionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(114, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(136, 20);
            this.nameBox.TabIndex = 27;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(114, 61);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(136, 20);
            this.numBox.TabIndex = 28;
            this.numBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Повреждения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Максимальный срок аренды:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "В ремонте:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Описание:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "В аренде:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Минимальный срок аренды:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "На складе:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Цена:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Сер.номер:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Название:";
            // 
            // inStockBox
            // 
            this.inStockBox.Location = new System.Drawing.Point(114, 145);
            this.inStockBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inStockBox.Name = "inStockBox";
            this.inStockBox.Size = new System.Drawing.Size(136, 20);
            this.inStockBox.TabIndex = 38;
            this.inStockBox.ValueChanged += new System.EventHandler(this.inStockBox_ValueChanged);
            this.inStockBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // inRentBox
            // 
            this.inRentBox.Location = new System.Drawing.Point(210, 230);
            this.inRentBox.Name = "inRentBox";
            this.inRentBox.ReadOnly = true;
            this.inRentBox.Size = new System.Drawing.Size(38, 20);
            this.inRentBox.TabIndex = 35;
            this.inRentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(114, 230);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.Size = new System.Drawing.Size(34, 20);
            this.quantityBox.TabIndex = 35;
            this.quantityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // repairBox
            // 
            this.repairBox.Location = new System.Drawing.Point(114, 186);
            this.repairBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repairBox.Name = "repairBox";
            this.repairBox.Size = new System.Drawing.Size(136, 20);
            this.repairBox.TabIndex = 38;
            this.repairBox.ValueChanged += new System.EventHandler(this.repairBox_ValueChanged);
            this.repairBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // measureBox
            // 
            this.measureBox.FormattingEnabled = true;
            this.measureBox.Items.AddRange(new object[] {
            "часов",
            "дней",
            "месяцев"});
            this.measureBox.Location = new System.Drawing.Point(495, 39);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(70, 21);
            this.measureBox.TabIndex = 39;
            this.measureBox.SelectedIndexChanged += new System.EventHandler(this.measureBox_SelectedIndexChanged);
            this.measureBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // minTBox
            // 
            this.minTBox.Location = new System.Drawing.Point(440, 24);
            this.minTBox.Name = "minTBox";
            this.minTBox.Size = new System.Drawing.Size(49, 20);
            this.minTBox.TabIndex = 38;
            this.minTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // maxTBox
            // 
            this.maxTBox.Location = new System.Drawing.Point(440, 57);
            this.maxTBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxTBox.Name = "maxTBox";
            this.maxTBox.Size = new System.Drawing.Size(49, 20);
            this.maxTBox.TabIndex = 38;
            this.maxTBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            // 
            // measureLabel
            // 
            this.measureLabel.AutoSize = true;
            this.measureLabel.Location = new System.Drawing.Point(216, 105);
            this.measureLabel.Name = "measureLabel";
            this.measureLabel.Size = new System.Drawing.Size(0, 13);
            this.measureLabel.TabIndex = 26;
            // 
            // ObjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(615, 315);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.repairBox);
            this.Controls.Add(this.maxTBox);
            this.Controls.Add(this.minTBox);
            this.Controls.Add(this.inStockBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.damageBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.inRentBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.measureLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.loadPicButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объект аренды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarEdit_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.inStockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button loadPicButton;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox damageBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown inStockBox;
        private System.Windows.Forms.TextBox inRentBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.NumericUpDown repairBox;
        private System.Windows.Forms.ComboBox measureBox;
        private System.Windows.Forms.NumericUpDown minTBox;
        private System.Windows.Forms.NumericUpDown maxTBox;
        private System.Windows.Forms.Label measureLabel;
    }
}