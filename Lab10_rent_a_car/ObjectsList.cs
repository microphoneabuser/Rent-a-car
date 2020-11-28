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
    public partial class ObjectsList : Form
    {
        public ObjectsList()
        {
            InitializeComponent();
            FillGrid();
        }
        internal void FillGrid()
        {
            int i = 0;
            CarsGrid.Rows.Clear();
            foreach (Object obj in Data.Objects.AllObjects)
            {
                if (!obj.Deleted)
                {
                    CarsGrid.Rows.Add();
                    int j = 0;
                    CarsGrid.Rows[i].Cells[j].Value = obj.Name; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.Num; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.Price; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.Quantity; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.InRent; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.InStock; j++;
                    CarsGrid.Rows[i].Cells[j].Value = obj.Repair; j++;
                    i++;
                }
            }
        }
        private void CarsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string name = "";
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                name = CarsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Data.CurrentObject = Data.Objects.FindByName(name);
                ObjectView objView = new ObjectView();
                objView.Owner = this;
                objView.ShowDialog();
            }
        }
        private void newCar_Click(object sender, EventArgs e)
        {
            ObjectEdit objEdit = new ObjectEdit();
            objEdit.Owner = this;
            objEdit.ShowDialog();
        }
        private void CarsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            if(!Data.Status) { mainForm.Text = "Аренда*"; }
        }

        private void ObjectsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
