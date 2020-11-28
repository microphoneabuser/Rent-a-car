namespace Lab10_rent_a_car
{
    partial class ObjectsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsList));
            this.CarsGrid = new System.Windows.Forms.DataGridView();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CarsGrid
            // 
            this.CarsGrid.AllowUserToAddRows = false;
            this.CarsGrid.AllowUserToDeleteRows = false;
            this.CarsGrid.AllowUserToResizeColumns = false;
            this.CarsGrid.AllowUserToResizeRows = false;
            this.CarsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CarsGrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.CarsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.model,
            this.num,
            this.priceColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.CarsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CarsGrid.Location = new System.Drawing.Point(1, 1);
            this.CarsGrid.Name = "CarsGrid";
            this.CarsGrid.Size = new System.Drawing.Size(847, 256);
            this.CarsGrid.TabIndex = 1;
            this.CarsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CarsGrid_CellMouseDoubleClick);
            this.CarsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectsList_KeyDown);
            // 
            // model
            // 
            this.model.HeaderText = "Название";
            this.model.Name = "model";
            // 
            // num
            // 
            this.num.HeaderText = "Серийный номер";
            this.num.Name = "num";
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Цена";
            this.priceColumn.Name = "priceColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Количество";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "В аренде";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "На складе";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "В ремонте";
            this.Column4.Name = "Column4";
            // 
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(12, 263);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(198, 23);
            this.newCar.TabIndex = 2;
            this.newCar.Text = "Добавить объект";
            this.newCar.UseVisualStyleBackColor = true;
            this.newCar.Click += new System.EventHandler(this.newCar_Click);
            this.newCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectsList_KeyDown);
            // 
            // ObjectsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 293);
            this.Controls.Add(this.newCar);
            this.Controls.Add(this.CarsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ObjectsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты аренды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarsList_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectsList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CarsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarsGrid;
        private System.Windows.Forms.Button newCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}