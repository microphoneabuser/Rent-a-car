using System.Collections.Generic;
using System.Xml;

namespace Lab10_rent_a_car
{
    class AddServices
    {
        List<AddService> allServices;
        public AddServices()
        {
            allServices = new List<AddService>();
        }
        public void AddService(AddService service) { allServices.Add(service); }
        public AddService FindByName(string name){ return allServices.Find(x => x.Name == name); }
        public AddService FindByID(int id) { return allServices.Find(x => x.ID == id); }
        public List<AddService> AllServices { get { return allServices; } }
        public void SaveServices()//сохранение данных всех клиентов в xml-файл
        {
            FileOperations.SaveAddServices(allServices);
        }
        public void DelService(AddService addService) { allServices.Remove(addService); }
        public void ReplaceInfoService(AddService addService)//метод для обновления информации 
        {
            int index = allServices.FindIndex(x => x.ID == addService.ID);
            allServices[index] = addService;
        }
        public int GetMaxID()//получение максимального значения id
        {
            int max = 0;
            foreach (AddService addService in allServices)
            {
                if (max < addService.ID) max = addService.ID;
            }
            return max;
        }
    }
    class AddService
    {
        private int id;
        private string name;
        private decimal price;
        private bool deleted;
        public AddService(int id)
        {
            this.id = id;
        }
        public AddService(int id, string name, decimal price, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.deleted = deleted;
        }
        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price{ get { return price; } set { price = value; } }
        public bool Deleted {  get { return deleted; } set { deleted = value; } }
    }
}
