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
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
            FillGrid();
        }
        internal void FillGrid()
        {
            int i = 0;
            UsersGrid.Rows.Clear();
            foreach (User user in Users.allUsers)
            { 
                UsersGrid.Rows.Add();
                int j = 0;
                UsersGrid.Rows[i].Cells[j].Value = user.Login; j++;
                UsersGrid.Rows[i].Cells[j].Value = user.Password; j++;
                if (user.Status == "manager")
                {
                    UsersGrid.Rows[i].Cells[j].Value = "Менеджер"; j++;
                }
                else
                {
                    UsersGrid.Rows[i].Cells[j].Value = "Администратор"; j++;
                }
                i++;
            }
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            Data.CurrentUser = new User();
            UserEdit userEdit = new UserEdit();
            userEdit.Owner = this;
            userEdit.ShowDialog();
        }

        private void UsersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            if (!Data.Status) { mainForm.Text = "Аренда*"; }
        }

        private void UsersList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void UsersGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                User user = Users.FindByLogin(UsersGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Data.CurrentUser = user;
                UserEdit userEdit = new UserEdit();
                userEdit.Owner = this;
                userEdit.ShowDialog();
            }
        }
    }
}
