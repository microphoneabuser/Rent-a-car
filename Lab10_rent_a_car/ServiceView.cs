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
    public partial class ServiceView : Form
    {
        public ServiceView()//инициализация 
        {
            InitializeComponent();
            FillForm(Data.CurrentService);
        }
        internal void FillForm(AddService addService)//заполнение
        {
            nameBox.Text = addService.Name;
            priceBox.Text = addService.Price.ToString();
        }
        private void editButton_Click(object sender, EventArgs e)//открытие формы изменения
        {
            ServiceEdit serviceEdit = new ServiceEdit(Data.CurrentService);
            serviceEdit.Owner = this;
            serviceEdit.ShowDialog();
        }
        private void deleteButton_Click(object sender, EventArgs e)//удаление
        {
            if (MessageBox.Show("Вы точно хотите удалить данную услугу?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.CurrentService.Deleted = true;
                Data.AddServices.ReplaceInfoService(Data.CurrentService);
                Data.CurrentService = null;
                Data.Status = false;
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }
        }

        private void ServiceView_Load(object sender, EventArgs e)
        {
            AddServicesList servicesList = this.Owner as AddServicesList;
            servicesList.FillGrid();
        }

        private void ServiceView_FormClosed(object sender, FormClosedEventArgs e)//изменения в форму родителя
        {
            AddServicesList servicesList = this.Owner as AddServicesList;
            servicesList.FillGrid();
        }

        private void ServiceView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    AddServicesList servList = this.Owner as AddServicesList;
                    servList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
