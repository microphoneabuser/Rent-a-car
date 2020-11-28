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
    public partial class RentsList : Form
    {
        public RentsList()
        {
            InitializeComponent();
            FillList(Data.CurrentObject);
        }
        internal void FillList(Object obj)
        {
            int i = 0;
            RentsGrid.Rows.Clear();
            foreach (Rent rent in Data.Rents.AllRents)//перебор всех аренд для заполнения
            {
                if (rent.Name == obj.Name)
                {
                    if (RentsGrid.Rows.Count < Data.Rents.AllRents.Count) { RentsGrid.Rows.Add(); }
                    int j = 0;
                    RentsGrid.Rows[i].Cells[j].Value = rent.ID; j++;
                    RentsGrid.Rows[i].Cells[j].Value = rent.ClientFIO; j++;
                    RentsGrid.Rows[i].Cells[j].Value = rent.Name; j++;
                    RentsGrid.Rows[i].Cells[j].Value = rent.DateTime.ToString(); j++;
                    if (rent.Measure == "дней")
                    {
                        RentsGrid.Rows[i].Cells[j].Value = rent.DateTime.AddDays(rent.Period).ToString();
                    }
                    if (rent.Measure == "часов")
                    {
                        DateTime nDate = rent.DateTime.AddHours(rent.Period);
                        RentsGrid.Rows[i].Cells[j].Value = nDate.ToString();
                    }
                    if (rent.Measure == "месяцев")
                    {
                        RentsGrid.Rows[i].Cells[j].Value = rent.DateTime.AddMonths((int)rent.Period).ToString();
                    }
                    j++;
                    RentsGrid.Rows[i].Cells[j].Value = $"{rent.Period} {rent.Measure}"; j++;
                    RentsGrid.Rows[i].Cells[j].Value = rent.CompAddress; j++;
                    if (!rent.Saved) { RentsGrid.Rows[i].Cells[j].Value = "Удалена"; j++; }
                    else
                    {
                        RentsGrid.Rows[i].Cells[j].Value = rent.Status; j++;
                    }
                    i++;
                }
            }
        }

        private void RentsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string myID = "";
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                //подготовка формы аренды
                myID = RentsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Data.CurrentRent = Data.Rents.FindByID(int.Parse(myID));
                RentView rentView = new RentView();
                rentView.Owner = this;
                if (!Data.CurrentRent.Saved) 
                { 
                    rentView.statusBox.Text = "Удалена";
                    rentView.editButton.Enabled = false;
                    rentView.deleteButton.Enabled = false;
                }
                rentView.ShowDialog();//открытие формы просмотра аренды
            }
        }

        private void RentsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    ObjectView objectView = this.Owner as ObjectView;
                    ObjectsList objList = objectView.Owner as ObjectsList;
                    objectView.Close();
                    objList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
