using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab10_rent_a_car
{
    public partial class MainForm : Form
    {
        public static StatusStrip stStrip;
        public MainForm()
        {
            InitializeComponent();
            //чтение всех данных с файла
            Data.Storage = FileOperations.GetStorage();


            Data.Rents = FileOperations.ReadRents();
            Data.AddServices = FileOperations.ReadServices();
            Data.Addresses = FileOperations.ReadAddresses();
            //Data.Cars = FileOperations.ReadCars();
            Data.Objects = FileOperations.ReadObjects();
            Data.Clients = FileOperations.ReadClients();
            Data.Settings = FileOperations.ReadSettings();
            Data.Status = true;

            Data.Rents.SavedRents.Reverse();
            Data.Rents.AllRents.Reverse();

            BuildNotifyIcon();
            rentsPagesBox.SelectedItem = "50";
            clientsPagesBox.SelectedItem = "50";
            stStrip = statusStrip;
            rentStatusBox.Text = "Все";
        }
        private void BuildNotifyIcon()//инициализация NotifyIcon
        {
            this.ShowInTaskbar = true;
            notifyIcon.ContextMenuStrip = contextMenu;
        }
        internal void MainForm_Load(object sender, EventArgs e)//заполнение формы
        {

            FillRents();
            FillClients();
        }
        int firstRentIndex = 0;
        int lastRentIndex = 0;



        internal void FillRents()//запонения таблицы с арендами
        {
            
            if (rentStatusBox.Text == "Все")
            {
                nextRentButton.Enabled = true;
                prevRentButton.Enabled = true;
                rentsPagesBox.Enabled = true;
                int i = 0;
                RentsGrid.Rows.Clear();


                foreach (Rent rent in Data.Rents.SavedRents)//перебор всех аренд для заполнения
                {
                    if (i < int.Parse(rentsPagesBox.Text))
                    {
                        if (RentsGrid.Rows.Count < Data.Rents.SavedRents.Count) { RentsGrid.Rows.Add(); }
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
                        RentsGrid.Rows[i].Cells[j].Value = rent.Status; j++;
                        i++;
                        lastRentIndex = i;
                    }
                }
                if (!Data.Status) { this.Text = "Аренда*"; }
                else this.Text = "Аренда";
            }
            if (rentStatusBox.Text == "Активные" || rentStatusBox.Text == "Забронированные" || rentStatusBox.Text == "Завершенные"
                || rentStatusBox.Text == "Отмененные")
            {
                nextRentButton.Enabled = false;
                prevRentButton.Enabled = false;
                rentsPagesBox.Enabled = false;
                string st = "";
                if (rentStatusBox.Text == "Активные") { st = "Активная"; }
                if (rentStatusBox.Text == "Забронированные") { st = "Забронирована"; }
                if (rentStatusBox.Text == "Завершенные") { st = "Завершена"; }
                if (rentStatusBox.Text == "Отмененные") { st = "Отменена"; }
                int i = 0;
                RentsGrid.Rows.Clear(); 




                foreach (Rent rent in Data.Rents.SavedRents)//перебор всех аренд для заполнения
                {
                    if (rent.Status == st)
                    {
                        if (RentsGrid.Rows.Count < Data.Rents.SavedRents.Count) { RentsGrid.Rows.Add(); }
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
                        RentsGrid.Rows[i].Cells[j].Value = rent.Status; j++;
                        i++;
                        lastRentIndex = rent.ID;
                    }
                }
                if (!Data.Status) { this.Text = "Аренда*"; }
                else this.Text = "Аренда";
            }
            //RentsGrid.Sort( rentsID, System.ComponentModel.ListSortDirection.Descending);
        }

        
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (rentStatusBox.Text == "Все")
            {
                if (Data.Rents.SavedRents.Count > lastRentIndex)
                {
                    RentsGrid.Rows.Clear();
                    int i = 0;
                    int k;
                    firstRentIndex = lastRentIndex - int.Parse(rentsPagesBox.Text);
                    for (k = lastRentIndex; k < lastRentIndex + int.Parse(rentsPagesBox.Text); k++)
                    {
                        if (k < Data.Rents.SavedRents.Count)
                        {
                            RentsGrid.Rows.Add();
                            int j = 0;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].ID; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].ClientFIO; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].Name; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.ToString(); j++;
                            if (Data.Rents.SavedRents[k].Measure == "дней")
                            {
                                RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.AddDays(Data.Rents.SavedRents[k].Period).ToString();
                            }
                            if (Data.Rents.SavedRents[k].Measure == "часов")
                            {
                                DateTime nDate = Data.Rents.SavedRents[k].DateTime.AddHours(Data.Rents.SavedRents[k].Period);
                                RentsGrid.Rows[i].Cells[j].Value = nDate.ToString();
                            }
                            if (Data.Rents.SavedRents[k].Measure == "месяцев")
                            {
                                RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.AddMonths((int)Data.Rents.SavedRents[k].Period).ToString();
                            }
                            j++;
                            RentsGrid.Rows[i].Cells[j].Value = $"{Data.Rents.SavedRents[k].Period} {Data.Rents.SavedRents[k].Measure}"; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].CompAddress; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].Status; j++;
                            i++;
                        }
                    }
                    lastRentIndex = k;
                }
            }

        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            if (rentStatusBox.Text == "Все")
            {
                if (firstRentIndex >= 0)
                {
                    RentsGrid.Rows.Clear();
                    int i = 0;
                    int k;
                    lastRentIndex = firstRentIndex + int.Parse(rentsPagesBox.Text);
                    for (k = firstRentIndex; k < lastRentIndex; k++)
                    {
                        if (k < Data.Rents.SavedRents.Count && Data.Rents.SavedRents[k] != null)
                        {
                            RentsGrid.Rows.Add();
                            int j = 0;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].ID; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].ClientFIO; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].Name; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.ToString(); j++;
                            if (Data.Rents.SavedRents[k].Measure == "дней")
                            {
                                RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.AddDays(Data.Rents.SavedRents[k].Period).ToString();
                            }
                            if (Data.Rents.SavedRents[k].Measure == "часов")
                            {
                                DateTime nDate = Data.Rents.SavedRents[k].DateTime.AddHours(Data.Rents.SavedRents[k].Period);
                                RentsGrid.Rows[i].Cells[j].Value = nDate.ToString();
                            }
                            if (Data.Rents.SavedRents[k].Measure == "месяцев")
                            {
                                RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].DateTime.AddMonths((int)Data.Rents.SavedRents[k].Period).ToString();
                            }
                            j++;
                            RentsGrid.Rows[i].Cells[j].Value = $"{Data.Rents.SavedRents[k].Period} {Data.Rents.SavedRents[k].Measure}"; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].CompAddress; j++;
                            RentsGrid.Rows[i].Cells[j].Value = Data.Rents.SavedRents[k].Status; j++;
                            i++;
                        }
                    }
                    firstRentIndex -= int.Parse(rentsPagesBox.Text);
                }
            }
        }
        int firstClientIndex = 0;
        int lastClientIndex = 0;
        internal void FillClients()//запонение таблицы клиентов
        {
            int i = 0;
            ClientsGrid.Rows.Clear();
            foreach (Client client in Data.Clients.SavedClients)
            {
                if (i < int.Parse(clientsPagesBox.Text))
                {
                    ClientsGrid.Rows.Add();
                    int j = 0;
                    ClientsGrid.Rows[i].Cells[j].Value = client.FIO; j++;
                    ClientsGrid.Rows[i].Cells[j].Value = client.Passport; j++;
                    ClientsGrid.Rows[i].Cells[j].Value = client.License; j++;
                    ClientsGrid.Rows[i].Cells[j].Value = client.Category; j++;
                    ClientsGrid.Rows[i].Cells[j].Value = client.Address; j++;
                    i++;
                    lastClientIndex = i;
                }
            }
            if (!Data.Status) { this.Text = "Аренда*"; }
            else { this.Text = "Аренда"; }
            ClientsGrid.Sort( FIO, System.ComponentModel.ListSortDirection.Ascending);

        }
        private void prevClientButton_Click(object sender, EventArgs e)
        {
            if (firstClientIndex >= 0)
            {
                ClientsGrid.Rows.Clear();
                int i = 0;
                int k;
                lastClientIndex = firstClientIndex + int.Parse(clientsPagesBox.Text);
                for (k = firstClientIndex; k < lastClientIndex; k++)
                {
                    try
                    {
                        ClientsGrid.Rows.Add();
                        int j = 0;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].FIO; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Passport; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].License; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Category; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Address; j++;
                        i++;
                    }
                    catch { ClientsGrid.Rows.RemoveAt(ClientsGrid.Rows.Count - 1); }
                }
                firstClientIndex -= int.Parse(clientsPagesBox.Text);
            }
        }

        private void nextClientButton_Click(object sender, EventArgs e)
        {
            if (Data.Clients.SavedClients.Count > lastClientIndex)
            {
                ClientsGrid.Rows.Clear();
                int i = 0;
                int k;
                firstClientIndex = lastClientIndex - int.Parse(clientsPagesBox.Text);
                for (k = lastClientIndex; k < lastClientIndex + int.Parse(clientsPagesBox.Text); k++)
                {
                    try
                    {
                        ClientsGrid.Rows.Add();
                        int j = 0;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].FIO; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Passport; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].License; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Category; j++;
                        ClientsGrid.Rows[i].Cells[j].Value = Data.Clients.SavedClients[k].Address; j++;
                        i++;
                    }
                    catch { ClientsGrid.Rows.RemoveAt(ClientsGrid.Rows.Count - 1); }
                }
                lastClientIndex = k;
            }
        }

        
        private void CarsMenuBox_Click(object sender, EventArgs e)//открытие таблицы машин
        {
            if (Users.CurrentUser.Status == "admin")
            {
                ObjectsList carsList = new ObjectsList();
                carsList.Owner = this;
                carsList.ShowDialog();
            }
            else
                MessageBox.Show("Доступ ограничен вашим статусом");
        }

        private void AddressesMenuBox_Click(object sender, EventArgs e)//открытие таблицы адресов компании
        {
            if (Users.CurrentUser.Status == "admin") 
            {
                AddressesList addressesList = new AddressesList();
                addressesList.Owner = this;
                addressesList.ShowDialog();
            }
            else
                MessageBox.Show("Доступ ограничен вашим статусом");
        }

        private void ServicesMenuBox_Click(object sender, EventArgs e)//открытие таблицы доп.сервисов
        {
            if(Users.CurrentUser.Status == "admin")
            {
                AddServicesList servicesList = new AddServicesList();
                servicesList.Owner = this;
                servicesList.ShowDialog();
            }
            else
                MessageBox.Show("Доступ ограничен вашим статусом");
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
                rentView.ShowDialog();//открытие формы просмотра аренды
            }
        }
        private void newRent_Click(object sender, EventArgs e)
        {
            Data.CurrentRent = new Rent(Data.Rents.GetMaxID() + 1);//новая аренда
            RentEdit rentEdit = new RentEdit();
            rentEdit.Owner = this;
            rentEdit.Show();
        }
        private void ClientsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string fio = "";
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                //подготовка формы клиента
                fio = ClientsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Data.CurrentClient = Data.Clients.FindByFIO(fio);
                ClientView clientView = new ClientView();
                clientView.Owner = this;
                clientView.ShowDialog();//открытие формы просмотра клиента
            }
        }
        private void newClient_Click(object sender, EventArgs e)
        {
            ClientEdit clientEdit = new ClientEdit();
            clientEdit.Owner = this;
            clientEdit.ShowDialog();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)//сохранение данных
        {
            try
            {
                Data.Rents.AllRents.Reverse();
                Data.Rents.SavedRents.Reverse();
                FileOperations.SaveStorage(Data.Storage);
                Data.Rents.SaveRents(); Data.Clients.SaveClients();
                Data.Objects.SaveObjects(); Data.AddServices.SaveServices();
                Data.Addresses.SaveAddresses(); Data.Settings.SaveSettings();
                Data.Status = true; this.Text = "Аренда";
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Данные успешно сохранены");
                Data.Rents.AllRents.Reverse();
                Data.Rents.SavedRents.Reverse();
            }
            catch
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Ошибка сохранения");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)//открытие формы настроек
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void saveTimer_Tick(object sender, EventArgs e)//таймер сохранения
        {
            try { SaveToolStripMenuItem_Click(sender, e); } 
            catch 
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Ошибка сохранения");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//проверка на сохранение
        {
            if (!Data.Status)
            {
                if (MessageBox.Show("Вы точно хотите закрыть программу без сохранения изменений?", "!!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else { e.Cancel = true; }
            }
            this.ShowInTaskbar = false;
        }

        private void saveItem_Click(object sender, EventArgs e)//сохранение через notify icon
        {
            SaveToolStripMenuItem_Click(sender, e);
        }

        private void settingsItem_Click(object sender, EventArgs e)//открытие настроек через notify icon
        {
            settingsToolStripMenuItem_Click(sender, e);
        }

        private void aboutItem_Click(object sender, EventArgs e)//о программе через notify icon
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitItem_Click(object sender, EventArgs e)//выход через notify icon
        {
            this.Close();
        }

        private void pagesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRents();
        }
        private void clientsPageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClients();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Users.CurrentUser.Status == "admin")
            {
                UsersList usersList = new UsersList();
                usersList.Owner = this;
                usersList.ShowDialog();
            }
            else
                MessageBox.Show("Доступ ограничен вашим статусом");
        }

        private void rentStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRents();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f != this)
                    {
                        f.Close();
                    }
                }
            }
        }
    }
}
