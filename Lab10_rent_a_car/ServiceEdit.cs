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
    public partial class ServiceEdit : Form
    {
        public ServiceEdit()//инициализация новой услуги
        {
            InitializeComponent();
            Data.CurrentService = new AddService(Data.AddServices.GetMaxID() + 1);
            Data.AddServices.AddService(Data.CurrentService);
        }
        internal ServiceEdit(AddService addService)//инициализация существующей услуги
        {
            InitializeComponent();
            FillForm(addService);
        }
        internal void FillForm(AddService addService)//заполнение
        {
            nameBox.Text = addService.Name;
            priceBox.Text = addService.Price.ToString();
        }
        private void saveButton_Click(object sender, EventArgs e)//сохранение услуги
        {
            if (nameBox.Text == "" || priceBox.Text == "")
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
                ServiceView serviceView = this.Owner as ServiceView;
                if(serviceView != null)serviceView.Close();
            }
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            Data.CurrentService.Name = nameBox.Text;
            Data.CurrentService.Price = decimal.Parse(priceBox.Text);
            Data.CurrentService.Deleted = false;
            Data.AddServices.ReplaceInfoService(Data.CurrentService);
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)//вводить только числа
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void ServiceEdit_FormClosed(object sender, FormClosedEventArgs e)//изменение формы родителя
        {
            try
            {
                ServiceView serviceView = this.Owner as ServiceView;
                if (nameBox.Text == "" || priceBox.Text == "")
                {
                    Data.AddServices.DelService(Data.CurrentService);
                    serviceView.Close();
                }
                serviceView.FillForm(Data.CurrentService);
            }
            catch
            {
                AddServicesList addServicesList = this.Owner as AddServicesList;
                addServicesList.FillGrid();
            }
        }

        private void ServiceEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    ServiceView servView = this.Owner as ServiceView;
                    AddServicesList servList = servView.Owner as AddServicesList;
                    servView.Close();
                    servList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
