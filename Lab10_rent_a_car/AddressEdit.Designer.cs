namespace Lab10_rent_a_car
{
    partial class AddressEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(42, 139);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(252, 23);
            this.deleteButton.TabIndex = 77;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressEdit_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(42, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(252, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressEdit_KeyDown);
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(83, 64);
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(211, 20);
            this.houseBox.TabIndex = 1;
            this.houseBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressEdit_KeyDown);
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(83, 28);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(211, 20);
            this.streetBox.TabIndex = 1;
            this.streetBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressEdit_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дом:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Улица:";
            // 
            // AddressEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(352, 198);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.houseBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressEdit";
            this.Padding = new System.Windows.Forms.Padding(20, 61, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пункт выдачи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddressEdit_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressEdit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox houseBox;
        public System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}