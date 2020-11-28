namespace Lab10_rent_a_car
{
    partial class ClientEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEdit));
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.catA = new System.Windows.Forms.CheckBox();
            this.catB = new System.Windows.Forms.CheckBox();
            this.catC = new System.Windows.Forms.CheckBox();
            this.catD = new System.Windows.Forms.CheckBox();
            this.catE = new System.Windows.Forms.CheckBox();
            this.passBox = new System.Windows.Forms.MaskedTextBox();
            this.licenseBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(62, 17);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(213, 20);
            this.FIOBox.TabIndex = 0;
            this.FIOBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            this.FIOBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIOBox_KeyPress);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(110, 173);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(165, 20);
            this.addressBox.TabIndex = 0;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер водительского удостоверения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Паспорт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Категории:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Адрес клиента:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 211);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(250, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // catA
            // 
            this.catA.AutoSize = true;
            this.catA.Location = new System.Drawing.Point(91, 140);
            this.catA.Name = "catA";
            this.catA.Size = new System.Drawing.Size(33, 17);
            this.catA.TabIndex = 4;
            this.catA.Text = "A";
            this.catA.UseVisualStyleBackColor = true;
            this.catA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // catB
            // 
            this.catB.AutoSize = true;
            this.catB.Location = new System.Drawing.Point(130, 140);
            this.catB.Name = "catB";
            this.catB.Size = new System.Drawing.Size(33, 17);
            this.catB.TabIndex = 4;
            this.catB.Text = "B";
            this.catB.UseVisualStyleBackColor = true;
            this.catB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // catC
            // 
            this.catC.AutoSize = true;
            this.catC.Location = new System.Drawing.Point(169, 140);
            this.catC.Name = "catC";
            this.catC.Size = new System.Drawing.Size(33, 17);
            this.catC.TabIndex = 4;
            this.catC.Text = "C";
            this.catC.UseVisualStyleBackColor = true;
            this.catC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // catD
            // 
            this.catD.AutoSize = true;
            this.catD.Location = new System.Drawing.Point(208, 140);
            this.catD.Name = "catD";
            this.catD.Size = new System.Drawing.Size(34, 17);
            this.catD.TabIndex = 4;
            this.catD.Text = "D";
            this.catD.UseVisualStyleBackColor = true;
            this.catD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // catE
            // 
            this.catE.AutoSize = true;
            this.catE.Location = new System.Drawing.Point(248, 140);
            this.catE.Name = "catE";
            this.catE.Size = new System.Drawing.Size(33, 17);
            this.catE.TabIndex = 4;
            this.catE.Text = "E";
            this.catE.UseVisualStyleBackColor = true;
            this.catE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(81, 49);
            this.passBox.Mask = "0000 000000";
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(194, 20);
            this.passBox.TabIndex = 5;
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // licenseBox
            // 
            this.licenseBox.Location = new System.Drawing.Point(25, 104);
            this.licenseBox.Mask = "0000 000000";
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(250, 20);
            this.licenseBox.TabIndex = 5;
            this.licenseBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(298, 256);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.catE);
            this.Controls.Add(this.catD);
            this.Controls.Add(this.catC);
            this.Controls.Add(this.catB);
            this.Controls.Add(this.catA);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.addressBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientEdit_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox catA;
        private System.Windows.Forms.CheckBox catB;
        private System.Windows.Forms.CheckBox catC;
        private System.Windows.Forms.CheckBox catD;
        private System.Windows.Forms.CheckBox catE;
        private System.Windows.Forms.MaskedTextBox passBox;
        private System.Windows.Forms.MaskedTextBox licenseBox;
    }
}