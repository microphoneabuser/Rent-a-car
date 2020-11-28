namespace Lab10_rent_a_car
{
    partial class AddressesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressesList));
            this.AddressesGrid = new System.Windows.Forms.DataGridView();
            this.compAddresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressesGrid
            // 
            this.AddressesGrid.AllowUserToAddRows = false;
            this.AddressesGrid.AllowUserToDeleteRows = false;
            this.AddressesGrid.AllowUserToResizeColumns = false;
            this.AddressesGrid.AllowUserToResizeRows = false;
            this.AddressesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressesGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.AddressesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compAddresses});
            this.AddressesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AddressesGrid.Location = new System.Drawing.Point(0, 1);
            this.AddressesGrid.Name = "AddressesGrid";
            this.AddressesGrid.Size = new System.Drawing.Size(638, 199);
            this.AddressesGrid.TabIndex = 1;
            this.AddressesGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AddressesGrid_CellMouseDoubleClick);
            this.AddressesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressesList_KeyDown);
            // 
            // compAddresses
            // 
            this.compAddresses.HeaderText = "Адрес";
            this.compAddresses.Name = "compAddresses";
            // 
            // newAddress
            // 
            this.newAddress.Location = new System.Drawing.Point(12, 206);
            this.newAddress.Name = "newAddress";
            this.newAddress.Size = new System.Drawing.Size(213, 23);
            this.newAddress.TabIndex = 2;
            this.newAddress.Text = "Добавить адрес";
            this.newAddress.UseVisualStyleBackColor = true;
            this.newAddress.Click += new System.EventHandler(this.newAddress_Click);
            this.newAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressesList_KeyDown);
            // 
            // AddressesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.newAddress);
            this.Controls.Add(this.AddressesGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пункты выдачи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddressesList_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressesList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AddressesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddressesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddresses;
        private System.Windows.Forms.Button newAddress;
    }
}