namespace Lab10_rent_a_car
{
    partial class UserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminB = new System.Windows.Forms.RadioButton();
            this.managerB = new System.Windows.Forms.RadioButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(41, 179);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(252, 23);
            this.deleteButton.TabIndex = 83;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(41, 139);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(252, 23);
            this.saveButton.TabIndex = 82;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(85, 63);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(208, 20);
            this.passwordBox.TabIndex = 80;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(85, 27);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(208, 20);
            this.loginBox.TabIndex = 81;
            this.loginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Пароль:";
            // 
            // adminB
            // 
            this.adminB.AutoSize = true;
            this.adminB.Location = new System.Drawing.Point(61, 103);
            this.adminB.Name = "adminB";
            this.adminB.Size = new System.Drawing.Size(104, 17);
            this.adminB.TabIndex = 84;
            this.adminB.TabStop = true;
            this.adminB.Text = "Администратор";
            this.adminB.UseVisualStyleBackColor = true;
            this.adminB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // managerB
            // 
            this.managerB.AutoSize = true;
            this.managerB.Location = new System.Drawing.Point(192, 103);
            this.managerB.Name = "managerB";
            this.managerB.Size = new System.Drawing.Size(78, 17);
            this.managerB.TabIndex = 84;
            this.managerB.TabStop = true;
            this.managerB.Text = "Менеджер";
            this.managerB.UseVisualStyleBackColor = true;
            this.managerB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(346, 228);
            this.Controls.Add(this.managerB);
            this.Controls.Add(this.adminB);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserEdit_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox passwordBox;
        public System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton adminB;
        private System.Windows.Forms.RadioButton managerB;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}