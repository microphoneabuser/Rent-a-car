namespace Lab10_rent_a_car
{
    partial class UsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList));
            this.newUser = new System.Windows.Forms.Button();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.compAddresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(12, 206);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(213, 23);
            this.newUser.TabIndex = 4;
            this.newUser.Text = "Добавить пользователя";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            this.newUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersList_KeyDown);
            // 
            // UsersGrid
            // 
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.AllowUserToDeleteRows = false;
            this.UsersGrid.AllowUserToResizeColumns = false;
            this.UsersGrid.AllowUserToResizeRows = false;
            this.UsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compAddresses,
            this.Column1,
            this.Column2});
            this.UsersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersGrid.Location = new System.Drawing.Point(0, 1);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.Size = new System.Drawing.Size(638, 199);
            this.UsersGrid.TabIndex = 3;
            this.UsersGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersGrid_CellMouseDoubleClick);
            this.UsersGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersList_KeyDown);
            // 
            // compAddresses
            // 
            this.compAddresses.HeaderText = "Логин";
            this.compAddresses.Name = "compAddresses";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Пароль";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Статус";
            this.Column2.Name = "Column2";
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 232);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.UsersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersList_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}