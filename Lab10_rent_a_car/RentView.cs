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
    public partial class RentView : Form
    {
        internal RentView()
        {
            InitializeComponent();
            FillForm(Data.CurrentRent);
        }
        internal void FillForm (Rent rent)//заполнение формы просмотра аренды
        {
            FIOBox.Text = rent.ClientFIO;
            carBox.Text = rent.Name;
            priceBox.Text = rent.Price.ToString();
            if ( rent.DepositMoney <= 0 ) { depositBox.Text = rent.Deposit.ToString(); }
            else { depositBox.Text = rent.DepositMoney.ToString(); }
            periodBox.Text = rent.Period.ToString();
            measureLabel.Text = rent.Measure;
            //totalBox.Text = rent.GetTotalPrice(Data.AddServices);  
            addressBox.Text = rent.CompAddress;
            secondAddressBox.Text = rent.SecondAddress;
            try { carPic.Image = System.Drawing.Image.FromFile(Data.Storage + $"DB/Pics/{rent.Name}.jpg"); }
            catch { }
            if(rent.Status == "Завершена")
            {
                editButton.Enabled = false;
                endRentButton.Enabled = false;
            }
            statusBox.Text = rent.Status;
            fdateBox.Text = rent.DateTime.ToShortDateString();
            ftimeBox.Text = rent.DateTime.ToShortTimeString();

            if (rent.Measure == "дней")
            {
                sdateBox.Text = rent.DateTime.AddDays(rent.Period).ToShortDateString();
                stimeBox.Text = rent.DateTime.ToShortTimeString();
                objectMeasureLabel.Text = "в день";
            }
            if (rent.Measure == "часов")
            {
                DateTime nDate = rent.DateTime.AddHours(rent.Period);
                stimeBox.Text = nDate.ToShortTimeString();
                sdateBox.Text = nDate.ToShortDateString();
                objectMeasureLabel.Text = "в час";

            }
            if (rent.Measure == "месяцев")
            {
                sdateBox.Text = rent.DateTime.AddMonths((int)rent.Period).ToShortDateString();
                stimeBox.Text = rent.DateTime.ToShortTimeString();
                objectMeasureLabel.Text = "в месяц";
            }
            descriptionBox.Text = rent.Description;
            if (addServicesListBox.Items.Count == 0) { BuildAddServicesListBox(Data.AddServices); }
            for (int i = 0; i < addServicesListBox.Items.Count; i++)//простановка галочек в листбоксе
            {
                if (rent.AddServices.Contains(i)) { addServicesListBox.SetItemChecked(i, true); }
                else { addServicesListBox.SetItemChecked(i, false); }
            }
            List<AddService> ads = Data.AddServices.AllServices;
            decimal p = 0m;
            foreach (string elem in addServicesListBox.CheckedItems)
            {
                AddService adds;
                try
                {
                    adds = Data.AddServices.FindByName(elem.Remove(elem.IndexOf('(')));
                    p += adds.Price;
                }
                catch
                {
                }
            }
            if (Data.Settings.Round == 0)
            {
                totalBox.Text = ((rent.Price * (decimal)(Math.Ceiling(rent.Period)))+p).ToString();
            }
            if (Data.Settings.Round == 1)
            {
                totalBox.Text = ((rent.Price * (decimal)(Math.Round(rent.Period)))+p).ToString();
            }
            if (Data.Settings.Round == 2)
            {
                totalBox.Text = ((rent.Price * (decimal)(Math.Floor(rent.Period)))+p).ToString();
            }
            if (Data.Settings.Round == 3)
            {
                totalBox.Text = ((rent.Price * (decimal)(rent.Period))+p).ToString();
            }
        }
        private void BuildAddServicesListBox(AddServices addServices)//заполнение списка листбокса доп.услуг
        {
            foreach (AddService add in addServices.AllServices)
            {
                addServicesListBox.Items.Add(add.Name + "(" + add.Price + " руб)");
            }
        }
        private void editButton_Click(object sender, EventArgs e)//открытие формы редактирования
        {
            RentEdit rentEdit = new RentEdit(Data.CurrentRent);
            rentEdit.Owner = this;
            rentEdit.ShowDialog();
        }

        private void RentView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //обновление формы "родителя"
            carPic.Image.Dispose();
            try
            {
                MainForm mainForm = this.Owner as MainForm;
                mainForm.FillRents();
            }
            catch { }
            try
            {
                RentsList rentList = this.Owner as RentsList;
                rentList.FillList(Data.CurrentObject);
            }
            catch { }
        }

        private void deleteButton_Click(object sender, EventArgs e)//удаление элемента
        {
            if (MessageBox.Show("Вы точно хотите удалить данную аренду?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Status = false;
                Data.CurrentRent.Saved = false;
                if(Data.CurrentRent.Status == "Активная" || Data.CurrentRent.Status == "Забронирована")
                {
                    Data.Objects.FindByName(Data.CurrentRent.Name).InStock++;
                    Data.Objects.FindByName(Data.CurrentRent.Name).InRent--;
                }
                Data.Rents.ReplaceInfoRent(Data.CurrentRent);
                Data.Rents.SavedRents.Remove(Data.CurrentRent);
                Data.CurrentRent = null;
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }
        }

        private void RentView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    RentsList rList = this.Owner as RentsList;
                    ObjectView objectView = rList.Owner as ObjectView;
                    ObjectsList objList = objectView.Owner as ObjectsList;
                    rList.Close();
                    objectView.Close();
                    objList.Close();
                }
                catch
                {

                }
            }
            
        }

        private void endRentButton_Click(object sender, EventArgs e)
        {
            if(Data.CurrentRent.Status != "Завершена")
            {
                if(MessageBox.Show("После завершения аренды ее невозможно будет редактировать, вы уверены?",
                    "",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Data.CurrentRent.Status == "Активная" || Data.CurrentRent.Status == "Забронирована")
                    {
                        Data.Objects.FindByName(Data.CurrentRent.Name).InStock++;
                        Data.Objects.FindByName(Data.CurrentRent.Name).InRent--;
                    }
                    Data.CurrentRent.Status = "Завершена";

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Аренда уже завершена!","!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
