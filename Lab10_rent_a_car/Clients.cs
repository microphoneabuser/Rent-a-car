using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    class Clients
    {
        List<Client> allClients = new List<Client>();
        List<Client> savedClients;
        public Clients()
        {
            allClients = new List<Client>();
            savedClients = new List<Client>();
        }
        public void AddClient(Client client) { allClients.Add(client); if (client.Saved){ savedClients.Add(client); } }
        public void DelClient(Client client) { allClients.Remove(client); if (client.Saved) { savedClients.Remove(client); } }

        public List<Client> AllClients { get { return allClients; } }
        public List<Client> SavedClients { get { return savedClients; } }
        public Client FindByFIO(string fio)//метод для нахождения клиента по id
        {
            return allClients.Find(x => x.FIO == fio);
        }
        public void SaveClients()//сохранение данных всех клиентов в xml-файл
        {
            FileOperations.SaveClients(allClients);
        }
        public void ReplaceInfoClient(Client client)//метод для обновления информации 
        {
            int index = allClients.FindIndex(x => x.FIO == client.FIO);
            allClients[index] = client;
        }
    }
    class Client
    {
        private string fio; private string passport;
        private string license; private string category;
        private string address; private bool saved;
        private List<int> rents;
        public Client()
        {

        }
        public Client (string fio, string passport, string license, string category, string address,bool saved, List<int> rents)
        {
            this.fio = fio; this.passport = passport;
            this.license = license; this.category = category;
            this.address = address; this.saved = saved;
            this.rents = rents;
        }
        public string FIO { get { return fio; } set { fio = value; } }
        public string Passport { get { return passport; } set { passport = value; } }
        public string License { get { return license; } set { license = value; } }
        public string Category { get { return category; } set { category = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool Saved { get { return saved; } set { saved = value; } }
        public List<int> Rents { get { return rents; } set { rents = value; } }
    }
}
