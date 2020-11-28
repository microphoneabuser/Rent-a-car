using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab10_rent_a_car
{
    static class FileOperations
    {
        public static string GetStorage()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlElement xRoot = doc.DocumentElement;
            return xRoot.InnerText;
        }
        public static void SaveStorage(string storage)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement elem = doc.CreateElement("Storage");
            elem.InnerText = storage;
            doc.AppendChild(elem);
            doc.Save("Storage.xml");
        }
        public static bool CheckLogin(string myLogin, string myPassword)
        {
            bool check = false;
            XmlDocument docAuthor = new XmlDocument();
            docAuthor.Load(Data.Storage + "DB/Settings.xml"); 
            XmlElement xRoot = docAuthor.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Users")
                {
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        string login = ""; string password = "";
                        // обходим дочерний узел элемента
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "login")
                            {
                                login = childnode.InnerText;
                            }
                            if (childnode.Name == "password")
                            {
                                password = childnode.InnerText;
                            }
                        }
                        if (login == myLogin && password == myPassword) { check = true; }
                    }
                }
            }
            return check;
        }
        public static void ReadUsers()
        {
            XmlDocument docAuthor = new XmlDocument();
            docAuthor.Load(Data.Storage + "DB/Settings.xml");
            XmlElement xRoot = docAuthor.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Users")
                {
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        string login = ""; string password = ""; string status = "";
                        // обходим дочерний узел элемента
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "login")
                            {
                                login = childnode.InnerText;
                            }
                            if (childnode.Name == "password")
                            {
                                password = childnode.InnerText;
                            }
                            if (childnode.Name == "status")
                            {
                                status = childnode.InnerText;
                            }
                        }
                        Users.allUsers.Add(new User(login, password, status));
                    }
                }
            }
        }
        public static Objects ReadObjects()
        {
            Objects list = new Objects();
            XmlDocument docObjects = new XmlDocument();
            docObjects.Load(Data.Storage + "DB/RefBooks.xml");
            XmlElement xRoot = docObjects.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Objects")
                {
                    foreach (XmlNode node in xnode.ChildNodes)    
                    {
                        int id = 0; string model = ""; string num = ""; decimal price = 0;
                        decimal mdeposit = 0; bool deleted = false;
                        int quantity = 0; int inRent = 0; int inStock = 0; int repair = 0;
                        int minT = 0; int maxT = 0; string description = ""; string damage = "";
                        string measure = ""; List<int> rents = new List<int>();
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "id") { id = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "name") { model = childnode.InnerText; }
                            if (childnode.Name == "num") { num = childnode.InnerText; }
                            if (childnode.Name == "price") { price = decimal.Parse(childnode.InnerText); }
                            if (childnode.Name == "rents")
                            {
                                if (childnode.InnerText.Contains(","))
                                { 
                                    string[] array = childnode.InnerText.Split(',');
                                    foreach (string elem in array) { rents.Add(int.Parse(elem)); }
                                }
                                if (childnode.InnerText != "" & !childnode.InnerText.Contains(","))
                                {
                                    rents.Add(int.Parse(childnode.InnerText));
                                }
                            }
                            if (childnode.Name == "deleted") { deleted = bool.Parse(childnode.InnerText); }
                            if (childnode.Name == "quantity") { quantity = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "inRent") { inRent = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "inStock") { inStock = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "repair") { repair = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "minT") { minT = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "maxT") { maxT = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "description") { description = childnode.InnerText; }
                            if (childnode.Name == "damage") { damage = childnode.InnerText; }
                            if (childnode.Name == "measure") { measure = childnode.InnerText; }
                        }
                        Object obj = new Object(id, model, num, price, mdeposit, deleted, quantity, inRent, inStock, 
                            repair, minT, maxT, description, damage, measure, rents);
                        list.AddObject(obj);
                    }
                }
            }
            return list;
        }
        public static void SaveObjects(List<Object> allObjects)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try 
            { 
                xDoc.Load(Data.Storage + "DB/RefBooks.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes)
                {
                    if (n.Name == "Objects")
                    {
                        xRoot.RemoveChild(n);
                    }
                }
            } 
            catch 
            {
                xRoot = xDoc.CreateElement("Data");
                xDoc.AppendChild(xRoot); 
            }
            XmlElement objs = xDoc.CreateElement("Objects");
            foreach (Object obj in allObjects)
            {
                XmlElement objElem = xDoc.CreateElement("Object");
                // создаем элементы 
                XmlElement idElem = xDoc.CreateElement("id");
                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement numElem = xDoc.CreateElement("num");
                XmlElement priceElem = xDoc.CreateElement("price");
                XmlElement rentsElem = xDoc.CreateElement("rents");
                XmlElement deletedElem = xDoc.CreateElement("deleted");
                XmlElement quantityElem = xDoc.CreateElement("quantity");
                XmlElement inRentElem = xDoc.CreateElement("inRent");
                XmlElement inStockElem = xDoc.CreateElement("inStock");
                XmlElement repairElem = xDoc.CreateElement("repair");
                XmlElement minTElem = xDoc.CreateElement("minT");
                XmlElement maxTElem = xDoc.CreateElement("maxT");
                XmlElement descriptionElem = xDoc.CreateElement("description");
                XmlElement damageElem = xDoc.CreateElement("damage");
                XmlElement measureElem = xDoc.CreateElement("measure");
                // создаем текстовые значения для элементов и атрибута
                XmlText idText = xDoc.CreateTextNode(obj.ID.ToString());
                XmlText nameText = xDoc.CreateTextNode(obj.Name);
                XmlText numText = xDoc.CreateTextNode(obj.Num);
                XmlText priceText = xDoc.CreateTextNode(obj.Price.ToString());
                string rents = "";
                if(obj.Rents!=null)
                {
                    if (obj.Rents.Count != 0)
                    {
                        foreach (int num in obj.Rents)
                        {
                            rents += num + ",";
                        }
                        rents = rents.Substring(0, rents.Length - 1);
                    }
                }
                XmlText rentsText = xDoc.CreateTextNode(rents);
                XmlText deletedText = xDoc.CreateTextNode(obj.Deleted.ToString());
                XmlText quantityText = xDoc.CreateTextNode(obj.Quantity.ToString());
                XmlText inRentText = xDoc.CreateTextNode(obj.InRent.ToString());
                XmlText inStockText = xDoc.CreateTextNode(obj.InStock.ToString());
                XmlText repairText = xDoc.CreateTextNode(obj.Repair.ToString());
                XmlText minTText = xDoc.CreateTextNode(obj.MinT.ToString());
                XmlText maxTText = xDoc.CreateTextNode(obj.MaxT.ToString());
                XmlText descriptionText = xDoc.CreateTextNode(obj.Description);
                XmlText damageText = xDoc.CreateTextNode(obj.Damage);
                XmlText measureText = xDoc.CreateTextNode(obj.Measure);
                //добавляем узлы
                idElem.AppendChild(idText);
                nameElem.AppendChild(nameText);
                numElem.AppendChild(numText);
                priceElem.AppendChild(priceText);
                rentsElem.AppendChild(rentsText);
                deletedElem.AppendChild(deletedText);
                quantityElem.AppendChild(quantityText);
                inRentElem.AppendChild(inRentText);
                inStockElem.AppendChild(inStockText);
                repairElem.AppendChild(repairText);
                minTElem.AppendChild(minTText);
                maxTElem.AppendChild(maxTText);
                descriptionElem.AppendChild(descriptionText);
                damageElem.AppendChild(damageText);
                measureElem.AppendChild(measureText);

                objElem.AppendChild(idElem);
                objElem.AppendChild(nameElem);
                objElem.AppendChild(numElem);
                objElem.AppendChild(priceElem);
                objElem.AppendChild(rentsElem);
                objElem.AppendChild(deletedElem);
                objElem.AppendChild(quantityElem);
                objElem.AppendChild(inRentElem);
                objElem.AppendChild(inStockElem);
                objElem.AppendChild(repairElem);
                objElem.AppendChild(minTElem);
                objElem.AppendChild(maxTElem);
                objElem.AppendChild(descriptionElem);
                objElem.AppendChild(damageElem);
                objElem.AppendChild(measureElem);

                objs.AppendChild(objElem);
            }
            xRoot.AppendChild(objs);
            xDoc.Save(Data.Storage + "DB/RefBooks.xml");
        }

        public static AddServices ReadServices()
        {
            AddServices list = new AddServices();
            XmlDocument docClients = new XmlDocument();
            docClients.Load(Data.Storage + "DB/RefBooks.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "AddServices")
                { 
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        int id = 0; string name = ""; int price = 0; bool deleted = false;
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "id") { id = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "name") { name = childnode.InnerText; }
                            if (childnode.Name == "price") { price = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "deleted") { deleted = bool.Parse(childnode.InnerText); }
                            
                        }
                        AddService addService = new AddService(id, name, price, deleted);
                        list.AddService(addService);
                    }
                }
            }
            return list;
        }
        public static void SaveAddServices(List<AddService> allServices)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try
            {
                xDoc.Load(Data.Storage + "DB/RefBooks.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes)
                {
                    if (n.Name == "AddServices")
                    {
                        xRoot.RemoveChild(n);
                    }
                }
            }
            catch
            {
                xRoot = xDoc.CreateElement("Data");
                xDoc.AppendChild(xRoot);
            }
            XmlElement services = xDoc.CreateElement("AddServices");
            foreach (AddService service in allServices)
            {
                // создаем новый элемент client
                XmlElement serviceElem = xDoc.CreateElement("AddService");
                // создаем элементы 
                XmlElement idElem = xDoc.CreateElement("id");
                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement priceElem = xDoc.CreateElement("price");
                XmlElement deletedElem = xDoc.CreateElement("deleted");
                // создаем текстовые значения для элементов и атрибута
                XmlText idText = xDoc.CreateTextNode(service.ID.ToString());
                XmlText nameText = xDoc.CreateTextNode(service.Name);
                XmlText priceText = xDoc.CreateTextNode(service.Price.ToString());
                XmlText deletedText = xDoc.CreateTextNode(service.Deleted.ToString());
                //добавляем узлы
                idElem.AppendChild(idText);
                nameElem.AppendChild(nameText);
                priceElem.AppendChild(priceText);
                deletedElem.AppendChild(deletedText);

                serviceElem.AppendChild(idElem);
                serviceElem.AppendChild(nameElem);
                serviceElem.AppendChild(priceElem);
                serviceElem.AppendChild(deletedElem);

                services.AppendChild(serviceElem);
            }
            xRoot.AppendChild(services);
            xDoc.Save(Data.Storage + "DB/RefBooks.xml");
        }
        public static Addresses ReadAddresses()
        {
            Addresses list = new Addresses();
            XmlDocument docClients = new XmlDocument();
            docClients.Load(Data.Storage + "DB/RefBooks.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "CompAddresses")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        string address = ""; bool deleted = false;
                        foreach (XmlNode node in childnode.ChildNodes)
                        {
                            if(node.Name == "name")
                            {
                                address = node.InnerText;
                            }
                            if (node.Name == "deleted")
                            {
                                deleted = bool.Parse(node.InnerText);
                            }
                        }
                        list.AddAddress(new Address(address, deleted));
                    }
                }
            }
            return list;
        }
        public static void SaveAddresses(List<Address> allAddresses)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try
            {
                xDoc.Load(Data.Storage + "DB/RefBooks.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes)
                {
                    if (n.Name == "CompAddresses")
                    {
                        xRoot.RemoveChild(n);
                    }
                }
            }
            catch
            {
                xRoot = xDoc.CreateElement("Data");
                xDoc.AppendChild(xRoot);
            }
            XmlElement addresses = xDoc.CreateElement("CompAddresses");
            foreach (Address address in allAddresses)
            {
                XmlElement addressElem = xDoc.CreateElement("CompAddress");

                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement deletedElem = xDoc.CreateElement("deleted");

                XmlText nameText = xDoc.CreateTextNode(address.Name);
                XmlText deletedText = xDoc.CreateTextNode(address.Deleted.ToString());

                nameElem.AppendChild(nameText);
                deletedElem.AppendChild(deletedText);

                addressElem.AppendChild(nameElem);
                addressElem.AppendChild(deletedElem);

                addresses.AppendChild(addressElem);
            }
            xRoot.AppendChild(addresses);
            xDoc.Save(Data.Storage + "DB/RefBooks.xml");
        }
        public static Rents ReadRents()
        {
            Rents list = new Rents();
            XmlDocument docClients = new XmlDocument();
            docClients.Load(Data.Storage + "DB/Data.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Rents")
                {
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        int ID = 0; string clientFIO = ""; string name = ""; decimal price = 0; string depositType = "";
                        decimal depositMoney = 0; string deposit = ""; string measure = ""; double period = 0; 
                        string compAddress = ""; string secondAddress = ""; List<int> addservices = new List<int>();
                        bool saved = false; DateTime dateTime = new DateTime(); string status = ""; string description = "";
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "ID") { ID = int.Parse(childnode.InnerText); }
                            if (childnode.Name == "ClientFIO") { clientFIO = childnode.InnerText; }
                            if (childnode.Name == "Name") { name = childnode.InnerText; }
                            if (childnode.Name == "Price") { price = decimal.Parse(childnode.InnerText); }
                            if (childnode.Name == "DepositType") { depositType = childnode.InnerText; }
                            if (childnode.Name == "Deposit") 
                            {
                                if(depositType == "money") { depositMoney = decimal.Parse(childnode.InnerText); }
                                if(depositType == "doc" || depositType == "product"){ deposit = childnode.InnerText; }
                            }
                            if (childnode.Name == "Measure") { measure = childnode.InnerText; }
                            if (childnode.Name == "Period") { period = double.Parse(childnode.InnerText); }
                            if (childnode.Name == "CompAddress") { compAddress = childnode.InnerText; }
                            if (childnode.Name == "SecondAddress") { secondAddress = childnode.InnerText; }
                            if (childnode.Name == "AddServices")
                            {
                                if (childnode.InnerText != "")
                                {
                                    string[] array = childnode.InnerText.Split(',');
                                    foreach (string elem in array) { addservices.Add(int.Parse(elem)); }
                                }
                            }
                            if (childnode.Name == "Saved") { saved = bool.Parse(childnode.InnerText); }
                            if (childnode.Name == "Date") 
                            {
                                string[] array = childnode.InnerText.Split('.');
                                dateTime = new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0])); 
                            }
                            if (childnode.Name == "Time")
                            {
                                string[] array = childnode.InnerText.Split(':');
                                dateTime = dateTime.AddHours(int.Parse(array[0]));
                                dateTime = dateTime.AddMinutes(int.Parse(array[1]));
                            }
                            if(childnode.Name == "Status") { status = childnode.InnerText; }
                            if (childnode.Name == "Description") { description = childnode.InnerText; }
                        }
                        Rent rent = new Rent(ID, clientFIO, name, price, depositType,depositMoney, deposit, period, measure,
                            compAddress, secondAddress, addservices, saved, dateTime, status, description);
                        list.AddRent(rent);
                    }
                    
                }
            }
            return list;
        }
        public static void SaveRents(List<Rent> allRents)//сохранение данных всех клиентов в xml-файл
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try
            {
                xDoc.Load(Data.Storage + "DB/Data.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes)
                {
                    if (n.Name == "Rents")
                    {
                        xRoot.RemoveChild(n);
                    }
                }
            }
            catch
            {
                xRoot = xDoc.CreateElement("Data");
                xDoc.AppendChild(xRoot);
            }
            XmlElement rents = xDoc.CreateElement("Rents");
            foreach (Rent rent in allRents)
            {
                // создаем новый элемент
                XmlElement rentElem = xDoc.CreateElement("Rent");
                // создаем элементы 
                XmlElement IDElem = xDoc.CreateElement("ID");
                XmlElement clFIOElem = xDoc.CreateElement("ClientFIO");
                XmlElement nameElem = xDoc.CreateElement("Name");
                XmlElement priceElem = xDoc.CreateElement("Price");
                XmlElement depositTypeElem = xDoc.CreateElement("DepositType");
                XmlElement depositElem = xDoc.CreateElement("Deposit");
                XmlElement measureElem = xDoc.CreateElement("Measure");
                XmlElement periodElem = xDoc.CreateElement("Period");
                XmlElement compAddElem = xDoc.CreateElement("CompAddress");
                XmlElement secondAddressElem = xDoc.CreateElement("SecondAddress");
                XmlElement addservicesElem = xDoc.CreateElement("AddServices");
                XmlElement savedElem = xDoc.CreateElement("Saved");
                XmlElement dateElem = xDoc.CreateElement("Date");
                XmlElement timeElem = xDoc.CreateElement("Time");
                XmlElement statusElem = xDoc.CreateElement("Status");
                XmlElement descriptionElem = xDoc.CreateElement("Description");

                // создаем текстовые значения для элементов и атрибута
                XmlText clIDText = xDoc.CreateTextNode(rent.ID.ToString());
                XmlText clFIOText = xDoc.CreateTextNode(rent.ClientFIO);
                XmlText nameText = xDoc.CreateTextNode(rent.Name);
                XmlText priceText = xDoc.CreateTextNode(rent.Price.ToString());
                XmlText depositTypeText = xDoc.CreateTextNode(rent.DepositType);
                XmlText depositText = xDoc.CreateTextNode("");
                if(rent.DepositMoney != 0){depositText = xDoc.CreateTextNode(rent.DepositMoney.ToString()); }
                else { depositText = xDoc.CreateTextNode(rent.Deposit.ToString()); }
                XmlText measureText = xDoc.CreateTextNode(rent.Measure);
                XmlText periodText = xDoc.CreateTextNode(rent.Period.ToString());
                XmlText compAddText = xDoc.CreateTextNode(rent.CompAddress);
                XmlText secondAddressText = xDoc.CreateTextNode(rent.SecondAddress);
                XmlText addservicesText = xDoc.CreateTextNode("");
                if (rent.AddServicesString != null || rent.AddServicesString != "")
                    addservicesText = xDoc.CreateTextNode(rent.AddServicesString);
                XmlText savedText = xDoc.CreateTextNode(rent.Saved.ToString());
                XmlText dateText = xDoc.CreateTextNode($"{rent.DateTime.Day}.{rent.DateTime.Month}.{rent.DateTime.Year}");
                XmlText timeText = xDoc.CreateTextNode($"{rent.DateTime.Hour}:{rent.DateTime.Minute}");
                XmlText statusText = xDoc.CreateTextNode(rent.Status);
                XmlText descriptionText = xDoc.CreateTextNode(rent.Description);
                //добавляем узлы
                IDElem.AppendChild(clIDText);
                clFIOElem.AppendChild(clFIOText);
                nameElem.AppendChild(nameText);
                priceElem.AppendChild(priceText);
                depositTypeElem.AppendChild(depositTypeText);
                depositElem.AppendChild(depositText);
                measureElem.AppendChild(measureText);
                periodElem.AppendChild(periodText);
                compAddElem.AppendChild(compAddText);
                secondAddressElem.AppendChild(secondAddressText);
                addservicesElem.AppendChild(addservicesText);
                savedElem.AppendChild(savedText);
                dateElem.AppendChild(dateText);
                timeElem.AppendChild(timeText);
                statusElem.AppendChild(statusText);
                descriptionElem.AppendChild(descriptionText);

                rentElem.AppendChild(IDElem);
                rentElem.AppendChild(clFIOElem);
                rentElem.AppendChild(nameElem);
                rentElem.AppendChild(priceElem);
                rentElem.AppendChild(depositTypeElem);
                rentElem.AppendChild(depositElem);
                rentElem.AppendChild(measureElem);
                rentElem.AppendChild(periodElem);
                rentElem.AppendChild(compAddElem);
                rentElem.AppendChild(secondAddressElem);
                rentElem.AppendChild(addservicesElem);
                rentElem.AppendChild(savedElem);
                rentElem.AppendChild(dateElem);
                rentElem.AppendChild(timeElem);
                rentElem.AppendChild(statusElem);
                rentElem.AppendChild(descriptionElem);

                rents.AppendChild(rentElem);
            }
            xRoot.AppendChild(rents);
            xDoc.Save(Data.Storage + "DB/Data.xml");
        }
        public static Clients ReadClients()
        {
            Clients list = new Clients();
            XmlDocument docClients = new XmlDocument();
            docClients.Load(Data.Storage + "DB/Data.xml");
            XmlElement xRoot = docClients.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "Clients")
                {
                    foreach (XmlNode node in xnode.ChildNodes)
                    {
                        string FIO = ""; string passport = ""; string license = "";
                        string category = ""; string address = ""; bool saved = false;
                        List<int> rents = new List<int>();
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "FIO") { FIO = childnode.InnerText; }
                            if (childnode.Name == "Passport") { passport = childnode.InnerText; }
                            if (childnode.Name == "License") { license = childnode.InnerText; }
                            if (childnode.Name == "Category") { category = childnode.InnerText; }
                            if (childnode.Name == "Address") { address = childnode.InnerText; }
                            if (childnode.Name == "Saved") { saved = bool.Parse(childnode.InnerText); }
                            if (childnode.Name == "Rents")
                            {
                                if (childnode.InnerText != "")
                                {
                                    string[] array = childnode.InnerText.Split(',');
                                    foreach (string elem in array) { rents.Add(int.Parse(elem)); }
                                }
                            }
                        }
                        Client client = new Client(FIO, passport, license, category, address, saved, rents);
                        list.AddClient(client);
                    }

                }
            }
            return list;
        }
        public static void SaveClients(List<Client> allClients)//сохранение данных всех клиентов в xml-файл
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try
            {
                xDoc.Load(Data.Storage + "DB/Data.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes)
                {
                    if (n.Name == "Clients")
                    {
                        xRoot.RemoveChild(n);
                    }
                }
            } 
            catch
            {
                xRoot = xDoc.CreateElement("Data");
                xDoc.AppendChild(xRoot);
            }
            XmlElement clients = xDoc.CreateElement("Clients");
            foreach (Client client in allClients)
            {
                // создаем новый элемент client
                XmlElement clientElem = xDoc.CreateElement("Client");
                // создаем элементы 
                XmlElement FIOElem = xDoc.CreateElement("FIO");
                XmlElement passportElem = xDoc.CreateElement("Passport");
                XmlElement licenseElem = xDoc.CreateElement("License");
                XmlElement categoryElem = xDoc.CreateElement("Category");
                XmlElement addressElem = xDoc.CreateElement("Address");
                XmlElement savedElem = xDoc.CreateElement("Saved");
                XmlElement rentsElem = xDoc.CreateElement("Rents");
                // создаем текстовые значения для элементов 
                XmlText FIOText = xDoc.CreateTextNode(client.FIO);
                XmlText passportText = xDoc.CreateTextNode(client.Passport);
                XmlText licenseText = xDoc.CreateTextNode(client.License);
                XmlText categoryText = xDoc.CreateTextNode(client.Category);
                XmlText addressText = xDoc.CreateTextNode(client.Address);
                XmlText savedText = xDoc.CreateTextNode(client.Saved.ToString());
                string rents = "";
                if (client.Rents != null )
                {
                    if (client.Rents.Count != 0)
                    {
                        foreach (int num in client.Rents) { rents += num + ","; }
                        rents = rents.Substring(0, rents.Length - 1);
                    }
                }
                XmlText rentsText = xDoc.CreateTextNode(rents);
                //добавляем узлы
                FIOElem.AppendChild(FIOText);
                passportElem.AppendChild(passportText);
                licenseElem.AppendChild(licenseText);
                categoryElem.AppendChild(categoryText);
                addressElem.AppendChild(addressText);
                savedElem.AppendChild(savedText);
                rentsElem.AppendChild(rentsText);

                clientElem.AppendChild(FIOElem);
                clientElem.AppendChild(passportElem);
                clientElem.AppendChild(licenseElem);
                clientElem.AppendChild(categoryElem);
                clientElem.AppendChild(addressElem);
                clientElem.AppendChild(savedElem);
                clientElem.AppendChild(rentsElem);

                clients.AppendChild(clientElem);
            }
            xRoot.AppendChild(clients);
            xDoc.Save(Data.Storage + "DB/Data.xml");
        }
        public static Settings ReadSettings()
        {
            Settings settings = new Settings();
            XmlDocument docClients = new XmlDocument();
            docClients.Load(Data.Storage + "DB/Settings.xml");
            XmlElement xRoot = docClients.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                bool dprice = false;
                bool ddeposit = false;
                int dperiod = 0;
                if (xnode.Name == "Dprice")
                {
                    if(xnode.InnerText == "0") { dprice = false; }
                    if(xnode.InnerText == "1") { dprice = true; }
                    settings.AddSetting(dprice);
                }
                if (xnode.Name == "Ddeposit")
                {
                    if (xnode.InnerText == "0") { ddeposit = false; }
                    if (xnode.InnerText == "1") { ddeposit = true; }
                    settings.AddSetting(ddeposit);
                }
                if (xnode.Name == "Dperiod")
                {
                    dperiod = int.Parse(xnode.InnerText);
                    settings.DefaultPeriod = dperiod;
                }
                if(xnode.Name == "Round")
                {
                    settings.Round = int.Parse(xnode.InnerText);
                }
            }
            return settings;
        }
        public static void SaveSettings(Settings Settings)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement xRoot;
            try
            {
                xDoc.Load(Data.Storage + "DB/Settings.xml");
                xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("*");
                foreach (XmlNode n in childnodes) { xRoot.RemoveChild(n); }
            }
            catch
            {
                xRoot = xDoc.CreateElement("Settings");
                xDoc.AppendChild(xRoot);
            }
            XmlElement users = xDoc.CreateElement("Users");
            foreach (User user in Users.allUsers)
            {
                XmlElement userElem = xDoc.CreateElement("User");
                XmlElement login = xDoc.CreateElement("login");
                XmlElement password = xDoc.CreateElement("password");
                XmlElement status = xDoc.CreateElement("status");

                XmlText loginText = xDoc.CreateTextNode(user.Login);
                XmlText passwordText = xDoc.CreateTextNode(user.Password);
                XmlText statusText = xDoc.CreateTextNode(user.Status);

                login.AppendChild(loginText);
                password.AppendChild(passwordText);
                status.AppendChild(statusText);
                userElem.AppendChild(login);
                userElem.AppendChild(password);
                userElem.AppendChild(status);
                users.AppendChild(userElem);
            }

            XmlElement price = xDoc.CreateElement("Dprice");
            XmlElement deposit = xDoc.CreateElement("Ddeposit");
            XmlElement period = xDoc.CreateElement("Dperiod");
            XmlElement round = xDoc.CreateElement("Round");

            XmlText priceText = xDoc.CreateTextNode("0");
            if (Settings.BoolSettings[0]) { priceText = xDoc.CreateTextNode("1"); }
            XmlText depositText = xDoc.CreateTextNode("0");
            if (Settings.BoolSettings[1]) { depositText = xDoc.CreateTextNode("1"); }
            XmlText periodText = xDoc.CreateTextNode(Settings.DefaultPeriod.ToString());
            XmlText roundText = xDoc.CreateTextNode(Settings.Round.ToString());

            price.AppendChild(priceText);
            deposit.AppendChild(depositText);
            period.AppendChild(periodText);
            round.AppendChild(roundText);

            xRoot.AppendChild(price);
            xRoot.AppendChild(deposit);
            xRoot.AppendChild(period);
            xRoot.AppendChild(round);
            xRoot.AppendChild(users);
            xDoc.Save(Data.Storage + "DB/Settings.xml");
        }
    }
}

        
