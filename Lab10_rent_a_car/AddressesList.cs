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
    public partial class AddressesList : Form
    {
        public AddressesList()
        {
            InitializeComponent();
            FillGrid();
        }
        internal void FillGrid()
        {
            int i = 0;
            AddressesGrid.Rows.Clear();
            foreach (Address address in Data.Addresses.AllAddresses)
            {
                if (!address.Deleted)
                {
                    AddressesGrid.Rows.Add();
                    int j = 0;
                    AddressesGrid.Rows[i].Cells[j].Value = address.Name; j++;
                    i++;
                }
            }
        }
        private void AddressesGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                Address address = Data.Addresses.FindByName(AddressesGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Data.CurrentAddress = address;
                AddressEdit addressEdit = new AddressEdit();
                addressEdit.Owner = this;
                addressEdit.ShowDialog();
            }
        }
        private void newAddress_Click(object sender, EventArgs e)
        {
            Data.CurrentAddress = new Address();
            AddressEdit addressEdit = new AddressEdit();
            addressEdit.Owner = this;
            addressEdit.ShowDialog();
        }
        private void AddressesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            if (!Data.Status) { mainForm.Text = "Аренда*"; }
        }

        private void AddressesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
