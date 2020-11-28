namespace Lab10_rent_a_car
{
    partial class ObjectView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectView));
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rentsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inStockBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inRentBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.repairBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.minTBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.maxTBox = new System.Windows.Forms.TextBox();
            this.damageBox = new System.Windows.Forms.TextBox();
            this.measureLabel1 = new System.Windows.Forms.Label();
            this.measureLabel2 = new System.Windows.Forms.Label();
            this.rentGridButton = new System.Windows.Forms.Button();
            this.carPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            this.SuspendLayout();
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(84, 90);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(139, 20);
            this.priceBox.TabIndex = 12;
            this.priceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(107, 126);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.Size = new System.Drawing.Size(116, 20);
            this.quantityBox.TabIndex = 13;
            this.quantityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(98, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(125, 20);
            this.nameBox.TabIndex = 10;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(102, 56);
            this.numBox.Name = "numBox";
            this.numBox.ReadOnly = true;
            this.numBox.Size = new System.Drawing.Size(121, 20);
            this.numBox.TabIndex = 11;
            this.numBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сер.номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // rentsListBox
            // 
            this.rentsListBox.FormattingEnabled = true;
            this.rentsListBox.Location = new System.Drawing.Point(509, 195);
            this.rentsListBox.Name = "rentsListBox";
            this.rentsListBox.Size = new System.Drawing.Size(223, 56);
            this.rentsListBox.TabIndex = 15;
            this.rentsListBox.SelectedIndexChanged += new System.EventHandler(this.rentsListBox_SelectedIndexChanged);
            this.rentsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Список аренд:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(267, 270);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(188, 23);
            this.deleteButton.TabIndex = 71;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(35, 270);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(188, 23);
            this.editButton.TabIndex = 69;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "На складе:";
            // 
            // inStockBox
            // 
            this.inStockBox.Location = new System.Drawing.Point(107, 194);
            this.inStockBox.Name = "inStockBox";
            this.inStockBox.ReadOnly = true;
            this.inStockBox.Size = new System.Drawing.Size(116, 20);
            this.inStockBox.TabIndex = 13;
            this.inStockBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "В аренде:";
            // 
            // inRentBox
            // 
            this.inRentBox.Location = new System.Drawing.Point(107, 161);
            this.inRentBox.Name = "inRentBox";
            this.inRentBox.ReadOnly = true;
            this.inRentBox.Size = new System.Drawing.Size(116, 20);
            this.inRentBox.TabIndex = 13;
            this.inRentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "В ремонте:";
            // 
            // repairBox
            // 
            this.repairBox.Location = new System.Drawing.Point(107, 229);
            this.repairBox.Name = "repairBox";
            this.repairBox.ReadOnly = true;
            this.repairBox.Size = new System.Drawing.Size(116, 20);
            this.repairBox.TabIndex = 13;
            this.repairBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Минимальный срок аренды:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Описание:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Максимальный срок аренды:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Повреждения:";
            // 
            // minTBox
            // 
            this.minTBox.Location = new System.Drawing.Point(409, 23);
            this.minTBox.Name = "minTBox";
            this.minTBox.ReadOnly = true;
            this.minTBox.Size = new System.Drawing.Size(34, 20);
            this.minTBox.TabIndex = 13;
            this.minTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(255, 110);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(225, 55);
            this.descriptionBox.TabIndex = 13;
            this.descriptionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // maxTBox
            // 
            this.maxTBox.Location = new System.Drawing.Point(409, 56);
            this.maxTBox.Name = "maxTBox";
            this.maxTBox.ReadOnly = true;
            this.maxTBox.Size = new System.Drawing.Size(34, 20);
            this.maxTBox.TabIndex = 13;
            this.maxTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // damageBox
            // 
            this.damageBox.Location = new System.Drawing.Point(255, 199);
            this.damageBox.Multiline = true;
            this.damageBox.Name = "damageBox";
            this.damageBox.ReadOnly = true;
            this.damageBox.Size = new System.Drawing.Size(225, 50);
            this.damageBox.TabIndex = 13;
            this.damageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // measureLabel1
            // 
            this.measureLabel1.AutoSize = true;
            this.measureLabel1.Location = new System.Drawing.Point(449, 26);
            this.measureLabel1.Name = "measureLabel1";
            this.measureLabel1.Size = new System.Drawing.Size(31, 13);
            this.measureLabel1.TabIndex = 8;
            this.measureLabel1.Text = "дней";
            // 
            // measureLabel2
            // 
            this.measureLabel2.AutoSize = true;
            this.measureLabel2.Location = new System.Drawing.Point(449, 59);
            this.measureLabel2.Name = "measureLabel2";
            this.measureLabel2.Size = new System.Drawing.Size(31, 13);
            this.measureLabel2.TabIndex = 8;
            this.measureLabel2.Text = "дней";
            // 
            // rentGridButton
            // 
            this.rentGridButton.Location = new System.Drawing.Point(525, 270);
            this.rentGridButton.Name = "rentGridButton";
            this.rentGridButton.Size = new System.Drawing.Size(188, 23);
            this.rentGridButton.TabIndex = 71;
            this.rentGridButton.Text = "Просмотреть таблицу аренд";
            this.rentGridButton.UseVisualStyleBackColor = true;
            this.rentGridButton.Click += new System.EventHandler(this.rentGridButton_Click);
            this.rentGridButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            // 
            // carPic
            // 
            this.carPic.Image = global::Lab10_rent_a_car.Properties.Resources.defaultImage;
            this.carPic.Location = new System.Drawing.Point(509, 23);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(223, 142);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPic.TabIndex = 14;
            this.carPic.TabStop = false;
            // 
            // ObjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(771, 316);
            this.Controls.Add(this.rentGridButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.rentsListBox);
            this.Controls.Add(this.carPic);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.damageBox);
            this.Controls.Add(this.repairBox);
            this.Controls.Add(this.maxTBox);
            this.Controls.Add(this.inRentBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.inStockBox);
            this.Controls.Add(this.minTBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.measureLabel2);
            this.Controls.Add(this.measureLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ObjectView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объект аренды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarView_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox carPic;
        private System.Windows.Forms.ListBox rentsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inStockBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inRentBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox repairBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox minTBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox maxTBox;
        private System.Windows.Forms.TextBox damageBox;
        private System.Windows.Forms.Label measureLabel1;
        private System.Windows.Forms.Label measureLabel2;
        private System.Windows.Forms.Button rentGridButton;
    }
}