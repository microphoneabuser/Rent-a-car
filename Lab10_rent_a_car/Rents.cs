using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    class Rents
    {
        List<Rent> allRents;
        List<Rent> savedRents;
        public int Count { get; set; }
        public Rents()
        {
            allRents = new List<Rent>();
            savedRents = new List<Rent>();
        }
        public List<Rent> AllRents { get { return allRents; } }
        public List<Rent> SavedRents { get { return savedRents; } }
        public Rent FindByID(int id)//метод для нахождения клиента по id
        {
            return allRents.Find(x => x.ID == id);
        }
        public void SaveRents()//сохранение данных всех клиентов в xml-файл
        {
            FileOperations.SaveRents(allRents);
        }
        public void AddRent(Rent rent) 
        { 
            allRents.Add(rent);
            if(rent.Saved) { Count++; savedRents.Add(rent); }
        }//метод добавления клиента в список
        public void DelRent(Rent rent) 
        { 
            allRents.Remove(rent);
            if (rent.Saved) { Count--; savedRents.Remove(rent); }
        }
        public void ReplaceInfoRent(Rent rent)//метод для обновления информации 
        {
            int index = allRents.FindIndex(x => x.ID == rent.ID);
            allRents[index] = rent;
            if (rent.Saved) {
                int ind = savedRents.FindIndex(x => x.ID == rent.ID);
                if (ind<savedRents.Count ||ind == -1) { savedRents[ind] = rent; } }
        }
        public int GetMaxID()//получение максимального значения id
        {
            int max = 0;
            foreach (Rent rent in allRents)
            {
                if (max < rent.ID) max = rent.ID;
            }
            return max;
        }
    }
    class Rent
    {
        private int id;
        private string clientFIO;
        private string name;
        private decimal price;
        private string depositType;
        private decimal depositMoney;
        private string deposit;
        private double period;
        private string measure;
        private string compAddress;
        private string secondAddress;
        private bool saved;
        private DateTime dateTime;
        private string status;
        private string description;
        private List<int> addServices = new List<int>();
        public Rent (int id)
        {
            this.id = id;
        }
        public Rent (int id, string clientFIO, string name, decimal price, string depositType,
            decimal depositMoney, string deposit , double period, string measure, string compAddress, 
            string secondAddress, List<int> addservices, bool saved, DateTime dateTime, string status, string description)
        {
            this.id = id;
            this.clientFIO = clientFIO;
            this.name = name;
            this.price = price;
            this.depositType = depositType;
            this.depositMoney = depositMoney;
            this.deposit = deposit;
            this.period = period;
            this.measure = measure;
            this.compAddress = compAddress;
            this.secondAddress = secondAddress;
            this.addServices = addservices;
            this.saved = saved;
            this.dateTime = dateTime;
            this.status = status;
            this.description = description;
        }
        public int ID { get { return id; } set { id = value; } }
        public string ClientFIO { get { return clientFIO; } set { clientFIO = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Period { get { return period; } set { period = value; } }
        public string Measure { get { return measure; } set { measure = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public string DepositType { get { return depositType; } set { depositType = value; } }
        public string Deposit { get { return deposit; } set { deposit = value; } }
        public decimal DepositMoney { get { return depositMoney; } set { depositMoney = value; } }
        public string CompAddress { get { return compAddress; } set { compAddress = value; } }
        public string SecondAddress { get { return secondAddress; } set { secondAddress = value; } }
        public List<int> AddServices { get { return addServices; } set { addServices = value; } }
        public bool Saved { get { return saved; } set { saved = value; } }
        public DateTime DateTime { get { return dateTime; } set { dateTime = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string AddServicesString
        {
            get
            {
                string str = "";
                try
                {
                    foreach (int elem in addServices)
                    {
                        str += elem + ",";
                    }
                    str = str.Substring(0, str.Length - 1);
                }
                catch { }
                return str;
            }
        }
        public string GetTotalPrice(AddServices addServices)
        {
            string cost = "";
            decimal p = 0m;
            foreach (int elem in this.addServices)
            {
                try
                {
                    AddService adds = addServices.FindByID(elem);
                    p += adds.Price;
                }
                catch
                {
                }
            }
            cost = (this.Price * decimal.Parse(this.Period.ToString()) + p).ToString() + " рублей";
            return cost;
        }
    }
    class Addresses//класс в котором содержатся адреса компании 
    {
        List<Address> allAddresses;
        public Addresses()
        {
            allAddresses = new List<Address>();
        }
        public void AddAddress(Address address) { allAddresses.Add(address); }
        public List <Address> AllAddresses { get { return allAddresses; } }
        public void SaveAddresses() { FileOperations.SaveAddresses(allAddresses); }
        public Address FindByName(string name)//метод для нахождения клиента по id
        {
            return allAddresses.Find(x => x.Name == name);
        }
    }
    class Address
    {
        string name;
        bool deleted;
        public Address(string name, bool deleted)
        {
            this.name = name;
            this.deleted = deleted;
        }
        public Address()
        {
        }
        public string Name { get { return name; } set { name = value; } }
        public bool Deleted { get { return deleted; } set { deleted = value; } }
    }
}