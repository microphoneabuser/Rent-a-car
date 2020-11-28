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
    public partial class ClientView : Form
    {
        public ClientView()//инициализация
        {
            InitializeComponent();
            FillForm(Data.CurrentClient);
        }
        internal void FillForm (Client client)//заполнение формы просмотра клиента
        {
            FIOBox.Text = client.FIO;
            PassBox.Text = client.Passport;
            licenseBox.Text = client.License;
            if (client.Category.Contains(catA.Text)) catA.Checked = true; else catA.Checked = false;
            if (client.Category.Contains(catB.Text)) catB.Checked = true; else catB.Checked = false;
            if (client.Category.Contains(catC.Text)) catC.Checked = true; else catC.Checked = false;
            if (client.Category.Contains(catD.Text)) catD.Checked = true; else catD.Checked = false;
            if (client.Category.Contains(catE.Text)) catE.Checked = true; else catE.Checked = false;
            addressBox.Text = client.Address;
            if (client.Rents != null)
            {
                rentsListBox.Items.Clear();
                foreach (int rentID in client.Rents)
                {
                    rentsListBox.Items.Add($"Договор №{rentID}");
                }
            }
            else { rentsListBox.Items.Clear(); }
        }
        private void editButton_Click(object sender, EventArgs e)//открытие формы изменения
        {
            ClientEdit clientEdit = new ClientEdit(Data.CurrentClient);
            clientEdit.Owner = this;
            clientEdit.ShowDialog();
        }
        private void deleteButton_Click(object sender, EventArgs e)//удаление
        {
            if (MessageBox.Show("Вы точно хотите удалить данного клиента?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Status = false;
                Data.Clients.FindByFIO(Data.CurrentClient.FIO).Saved = false;
                Data.Clients.SavedClients.Remove(Data.CurrentClient);
                Data.CurrentClient = null;
                Data.Clients.SaveClients();
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }

        }
        public void ClientView_FormClosed(object sender, FormClosedEventArgs e)//изменения в форму родителя
        {
            MainForm mainForm = this.Owner as MainForm;
            mainForm.FillClients();
        }

        private void rentsListBox_SelectedIndexChanged(object sender, EventArgs e)//открытие формы соответсвующей аренды
        {
            if (rentsListBox.SelectedItem != null)
            {
                string myID = "";
                //подготовка формы аренды
                myID = rentsListBox.SelectedItem.ToString().Substring(9);
                Data.CurrentRent = Data.Rents.FindByID(int.Parse(myID));
                MainForm mainForm = this.Owner as MainForm;
                RentView rentView = new RentView();
                rentView.Owner = mainForm;
                rentView.ShowDialog();//открытие формы просмотра аренды
            }
        }

        private void ClientView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
