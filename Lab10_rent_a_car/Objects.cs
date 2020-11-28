using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    class Objects
    {
        List<Object> allObjects;
        public Objects()
        {
            allObjects = new List<Object>();
        }
        public void AddObject(Object obj) { allObjects.Add(obj); }
        public List<Object> AllObjects { get { return allObjects; } }
        public void SaveObjects()//сохранение данных всех клиентов в xml-файл
        {
            FileOperations.SaveObjects(allObjects);
        }
        public void DelObject(Object obj) { allObjects.Remove(obj); }
        public void ReplaceInfoObject(Object obj)//метод для обновления информации 
        {
            int index = allObjects.FindIndex(x => x.ID == obj.ID);
            allObjects[index] = obj;
        }
        public int GetMaxID()//получение максимального значения id
        {
            int max = 0;
            foreach (Object obj in allObjects)
            {
                if (max < obj.ID) max = obj.ID;
            }
            return max;
        }
        public Object FindByName(string name)//метод для нахождения клиента по id
        {
            return allObjects.Find(x => x.Name == name);
        }
    }
    class Object
    {
        private int id; private string name;
        private string num; private decimal price;
        private decimal mdeposit;
        private bool deleted; private int quantity; private int inRent;
        private int inStock; private int repair;
        private int minT; private int maxT;
        private string description; private string damage; private string measure;
        private List<int> rents;
        public Object() { }
        public Object(int id, string name, string num, decimal price, decimal mdeposit,
            bool deleted, int quantity, int inRent, int inStock, int repair, 
            int minT, int maxT, string description, string damage, string measure, List<int> rents) 
        {
            this.id = id;this.name = name;this.num = num;
            this.price = price; this.mdeposit = mdeposit;
            this.deleted = deleted; this.quantity = quantity; this.inRent = inRent;
            this.inStock = inStock; this.repair = repair; this.minT = minT; this.maxT = maxT;
            this.description = description; this.damage = damage; this.measure = measure;
            this.rents = rents;
        }
        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Num { get { return num; } set { num = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public decimal Mdeposit { get {return mdeposit; } set { mdeposit = value; } }
        public bool Deleted { get { return deleted; } set { deleted = value; } }
        public int Quantity { get { return quantity; } set {quantity = value; } }
        public int InRent { get { return inRent; } set {inRent = value; } }
        public int InStock { get { return inStock; } set { inStock = value; } }
        public int Repair { get { return repair; } set { repair = value; } }
        public int MinT { get { return minT; } set { minT = value; } }
        public int MaxT { get { return maxT; } set { maxT = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Damage { get { return damage; } set { damage = value; } }
        public string Measure { get { return measure; } set { measure = value; } }
        public List<int> Rents { get { return rents; }set { rents = value; } }
        
    }

}
