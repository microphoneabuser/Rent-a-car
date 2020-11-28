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
    public partial class RentEdit : Form
    {
        bool svd;
        int currentId;
        string inStatus;
        Rent srent;
        internal RentEdit()//конструктор для формы новой аренды
        {
            InitializeComponent();
            currentId = Data.CurrentRent.ID;
            //Data.Rents.AllRents.Insert(0, Data.CurrentRent);
            Data.Rents.AllRents.Reverse();
            Data.Rents.SavedRents.Reverse();
            Data.Rents.AddRent(Data.CurrentRent);
            //Data.Rents.AllRents.Reverse();
            this.Text = $"Аренда №{currentId}";
            todayButton.Visible = true;
            labelInStock.Visible = true;
            inStockBox.Visible = true;
            inStockBox.Text = "0";
            svd = true;
            docB.Checked = true;
            foreach (AddService add in Data.AddServices.AllServices)
            {
                if (!add.Deleted) { addServicesListBox.Items.Add(add.Name + "(" + add.Price + " руб)"); }
            }
            datePicker1.Value = DateTime.Now;
            hoursBox.Value = DateTime.Now.Hour;
            minutesBox.Value = DateTime.Now.Minute;
        }
        internal RentEdit(Rent rent)//конструктор для открытия формы уже существующей аренды
        {
            InitializeComponent();
            this.currentId = rent.ID;
            this.Text = $"Аренда №{currentId}";
            todayButton.Visible = false;
            labelInStock.Visible = false;
            inStockBox.Visible = false;
            svd = true;
            BuildAddServicesListBox();//заполнение списка доп.услуг
            srent = Data.CurrentRent;
            Data.Rents.AllRents.Reverse();
            Data.Rents.SavedRents.Reverse();
        }
        private void RentEdit_Load(object sender, EventArgs e)//загрузка формы
        {
            BuildCarsBox();//заполнение списка машин
            BuildFIOBox();//заполнение списка фио
            BuildAddressesBox();//заполнение списка адресов
            
            if (Data.CurrentRent.ClientFIO != null)//заполнение формы существующего клиента
            {
                FillForm(Data.CurrentRent);
            }
            else//при пустом списке клиентов
            {
                Rent newRent = new Rent(1);
                numericUpDown.Text = Data.Settings.DefaultPeriod.ToString();//применение настройки
            }
            Calculator(sender, e);
        }
        private void FillForm(Rent rent)//заполнение формы аренды
        {
            clientFIO.Text = rent.ClientFIO;
            objectBox.Text = rent.Name;
            if(objectBox.Text == null || objectBox.Text == "") { objectBox.Items.Add(rent.Name);objectBox.Text = rent.Name; }
            priceBox.Text = rent.Price.ToString();

            if (rent.DepositType == "doc") { docB.Checked = true; depositBox.Text = rent.Deposit; }
            if (rent.DepositType == "money") { moneyB.Checked = true; depositBox.Text = rent.DepositMoney.ToString(); }
            if (rent.DepositType == "product") { productB.Checked = true; depositBox.Text = rent.Deposit; }

            if (!addressesBox.Items.Contains(rent.CompAddress)) { addressesBox.Items.Add(rent.CompAddress); }
            addressesBox.Text = rent.CompAddress;
            secondAddressBox.Text = rent.SecondAddress;
            statusBox.Text = rent.Status;
            inStatus = rent.Status;

            datePicker1.Value = rent.DateTime;
            hoursBox.Value = rent.DateTime.Hour;
            minutesBox.Value = rent.DateTime.Minute;
            DateTime nDate = new DateTime();
            if (rent.Measure == "дней")
            {
                nDate = rent.DateTime.AddDays(rent.Period);
                objectMeasureLabel.Text = "в день";
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 60;
            }
            if (rent.Measure == "часов")
            {
                nDate = rent.DateTime.AddHours(rent.Period);
                objectMeasureLabel.Text = "в час";
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 48;
            }
            if (rent.Measure == "месяцев")
            {
                nDate = rent.DateTime.AddMonths((int)rent.Period);
                objectMeasureLabel.Text = "в месяц";
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 12;
            }
            datePicker2.Value = nDate;
            timePicker2.Value = nDate;
            measureBox.Text = rent.Measure;
            numericUpDown.Value = (decimal)rent.Period;
            descriptionBox.Text = rent.Description;
            for (int i = 0; i < addServicesListBox.Items.Count; i++)//простановка галочек в листбоксе
            {
                if (rent.AddServices.Contains(i)) { addServicesListBox.SetItemChecked(i, true); }
                else { addServicesListBox.SetItemChecked(i, false); }
            }
        }
        private void BuildCarsBox()//заполнение списка машин
        {
            foreach (Object obj in Data.Objects.AllObjects)
            {
                if (!obj.Deleted)
                {
                    objectBox.Items.Add(obj.Name);
                }
            }
        }
        private void BuildFIOBox()//заполнение списка фио
        {
            foreach (Client client in Data.Clients.AllClients)
            {
                clientFIO.Items.Add(client.FIO);
            }
        }
        private void BuildAddressesBox()//заполнение списка адресов
        {
            foreach (Address elem in Data.Addresses.AllAddresses)
            {
                if (elem.Name != null && !elem.Deleted)
                    addressesBox.Items.Add(elem.Name);
            }
        }
        private void BuildAddServicesListBox()//заполнение списка листбокса доп.услуг
        {
            MainForm main = this.Owner as MainForm;
            foreach (AddService add in Data.AddServices.AllServices)
            {
                addServicesListBox.Items.Add(add.Name + "(" + add.Price + " руб)");
            }
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            if (Data.CurrentRent.ClientFIO != clientFIO.Text && Data.CurrentRent.ClientFIO != null)
            { Data.Clients.FindByFIO(clientFIO.Text).Rents.Remove(Data.CurrentRent.ID); }

            try
            {
                if (Data.CurrentRent.ClientFIO == null)
                {
                    Data.Clients.FindByFIO(clientFIO.Text).Rents.Add(Data.CurrentRent.ID);
                }
            }catch { }

            Data.CurrentRent.ClientFIO = clientFIO.Text;

            if (Data.CurrentRent.Name != objectBox.Text && Data.CurrentRent.Name != null)
            { Data.Objects.FindByName(objectBox.Text).Rents.Remove(Data.CurrentRent.ID); }

            if (Data.CurrentRent.Name == null)
            {
                if (statusBox.Text == "Активная" || statusBox.Text == "Забронирована")
                {
                    Data.Objects.FindByName(objectBox.Text).Rents.Add(Data.CurrentRent.ID);
                    Data.Objects.FindByName(objectBox.Text).InRent += 1;
                    Data.Objects.FindByName(objectBox.Text).InStock -= 1;
                }
            }
            Data.CurrentRent.Name = objectBox.Text;
            Data.CurrentRent.Price = decimal.Parse(priceBox.Text);
            if (docB.Checked)
            {
                Data.CurrentRent.DepositType = "doc";
                Data.CurrentRent.Deposit = depositBox.Text;
            }
            if (moneyB.Checked)
            {
                Data.CurrentRent.DepositType = "money";
                Data.CurrentRent.DepositMoney = decimal.Parse(depositBox.Text);
            }
            if (productB.Checked)
            {
                Data.CurrentRent.DepositType = "product";
                Data.CurrentRent.Deposit = depositBox.Text;
            }
            Data.CurrentRent.CompAddress = addressesBox.Text;
            Data.CurrentRent.SecondAddress = secondAddressBox.Text;

            Data.CurrentRent.Status = statusBox.Text;
            if(inStatus != statusBox.Text)
            {
                if(inStatus == "Активная" && statusBox.Text != "Забронирована")
                {
                    Data.Objects.FindByName(objectBox.Text).InRent--;
                    Data.Objects.FindByName(objectBox.Text).InStock++;
                }
                if ((inStatus == "Завершена" || inStatus == "Отменена") && (statusBox.Text != "Завершена" || statusBox.Text != "Отменена"))
                {
                    Data.Objects.FindByName(objectBox.Text).InRent++;
                    Data.Objects.FindByName(objectBox.Text).InStock--;
                }
            }

            datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
            datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            Data.CurrentRent.DateTime = datePicker1.Value;
            
            Data.CurrentRent.Period = (double)numericUpDown.Value;
            Data.CurrentRent.Measure = measureBox.Text;
            Data.CurrentRent.Description = descriptionBox.Text;
            Data.CurrentRent.Saved = true;
            
            List<int> list = new List<int>();
            Data.CurrentRent.AddServices = list;
            foreach (string elem in addServicesListBox.CheckedItems)
            {
                AddService ads;
                try
                {
                    ads = Data.AddServices.FindByName(elem.Remove(elem.IndexOf('(')));
                    Data.CurrentRent.AddServices.Add(ads.ID);
                }
                catch
                {
                }
            }
            if (Data.Rents.SavedRents.FindIndex(x => x.ID == Data.CurrentRent.ID) == -1)
            { Data.Rents.SavedRents.Add(Data.CurrentRent); }
            Data.Rents.ReplaceInfoRent(Data.CurrentRent);
            //if (Data.Clients.FindByFIO(clientFIO.Text).Rents != null && !Data.Clients.FindByFIO(clientFIO.Text).Rents.Contains(Data.CurrentRent.ID))
               //Data.Clients.FindByFIO(clientFIO.Text).Rents.Add(Data.CurrentRent.ID);    
            //if (Data.Cars.findByModel(objectBox.Text).Rents != null && !Data.Cars.findByModel(objectBox.Text).Rents.Contains(Data.CurrentRent.ID))
                //Data.Cars.findByModel(objectBox.Text).Rents.Add(Data.CurrentRent.ID);
        }
        private void saveButton_Click(object sender, EventArgs e)//сохранение в файл
        {
            if (clientFIO.Text == "" || objectBox.Text == "" || priceBox.Text == "" ||
                depositBox.Text == "" || addressesBox.Text == "" || secondAddressBox.Text == ""||
                statusBox.Text == "" || measureBox.Text == "" )
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Заполнены не все поля");
                MessageBox.Show("Для сохранения заполните все поля формы.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Data.Objects.FindByName(objectBox.Text).InStock == 0 && Data.CurrentRent.ClientFIO ==null)
            {
                MessageBox.Show("На складе не осталось данного товара.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Data.Objects.FindByName(objectBox.Text).InStock == 0 && srent.Name != Data.Objects.FindByName(objectBox.Text).Name)
            {
                MessageBox.Show("На складе не осталось данного товара.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveThisForm();
                svd = false;
                Data.Status = false;
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
                MessageBox.Show("Данные успешно изменены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                RentView rentView = this.Owner as RentView;
                if (rentView != null) rentView.Close();
            }
        }
        private void Calculator(object sender, EventArgs e)
        {
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
            try
            {
                if (Data.Settings.Round == 0)
                {
                    cost.Text = ((decimal.Parse(priceBox.Text) * (Math.Ceiling(numericUpDown.Value))) + p).ToString() + " рублей";
                }
                if (Data.Settings.Round == 1)
                {
                    cost.Text = ((decimal.Parse(priceBox.Text) * (Math.Round(numericUpDown.Value))) + p).ToString() + " рублей";
                }
                if (Data.Settings.Round == 2)
                {
                    cost.Text = ((decimal.Parse(priceBox.Text) * (Math.Floor(numericUpDown.Value))) + p).ToString() + " рублей";
                }
                if (Data.Settings.Round == 3)
                {
                    cost.Text = ((decimal.Parse(priceBox.Text) * numericUpDown.Value) + p).ToString() + " рублей";
                }
            }
            catch { cost.Text = "0 рублей"; }
        }
        private void CarPic(object sender, EventArgs e)// +  рекомендованная цена
        {
            string name = objectBox.Text;
            try { pictureBox1.Image = System.Drawing.Image.FromFile(Data.Storage + $"DB/Pics/{name}.jpg"); } 
            catch {  }
            try 
            {
                if (Data.Settings.BoolSettings[0])
                {
                    priceBox.Text = Data.Objects.FindByName(name).Price.ToString();
                    measureBox.Text = Data.Objects.FindByName(name).Measure;
                    numericUpDown.Value = Data.Objects.FindByName(name).MinT;
                }
                else
                {
                    numericUpDown.Value = 1;
                }
                inStockBox.Text = Data.Objects.FindByName(name).InStock.ToString();
            } 
            catch { }
             

        }
        private void pricesBox_KeyPress(object sender, KeyPressEventArgs e)//вводить только числа
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void periodsBox_KeyPress(object sender, KeyPressEventArgs e)//вводить только числа
        {
            pricesBox_KeyPress(sender, e);
        }
        private void BoundPrice(object sender, EventArgs e)//контроль ввода цены
        {
            try
            {
                string name = objectBox.GetItemText(objectBox.SelectedItem);
                decimal recomP = Data.Objects.FindByName(name).Price / 2;
                decimal pr;
                try { pr = decimal.Parse(priceBox.Text); } catch { pr = 0; }
                if (pr < recomP)
                {
                    MainForm.stStrip.Items.Clear();
                    MainForm.stStrip.Items.Add("Введены неверные данные");
                    MessageBox.Show("Вы ввели слишком низкую цену!", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    priceBox.Text = Data.Objects.FindByName(name).Price.ToString();
                }
            }
            catch { }
        }
        private void RentEdit_FormClosed(object sender, FormClosedEventArgs e)//изменения в форму родителя
        {
            pictureBox1.Image.Dispose();
            Data.Rents.AllRents.Reverse();
            Data.Rents.SavedRents.Reverse();
            try
            {
                RentView rentView = this.Owner as RentView;
                if (srent != null && srent.Equals(Data.CurrentRent))
                {
                    svd = false;

                }
                if (clientFIO.Text == "" || objectBox.Text == "" || priceBox.Text == "" ||
                    depositBox.Text == "" || addressesBox.Text == "" || svd)
                {
                    Data.Rents.DelRent(Data.CurrentRent);
                }
                else
                {
                    rentView.FillForm(Data.CurrentRent);

                }
            }
            catch
            {
                MainForm mainForm = this.Owner as MainForm;
                mainForm.FillRents();

            }
            srent = null;
            svd = true;
        }
        private void measureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "часов")
            {
                objectMeasureLabel.Text = "в час";
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddHours((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 48;

            }
            if (measureBox.Text == "дней")
            {
                objectMeasureLabel.Text = "в день";
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddDays((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 60;

            }
            if (measureBox.Text == "месяцев")
            {
                objectMeasureLabel.Text = "в месяц";
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddMonths((int)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                if (Data.Settings.BoolSettings[1]) numericUpDown.Maximum = 12;

            }
            Calculator(sender, e);
        }

        private void addressesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondAddressBox.Text == "" || addressesBox.Items.Contains(secondAddressBox.Text))
            {
                secondAddressBox.Text = addressesBox.Text;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "часов")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddHours((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
            if (measureBox.Text == "дней")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddDays((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
            if (measureBox.Text == "месяцев")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddMonths((int)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
            if(numericUpDown.Value > numericUpDown.Maximum)
            {
                MessageBox.Show("Значение превышает максимальный срок аренды.");
            }
            if (numericUpDown.Value < numericUpDown.Minimum)
            {
                MessageBox.Show("Значение меньше минимального срока аренды.");
            }
            try
            {
                if (numericUpDown.Value > Data.Objects.FindByName(objectBox.Text).MaxT)
                {
                    MessageBox.Show("Значение превышает максимальный срок аренды.");
                    numericUpDown.Value = Data.Objects.FindByName(objectBox.Text).MaxT;
                }
                if (numericUpDown.Value < Data.Objects.FindByName(objectBox.Text).MinT)
                {
                    MessageBox.Show("Значение меньше минимального срока аренды.");
                    numericUpDown.Value = Data.Objects.FindByName(objectBox.Text).MinT;


                }
            }
            catch { }
            Calculator(sender, e);
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            datePicker1.Value = DateTime.Now;
            hoursBox.Value = DateTime.Now.Hour;
            minutesBox.Value = DateTime.Now.Minute;
        }

        private void hoursBox_ValueChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "часов")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddHours((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
            if (measureBox.Text == "дней")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddDays((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
            if (measureBox.Text == "месяцев")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddMonths((int)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
        }

        private void minutesBox_ValueChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "часов")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddHours((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
            if (measureBox.Text == "дней")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddDays((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
            if (measureBox.Text == "месяцев")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddMonths((int)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate; 
                datePicker1.Value = datePicker1.Value.AddHours(-datePicker1.Value.Hour).AddMinutes(-datePicker1.Value.Minute);
                datePicker1.Value = datePicker1.Value.AddHours((double)hoursBox.Value).AddMinutes((double)minutesBox.Value);
            }
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "часов")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddHours((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
            if (measureBox.Text == "дней")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddDays((double)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
            if (measureBox.Text == "месяцев")
            {
                DateTime nDate = new DateTime();
                nDate = datePicker1.Value.AddMonths((int)numericUpDown.Value);
                datePicker2.Value = nDate;
                timePicker2.Value = nDate;
            }
        }

        private void RentEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    RentView rentView = this.Owner as RentView;
                    rentView.Close();
                }
                catch
                {
                }
                try
                {
                    RentView rentView = this.Owner as RentView;
                    RentsList rList = rentView.Owner as RentsList;
                    ObjectView objectView = rList.Owner as ObjectView;
                    ObjectsList objList = objectView.Owner as ObjectsList;
                    rentView.Close();
                    rList.Close();
                    objectView.Close();
                    objList.Close();
                }
                catch
                {

                }
            }
        }

        private void numericUpDown_VisibleChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Value > numericUpDown.Maximum)
            {
                MessageBox.Show("Значение превышает максимальный срок аренды.");
            }
            if (numericUpDown.Value < numericUpDown.Minimum)
            {
                MessageBox.Show("Значение меньше минимального срока аренды.");
            }
        }

        private void moneyB_CheckedChanged(object sender, EventArgs e)
        {
            if (moneyB.Checked)
            {
                depositBox.KeyPress += pricesBox_KeyPress;
            }
            else
            {
                depositBox.KeyPress -= pricesBox_KeyPress;
            }
        }
    }
}
