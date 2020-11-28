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
    public partial class AddressEdit : Form
    {
        string inName;
        public AddressEdit()//инициализация
        {
            InitializeComponent();
            try 
            { 
                FillForm(); 
                inName = Data.CurrentAddress.Name;
            }
            catch
            {
                streetBox.Text = ""; houseBox.Text = "";
            }

        }
        internal void FillForm() //запонение формы адреса
        {
            string[] array = Data.CurrentAddress.Name.Split(',');
            streetBox.Text = array[0].Substring(4, array[0].Length - 4);
            houseBox.Text = array[1].Substring(4, array[1].Length - 4);
        }
        private void saveButton_Click(object sender, EventArgs e)//сохранение адреса
        {
            if (streetBox.Text == "" || houseBox.Text == "")
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Заполнены не все поля");
                MessageBox.Show("Для сохранения заполните поле формы.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveThisForm();
                Data.Status = false;
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
                MessageBox.Show("Данные успешно изменены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void SaveThisForm()//сохранение формы
        {
            if (Data.Addresses.FindByName(inName) == null)
            {
                Data.CurrentAddress.Name = $"ул. {streetBox.Text}, д. {houseBox.Text}";
                Data.CurrentAddress.Deleted = false;
                Data.Addresses.AddAddress(Data.CurrentAddress);
            }
            else
            {
                Data.Addresses.FindByName(inName).Name = $"ул. {streetBox.Text}, д. {houseBox.Text}";
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)//удаление адреса
        {
            if (MessageBox.Show("Вы точно хотите удалить данный адрес?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Addresses.FindByName(Data.CurrentAddress.Name).Deleted = true;
                Data.CurrentAddress = null;
                Data.Status = false;
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }
        }

        private void AddressEdit_FormClosed(object sender, FormClosedEventArgs e)//внесение изменений в форму родителя
        {
            AddressesList addressesList = this.Owner as AddressesList;
            addressesList.FillGrid();
        }

        private void AddressEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    AddressesList addList = this.Owner as AddressesList;
                    addList.Close();
                }
                catch
                {

                }
            }
        }

        
    }
}
