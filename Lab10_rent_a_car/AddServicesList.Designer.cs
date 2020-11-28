namespace Lab10_rent_a_car
{
    partial class AddServicesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServicesList));
            this.AddServicesGrid = new System.Windows.Forms.DataGridView();
            this.adsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddServicesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddServicesGrid
            // 
            this.AddServicesGrid.AllowUserToAddRows = false;
            this.AddServicesGrid.AllowUserToDeleteRows = false;
            this.AddServicesGrid.AllowUserToResizeColumns = false;
            this.AddServicesGrid.AllowUserToResizeRows = false;
            this.AddServicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddServicesGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.AddServicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddServicesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adsNameColumn,
            this.adsPriceColumn});
            this.AddServicesGrid.Location = new System.Drawing.Point(0, 1);
            this.AddServicesGrid.Name = "AddServicesGrid";
            this.AddServicesGrid.Size = new System.Drawing.Size(613, 181);
            this.AddServicesGrid.TabIndex = 1;
            this.AddServicesGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AddServicesGrid_CellMouseDoubleClick);
            this.AddServicesGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddServicesList_KeyDown);
            // 
            // adsNameColumn
            // 
            this.adsNameColumn.HeaderText = "Услуга";
            this.adsNameColumn.Name = "adsNameColumn";
            // 
            // adsPriceColumn
            // 
            this.adsPriceColumn.HeaderText = "Цена";
            this.adsPriceColumn.Name = "adsPriceColumn";
            // 
            // newService
            // 
            this.newService.Location = new System.Drawing.Point(12, 188);
            this.newService.Name = "newService";
            this.newService.Size = new System.Drawing.Size(212, 23);
            this.newService.TabIndex = 2;
            this.newService.Text = "Добавить услугу";
            this.newService.UseVisualStyleBackColor = true;
            this.newService.Click += new System.EventHandler(this.newService_Click);
            this.newService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddServicesList_KeyDown);
            // 
            // AddServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 217);
            this.Controls.Add(this.newService);
            this.Controls.Add(this.AddServicesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddServicesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительные услуги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddServicesList_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddServicesList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AddServicesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddServicesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsPriceColumn;
        private System.Windows.Forms.Button newService;
    }
}