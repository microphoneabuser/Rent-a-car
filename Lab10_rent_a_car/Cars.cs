using System.Collections.Generic;
using System.Xml;

namespace Lab10_rent_a_car
{
    class Cars
    {
        List<Car> allCars;
        public Cars()
        {
            allCars = new List<Car>();
        }
        public void AddCar(Car car) { allCars.Add(car); }
        public List<Car> AllCars { get { return allCars; } }
        public void SaveCars()//сохранение данных всех клиентов в xml-файл
        {
            //FileOperations.SaveCars(allCars);
        }
        public void DelCar(Car car) { allCars.Remove(car); }
        public void ReplaceInfoCar(Car car)//метод для обновления информации 
        {
            int index = allCars.FindIndex(x => x.ID == car.ID);
            allCars[index] = car;
        }
        public int GetMaxID()//получение максимального значения id
        {
            int max = 0;
            foreach (Car car in allCars)
            {
                if (max < car.ID) max = car.ID;
            }
            return max;
        }
        public Car findByModel(string model)//метод для нахождения клиента по id
        {
            return allCars.Find(x => x.Model == model);
        }
    }
    class Car
    {
        private int id; private string model;
        private string num; private decimal price;
        private decimal deposit; private List<int> rents;
        public Car() { }
        public Car(int id, string model, string num, decimal price, decimal deposit, List<int> rents)
        {
            this.id = id; this.model = model;
            this.num = num; this.price = price;
            this.deposit = deposit; this.rents = rents;
        }
        public int ID { get { return id; } set { this.id = value; } }
        public string Model { get { return model; } set { this.model = value; } }
        public string Num { get { return num; } set { this.num = value; } }
        public decimal Price { get { return price; } set { this.price = value; } }
        public decimal Deposit { get { return deposit; } set { this.deposit = value; } }
        public List<int> Rents { get { return rents; } set { this.rents = value; } }
    }
}

