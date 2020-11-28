namespace Lab10_rent_a_car
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.rentsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.catE = new System.Windows.Forms.CheckBox();
            this.catD = new System.Windows.Forms.CheckBox();
            this.catC = new System.Windows.Forms.CheckBox();
            this.catB = new System.Windows.Forms.CheckBox();
            this.catA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Категории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер водительского удостоверения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(72, 23);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.ReadOnly = true;
            this.FIOBox.Size = new System.Drawing.Size(292, 20);
            this.FIOBox.TabIndex = 9;
            this.FIOBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(88, 59);
            this.PassBox.Name = "PassBox";
            this.PassBox.ReadOnly = true;
            this.PassBox.Size = new System.Drawing.Size(276, 20);
            this.PassBox.TabIndex = 9;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // licenseBox
            // 
            this.licenseBox.Location = new System.Drawing.Point(237, 93);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ReadOnly = true;
            this.licenseBox.Size = new System.Drawing.Size(127, 20);
            this.licenseBox.TabIndex = 9;
            this.licenseBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(120, 161);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(244, 20);
            this.addressBox.TabIndex = 9;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // rentsListBox
            // 
            this.rentsListBox.FormattingEnabled = true;
            this.rentsListBox.Location = new System.Drawing.Point(35, 223);
            this.rentsListBox.Name = "rentsListBox";
            this.rentsListBox.Size = new System.Drawing.Size(329, 108);
            this.rentsListBox.TabIndex = 10;
            this.rentsListBox.SelectedIndexChanged += new System.EventHandler(this.rentsListBox_SelectedIndexChanged);
            this.rentsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Список аренд:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(35, 375);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(329, 23);
            this.deleteButton.TabIndex = 68;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(35, 346);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(329, 23);
            this.editButton.TabIndex = 66;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // catE
            // 
            this.catE.AutoSize = true;
            this.catE.Enabled = false;
            this.catE.Location = new System.Drawing.Point(331, 129);
            this.catE.Name = "catE";
            this.catE.Size = new System.Drawing.Size(33, 17);
            this.catE.TabIndex = 69;
            this.catE.Text = "E";
            this.catE.UseVisualStyleBackColor = true;
            this.catE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // catD
            // 
            this.catD.AutoSize = true;
            this.catD.Enabled = false;
            this.catD.Location = new System.Drawing.Point(280, 129);
            this.catD.Name = "catD";
            this.catD.Size = new System.Drawing.Size(34, 17);
            this.catD.TabIndex = 70;
            this.catD.Text = "D";
            this.catD.UseVisualStyleBackColor = true;
            this.catD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // catC
            // 
            this.catC.AutoSize = true;
            this.catC.Enabled = false;
            this.catC.Location = new System.Drawing.Point(227, 129);
            this.catC.Name = "catC";
            this.catC.Size = new System.Drawing.Size(33, 17);
            this.catC.TabIndex = 71;
            this.catC.Text = "C";
            this.catC.UseVisualStyleBackColor = true;
            this.catC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // catB
            // 
            this.catB.AutoSize = true;
            this.catB.Enabled = false;
            this.catB.Location = new System.Drawing.Point(176, 129);
            this.catB.Name = "catB";
            this.catB.Size = new System.Drawing.Size(33, 17);
            this.catB.TabIndex = 72;
            this.catB.Text = "B";
            this.catB.UseVisualStyleBackColor = true;
            this.catB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // catA
            // 
            this.catA.AutoSize = true;
            this.catA.Enabled = false;
            this.catA.Location = new System.Drawing.Point(120, 129);
            this.catA.Name = "catA";
            this.catA.Size = new System.Drawing.Size(33, 17);
            this.catA.TabIndex = 73;
            this.catA.Text = "A";
            this.catA.UseVisualStyleBackColor = true;
            this.catA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(406, 417);
            this.Controls.Add(this.catE);
            this.Controls.Add(this.catD);
            this.Controls.Add(this.catC);
            this.Controls.Add(this.catB);
            this.Controls.Add(this.catA);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.rentsListBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientView_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ListBox rentsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.CheckBox catE;
        private System.Windows.Forms.CheckBox catD;
        private System.Windows.Forms.CheckBox catC;
        private System.Windows.Forms.CheckBox catB;
        private System.Windows.Forms.CheckBox catA;
    }
}