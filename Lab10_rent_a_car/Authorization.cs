using System;
using System.Windows.Forms;
using System.Xml;

namespace Lab10_rent_a_car
{    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MainForm mainForm = new MainForm();
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (FileOperations.CheckLogin(loginField.Text, passwordField.Text))
            {
                FileOperations.ReadUsers();
                Users.CurrentUser = Users.FindByLogin(loginField.Text);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
                Close();
                
            }
            else
                MessageBox.Show("Введен неправильный логин или пароль!", "Внимание!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender,e);
            }
            if (e.KeyCode == Keys.Down)
            {
                passwordField.Select();
            }
            if (e.KeyCode == Keys.Up)
            {
                loginField.Select();
            }
        }
    }
}
