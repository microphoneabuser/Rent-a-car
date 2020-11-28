namespace Lab10_rent_a_car
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.DefaultPrice = new System.Windows.Forms.CheckBox();
            this.DefaultDeposit = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.DefaultPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.copyDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbPathBox = new System.Windows.Forms.TextBox();
            this.roundBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DefaultPrice
            // 
            this.DefaultPrice.AutoSize = true;
            this.DefaultPrice.Location = new System.Drawing.Point(40, 24);
            this.DefaultPrice.Name = "DefaultPrice";
            this.DefaultPrice.Size = new System.Drawing.Size(128, 17);
            this.DefaultPrice.TabIndex = 0;
            this.DefaultPrice.Text = "Цены по умолчанию";
            this.DefaultPrice.UseVisualStyleBackColor = true;
            this.DefaultPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // DefaultDeposit
            // 
            this.DefaultDeposit.AutoSize = true;
            this.DefaultDeposit.Location = new System.Drawing.Point(174, 24);
            this.DefaultDeposit.Name = "DefaultDeposit";
            this.DefaultDeposit.Size = new System.Drawing.Size(240, 17);
            this.DefaultDeposit.TabIndex = 1;
            this.DefaultDeposit.Text = "Ограничения срока аренды по умолчанию";
            this.DefaultDeposit.UseVisualStyleBackColor = true;
            this.DefaultDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(28, 311);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(198, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            this.okButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // About
            // 
            this.About.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.About.Location = new System.Drawing.Point(232, 311);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(182, 23);
            this.About.TabIndex = 5;
            this.About.Text = "О программе";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // DefaultPeriod
            // 
            this.DefaultPeriod.Location = new System.Drawing.Point(200, 97);
            this.DefaultPeriod.Name = "DefaultPeriod";
            this.DefaultPeriod.Size = new System.Drawing.Size(43, 20);
            this.DefaultPeriod.TabIndex = 7;
            this.DefaultPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Срок аренды по умолчанию:";
            // 
            // button1
            // 
            this.button1.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_folder_2265781;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(28, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Изменить место хранения базы данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // copyDB
            // 
            this.copyDB.Image = global::Lab10_rent_a_car.Properties.Resources.iconfinder_database_3325110;
            this.copyDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyDB.Location = new System.Drawing.Point(28, 185);
            this.copyDB.Name = "copyDB";
            this.copyDB.Size = new System.Drawing.Size(386, 48);
            this.copyDB.TabIndex = 9;
            this.copyDB.Text = "Резервное копирование базы данных";
            this.copyDB.UseVisualStyleBackColor = true;
            this.copyDB.Click += new System.EventHandler(this.copyDB_Click);
            this.copyDB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Текущее расположение базы данных:";
            // 
            // dbPathBox
            // 
            this.dbPathBox.Location = new System.Drawing.Point(28, 154);
            this.dbPathBox.Name = "dbPathBox";
            this.dbPathBox.ReadOnly = true;
            this.dbPathBox.Size = new System.Drawing.Size(386, 20);
            this.dbPathBox.TabIndex = 12;
            // 
            // roundBox
            // 
            this.roundBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundBox.FormattingEnabled = true;
            this.roundBox.Items.AddRange(new object[] {
            "до полного часа, дня, месяца",
            "по законам округления",
            "по нижней границе",
            "считать точно, не округлять"});
            this.roundBox.Location = new System.Drawing.Point(187, 58);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(227, 21);
            this.roundBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "При расчете цены округлять:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(450, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundBox);
            this.Controls.Add(this.dbPathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DefaultPeriod);
            this.Controls.Add(this.About);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.DefaultDeposit);
            this.Controls.Add(this.DefaultPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DefaultPrice;
        private System.Windows.Forms.CheckBox DefaultDeposit;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.TextBox DefaultPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyDB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbPathBox;
        private System.Windows.Forms.ComboBox roundBox;
        private System.Windows.Forms.Label label3;
    }
}