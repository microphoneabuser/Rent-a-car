using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    static class Users
    {
        public static List<User> allUsers = new List<User>();
        public static User CurrentUser;
        public static User FindByLogin(string login)//метод для нахождения клиента по id
        {
            return allUsers.Find(x => x.Login == login);
        }
    }
    class User
    {
        private string login;
        private string password;
        private string status;
        public User(string login, string password, string status)
        {
            this.login = login;
            this.password = password;
            this.status = status;
        }
        public User()
        {
            
        }
        public string Login { get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Status { get { return status; } set { status = value; } }
    }
}
