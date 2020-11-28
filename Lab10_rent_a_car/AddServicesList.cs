using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_rent_a_car
{
    public partial class AddServicesList : Form
    {
        public AddServicesList()
        {
            InitializeComponent();
            FillGrid();
        }
        internal void FillGrid()
        {
            int i = 0;
            AddServicesGrid.Rows.Clear();
            foreach (AddService addService in Data.AddServices.AllServices)
            {
                if (!addService.Deleted)
                {
                    AddServicesGrid.Rows.Add();
                    int j = 0;
                    AddServicesGrid.Rows[i].Cells[j].Value = addService.Name; j++;
                    AddServicesGrid.Rows[i].Cells[j].Value = addService.Price; j++;
                    i++;
                }
            }
        }
        private void AddServicesGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string name = "";
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                name = AddServicesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Data.CurrentService = Data.AddServices.FindByName(name);
                ServiceView serviceView = new ServiceView();
                serviceView.Owner = this;
                serviceView.ShowDialog();
            }
        }
        private void newService_Click(object sender, EventArgs e)
        {
            ServiceEdit serviceEdit = new ServiceEdit();
            serviceEdit.Owner = this;
            serviceEdit.ShowDialog();
        }
        private void AddServicesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            if (!Data.Status) { mainForm.Text = "Аренда*"; }
        }

        private void AddServicesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
