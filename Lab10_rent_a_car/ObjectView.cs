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
    public partial class ObjectView : Form
    {
        public ObjectView()
        {
            InitializeComponent();
            FillForm(Data.CurrentObject);
        }
        internal void FillForm(Object obj)//заполнение
        {
            nameBox.Text = obj.Name;
            numBox.Text = obj.Num;
            priceBox.Text = obj.Price.ToString();
            quantityBox.Text = obj.Quantity.ToString();
            inRentBox.Text = obj.InRent.ToString();
            inStockBox.Text = obj.InStock.ToString();
            repairBox.Text = obj.Repair.ToString();
            minTBox.Text = obj.MinT.ToString();
            maxTBox.Text = obj.MaxT.ToString();
            descriptionBox.Text = obj.Description;
            damageBox.Text = obj.Damage;
            measureLabel1.Text = obj.Measure;
            measureLabel2.Text = obj.Measure;
            try { carPic.Image = System.Drawing.Image.FromFile($"DB/Pics/{nameBox.Text}.jpg"); }
            catch { }
            if (obj.Rents != null)
            {
                rentsListBox.Items.Clear();
                foreach (int rentID in obj.Rents)
                {
                    rentsListBox.Items.Add($"Договор №{rentID}");
                }
            }
            else { rentsListBox.Items.Clear(); }
        }
        private void editButton_Click(object sender, EventArgs e)//открытие формы изменения
        {
            ObjectEdit objectEdit = new ObjectEdit(Data.CurrentObject);
            objectEdit.Owner = this;
            objectEdit.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)//удаление машины
        {
            if (MessageBox.Show("Вы точно хотите удалить данную машину?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Status = false;
                Data.CurrentObject.Deleted = true;
                Data.Objects.ReplaceInfoObject(Data.CurrentObject);
                Data.CurrentObject = null;
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }
        }

        private void CarView_FormClosed(object sender, FormClosedEventArgs e)//изменения в форму родителя
        {
            ObjectsList objectsList = this.Owner as ObjectsList;
            objectsList.FillGrid();
            carPic.Image.Dispose();
        }

        private void rentsListBox_SelectedIndexChanged(object sender, EventArgs e)//открытие соответсвующей формы аренды
        {
            if(rentsListBox.SelectedItem != null) 
            { 
                string myID = "";
                //подготовка формы аренды
                myID = rentsListBox.SelectedItem.ToString().Substring(9);
                Data.CurrentRent = Data.Rents.FindByID(int.Parse(myID));
                MainForm mainForm = this.Owner.Owner as MainForm;
                RentView rentView = new RentView();
                if (!Data.CurrentRent.Saved) { rentView.statusBox.Text = "Удалена";
                    rentView.editButton.Enabled = false;
                    rentView.deleteButton.Enabled = false;
                }
                rentView.Owner = mainForm;
                rentView.ShowDialog();//открытие формы просмотра аренды
            }
        }

        private void rentGridButton_Click(object sender, EventArgs e)
        {
            RentsList rentList = new RentsList();
            rentList.Owner = this;
            rentList.ShowDialog();
        }

        private void ObjectView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    ObjectsList objList = this.Owner as ObjectsList;
                    objList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
