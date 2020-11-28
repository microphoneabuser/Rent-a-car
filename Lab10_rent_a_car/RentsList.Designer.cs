namespace Lab10_rent_a_car
{
    partial class RentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentsList));
            this.RentsGrid = new System.Windows.Forms.DataGridView();
            this.rentsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsFIOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RentsGrid
            // 
            this.RentsGrid.AllowUserToAddRows = false;
            this.RentsGrid.AllowUserToDeleteRows = false;
            this.RentsGrid.AllowUserToResizeColumns = false;
            this.RentsGrid.AllowUserToResizeRows = false;
            this.RentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RentsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.RentsGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.RentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentsID,
            this.clientsFIOs,
            this.carsColumn,
            this.priceColumn,
            this.Column1,
            this.periodColumn,
            this.addressColumn,
            this.depositColumn});
            this.RentsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RentsGrid.Location = new System.Drawing.Point(0, 0);
            this.RentsGrid.MultiSelect = false;
            this.RentsGrid.Name = "RentsGrid";
            this.RentsGrid.ReadOnly = true;
            this.RentsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RentsGrid.Size = new System.Drawing.Size(907, 275);
            this.RentsGrid.TabIndex = 30;
            this.RentsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentsGrid_CellMouseDoubleClick);
            this.RentsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentsList_KeyDown);
            // 
            // rentsID
            // 
            this.rentsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rentsID.FillWeight = 61.8976F;
            this.rentsID.HeaderText = "Номер аренды";
            this.rentsID.Name = "rentsID";
            this.rentsID.ReadOnly = true;
            // 
            // clientsFIOs
            // 
            this.clientsFIOs.FillWeight = 136.3221F;
            this.clientsFIOs.HeaderText = "ФИО";
            this.clientsFIOs.Name = "clientsFIOs";
            this.clientsFIOs.ReadOnly = true;
            this.clientsFIOs.Width = 59;
            // 
            // carsColumn
            // 
            this.carsColumn.FillWeight = 136.3221F;
            this.carsColumn.HeaderText = "Объект";
            this.carsColumn.Name = "carsColumn";
            this.carsColumn.ReadOnly = true;
            this.carsColumn.Width = 70;
            // 
            // priceColumn
            // 
            this.priceColumn.FillWeight = 70.76933F;
            this.priceColumn.HeaderText = "Дата начала аренды";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата завершения аренды";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // periodColumn
            // 
            this.periodColumn.FillWeight = 57.07007F;
            this.periodColumn.HeaderText = "Срок аренды";
            this.periodColumn.Name = "periodColumn";
            this.periodColumn.ReadOnly = true;
            this.periodColumn.Width = 90;
            // 
            // addressColumn
            // 
            this.addressColumn.FillWeight = 136.3221F;
            this.addressColumn.HeaderText = "Пункт выдачи";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 94;
            // 
            // depositColumn
            // 
            this.depositColumn.FillWeight = 64.97462F;
            this.depositColumn.HeaderText = "Статус";
            this.depositColumn.Name = "depositColumn";
            this.depositColumn.ReadOnly = true;
            this.depositColumn.Width = 66;
            // 
            // RentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 275);
            this.Controls.Add(this.RentsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список аренд";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentsList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RentsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsFIOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositColumn;
    }
}