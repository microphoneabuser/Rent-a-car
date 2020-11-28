using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab10_rent_a_car
{
    public partial class ClientEdit : Form
    {
        internal ClientEdit()//новый
        {
            InitializeComponent();
            Data.CurrentClient = new Client();
            Data.Clients.AddClient(Data.CurrentClient);
        }
        internal ClientEdit(Client client)//существующий
        {
            InitializeComponent();
            FillForm(client);
        }
        internal void FillForm(Client client)//заполнение
        {
            FIOBox.Text = client.FIO;
            passBox.Text = client.Passport;
            licenseBox.Text = client.License;
            if (client.Category.Contains(catA.Text)) catA.Checked = true; else catA.Checked = false;
            if (client.Category.Contains(catB.Text)) catB.Checked = true; else catB.Checked = false;
            if (client.Category.Contains(catC.Text)) catC.Checked = true; else catC.Checked = false;
            if (client.Category.Contains(catD.Text)) catD.Checked = true; else catD.Checked = false;
            if (client.Category.Contains(catE.Text)) catE.Checked = true; else catE.Checked = false;
            addressBox.Text = client.Address;
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            Data.CurrentClient.FIO = FIOBox.Text;
            Data.CurrentClient.Passport = passBox.Text;
            Data.CurrentClient.License = licenseBox.Text;
            Data.CurrentClient.Category = "";
            if (catA.Checked) { Data.CurrentClient.Category += "A"; }
            if (catB.Checked) { Data.CurrentClient.Category += "B"; }
            if (catC.Checked) { Data.CurrentClient.Category += "C"; }
            if (catD.Checked) { Data.CurrentClient.Category += "D"; }
            if (catE.Checked) { Data.CurrentClient.Category += "E"; }
            Data.CurrentClient.Address = addressBox.Text;
            Data.CurrentClient.Saved = true;
            if (Data.Clients.SavedClients.FindIndex(x => x.FIO == Data.CurrentClient.FIO) == -1)
                Data.Clients.SavedClients.Add(Data.CurrentClient);
            Data.Clients.ReplaceInfoClient(Data.CurrentClient);
        }
        private void saveButton_Click(object sender, EventArgs e)//сохранение
        {
            if(FIOBox.Text == "" || passBox.Text == "" || licenseBox.Text == "" || addressBox.Text == "")
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Заполнены не все поля");
                MessageBox.Show("Для сохранения заполните все поля формы.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveThisForm();
                Data.Status = false;
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
                MessageBox.Show("Данные успешно изменены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ClientView clientView = this.Owner as ClientView;
                if(clientView != null) clientView.Close();
            }
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)//вводить только цифры
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void licenseBox_KeyPress(object sender, KeyPressEventArgs e)//вводить только цифры
        {
            passBox_KeyPress(sender, e);
        }
        private void FIOBox_KeyPress(object sender, KeyPressEventArgs e)//ввод только букв
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
        private void ClientEdit_FormClosed(object sender, FormClosedEventArgs e)//изменения в форму родителя
        {
            try
            {
                ClientView clientView = this.Owner as ClientView;
                if (FIOBox.Text == "" || passBox.Text == "" || passBox.Text == "" || licenseBox.Text == "" || addressBox.Text == "")
                {
                    Data.Clients.DelClient(Data.CurrentClient);
                    clientView.Close();
                }
                else
                {
                    clientView.FillForm(Data.CurrentClient);
                }
            }
            catch
            {
                MainForm mainForm = this.Owner as MainForm;
                mainForm.FillClients();
            }
            
        }
        private void passBox_Leave(object sender, EventArgs e)//проверка правильности ввода паспорта
        {
            Regex regex = new Regex(@"^\d{4}\s\d{6}$");
            if (!regex.IsMatch(passBox.Text))
            {
                MessageBox.Show("Введен неправильный формат данных.", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Введены неверные данные");
            }

        }

        private void licenseBox_Leave(object sender, EventArgs e)//проверка правильности ввода прав
        {
            Regex regex = new Regex(@"^\d{4}\s\d{6}$");
            if (!regex.IsMatch(licenseBox.Text))
            {
                MessageBox.Show("Введен неправильный формат данных.", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Введены неверные данные");
            }
        }

        private void ClientEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    ClientView clientView = this.Owner as ClientView;
                    clientView.Close();
                }
                catch
                {
                }
            }
        }
    }
}
