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
    public partial class UserEdit : Form
    {
        string inLogin;
        public UserEdit()
        {
            InitializeComponent();
            try
            {
                FillForm();
                inLogin = Data.CurrentUser.Login;
            }
            catch
            {
                loginBox.Text = ""; passwordBox.Text = ""; managerB.Checked = true;
            }
        }
        internal void FillForm() //запонение формы адреса
        {
            loginBox.Text = Data.CurrentUser.Login;
            passwordBox.Text = Data.CurrentUser.Password;
            if(Data.CurrentUser.Status == "admin")
            {
                adminB.Checked = true;
            }
            else
            {
                managerB.Checked = true;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || passwordBox.Text == "")
            {
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Заполнены не все поля");
                MessageBox.Show("Для сохранения заполните поле формы.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveThisForm();
                Data.Status = false;
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
                MessageBox.Show("Данные успешно изменены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void SaveThisForm()//сохранение формы
        {
            if (Users.FindByLogin(inLogin) == null)
            {
                Data.CurrentUser.Login = loginBox.Text;
                Data.CurrentUser.Password = passwordBox.Text;
                if (managerB.Checked) { Data.CurrentUser.Status = "manager"; }
                if (adminB.Checked) { Data.CurrentUser.Status = "admin"; }

                Users.allUsers.Add(Data.CurrentUser);
            }
            else
            {
                Users.FindByLogin(inLogin).Login = loginBox.Text;
                Users.FindByLogin(inLogin).Password = passwordBox.Text;
                if (managerB.Checked) { Users.FindByLogin(inLogin).Status = "manager"; }
                if (adminB.Checked) { Users.FindByLogin(inLogin).Status = "admin"; }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить данного пользователя?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Users.allUsers.Remove(Users.FindByLogin(Data.CurrentUser.Login));
                Data.CurrentUser = null;
                Data.Status = false;
                this.Close();
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
            }
        }

        private void UserEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsersList usersList = this.Owner as UsersList;
            usersList.FillGrid();
        }

        private void UserEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    UsersList usersList = this.Owner as UsersList;
                    usersList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
