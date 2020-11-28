using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab10_rent_a_car
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        string currentFio;
        public ClientForm(string currentFio)//конструктор для открытия формы уже существующего клиента
        {
            InitializeComponent();
            this.currentFio = currentFio;
        }
        Clients clients;
        Cars cars;
        AddServices addServices;
        int currentId;
        private void ClientForm_Load(object sender, EventArgs e)//загрузка формы клиента
        {
            clients = new Clients();
            cars = new Cars();
            addServices = new AddServices();
            BuildCarsBox();//заполнение списка машин
            BuildPriceBox();//заполнение списка цен
            BuildDepositsBox();//запонение списка залогов
            BuildPeriodsBox();//заполнение времени аренды 
            BuildAddressesBox();//заполнение списка адресов
            BuildAddServicesListBox();//заполнение списка доп.услуг
            if (currentFio!=null)//заполнение формы существующего клиента
            {
                Client currentClient = clients.findByFIO(currentFio);
                FillForm(currentClient);
            }
            else//при пустом списке клиентов
            {
                Client newClient = new Client(1);
            }
        }
        private void FillForm(Client client)//заполнение формы клиента
        {
            currentId = client.ID;
            clientFIO.Text = client.FIO;
            carsBox.SelectedIndex = carsBox.FindStringExact(client.CarModel);
            pricesBox.SelectedIndex = pricesBox.FindStringExact(client.CarPrice.ToString());
            depositsBox.SelectedIndex = depositsBox.FindStringExact(client.Deposit.ToString());
            periodsBox.SelectedIndex = periodsBox.FindStringExact(client.Period.ToString());
            addressesBox.SelectedIndex = addressesBox.FindStringExact(client.Address);
            for (int i = 0; i < addServicesListBox.Items.Count; i++)//простановка галочек в листбоксе
            {
                if (client.AddServices.Contains(i)){ addServicesListBox.SetItemChecked(i, true); }
                else{ addServicesListBox.SetItemChecked(i, false); }
            }
            this.Text = "Клиент №" + client.ID.ToString();
        }
        private void BuildCarsBox()//заполнение списка машин
        {
            foreach (Car car in cars.GetAllCars())
            {
                carsBox.Items.Add(car.Model);
            }
        }
        private void BuildPriceBox()//заполнение списка цен
        {
            foreach (Car car in cars.GetAllCars())
            {
                pricesBox.Items.Add(car.Price);
            }
        }
        private void BuildDepositsBox()//заполнение списка залогов
        {
            foreach (Car car in cars.GetAllCars())
            {
                depositsBox.Items.Add(car.Deposit);
            }
        }
        private void BuildPeriodsBox()//заполнение списка сроков
        {
            for (int i = 1;i <= 31; i++)
            {
                periodsBox.Items.Add(i);
            }
        }
        private void BuildAddressesBox()//заполнение списка адресов
        {
            int i = 0;
            foreach (Car car in cars.GetAllCars())
            {
                addressesBox.Items.Add(car.Address);
                i++;
                if (i == 2) { break; }
            }
        }
        private void BuildAddServicesListBox()//заполнение списка листбокса доп.услуг
        {
            foreach (AddService add in addServices.GetAddServices())
            {
                addServicesListBox.Items.Add(add.Name);
            }
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            Client client = clients.findByID(currentId);
            client.FIO = clientFIO.Text;
            client.CarModel = carsBox.GetItemText(carsBox.SelectedItem);
            client.CarPrice = int.Parse(pricesBox.GetItemText(pricesBox.SelectedItem));
            client.Deposit = int.Parse(depositsBox.GetItemText(depositsBox.SelectedItem));
            client.Address = addressesBox.GetItemText(addressesBox.SelectedItem);
            client.Period = int.Parse(periodsBox.GetItemText(periodsBox.SelectedItem));
            List<int> list = new List<int>();
            client.AddServices = list;
            foreach (string elem in addServicesListBox.CheckedItems)
            {
                AddService ads = addServices.FindByName(elem);
                client.AddServices.Add(ads.ID);
            }
            clients.ReplaceInfoClient(client);
        }

        private void saveButton_Click(object sender, EventArgs e)//сохранение в файл
        {
            SaveThisForm();
            clients.saveClients();
        }
        private void deleteClient_Click(object sender, EventArgs e)//удаление клиента и открытие формы другого клиента
        {
            Client client = clients.findByID(currentId);
            Client next = clients.GetNext(currentId);
            if (next.ID == currentId) 
            {
                next = clients.GetPrevious(currentId);
                if (next.ID == currentId)
                {
                    int ID = clients.GetMaxID() + 1;
                    next = new Client(ID);
                    clients.AddClient(next);
                }
            }
            clients.DelClient(client);
            FillForm(next);
        }

        private void newClient_Click(object sender, EventArgs e)//создание нового клиента
        {
            SaveThisForm();
            int id = clients.GetMaxID() + 1;
            Client client = new Client(id);
            clients.AddClient(client);
            FillForm(client);
            clientFIO.Text = "";
            carsBox.SelectedIndex = 0;
            pricesBox.SelectedIndex = 0;
            depositsBox.SelectedIndex = 0;
            periodsBox.SelectedIndex = 0;
            addressesBox.SelectedIndex = 0;
            addServicesListBox.ClearSelected();
        }

        private void next_Click(object sender, EventArgs e)//перемещение к след.клиенту
        {
            SaveThisForm();
            Client client = clients.GetNext(currentId);
            FillForm(client);
        }

        private void previous_Click(object sender, EventArgs e)//перемещение к предыдущему клиенту 
        {
            SaveThisForm();
            Client client = clients.GetPrevious(currentId);
            FillForm(client);
        }

        private void backToListButton_Click(object sender, EventArgs e)//возвращение к списку клиентов
        {
            this.Hide();
            ClientsList clientsList = new ClientsList();
            clientsList.ShowDialog();
            this.Show();
            Close();
        }

        private void calcButton_Click(object sender, EventArgs e)//подсчет общей суммы для оплаты
        {
            List<AddService> ads = addServices.GetAddServices();
            int p = 0;                
            foreach (string elem in addServicesListBox.CheckedItems)
            {
                AddService adds = addServices.FindByName(elem);
                p += adds.Price;
            }
            cost.Text = ((int.Parse(pricesBox.GetItemText(pricesBox.SelectedItem)) *
               int.Parse(periodsBox.GetItemText(periodsBox.SelectedItem))) + p).ToString() + " рублей";
        }
        private void ClientForm_MouseMove(object sender, MouseEventArgs e)//картинка машины
        {
            string nameModel = carsBox.GetItemText(carsBox.SelectedItem);
            carPic.Image = System.Drawing.Image.FromFile($"Pics/{nameModel}.jpg");
        }

        private void pricesBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void depositsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            pricesBox_KeyPress(sender, e);
        }

        private void periodsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            pricesBox_KeyPress(sender, e);
        }
    }
}
