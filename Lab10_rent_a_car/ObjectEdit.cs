using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Lab10_rent_a_car
{
    public partial class ObjectEdit : Form
    {
        public ObjectEdit()//новая
        {
            InitializeComponent();
            Data.CurrentObject = new Object();
            Data.CurrentObject.ID = Data.Objects.GetMaxID() + 1;
            Data.Objects.AddObject(Data.CurrentObject);
            inRentBox.Text = "0";
            quantityBox.Text = "0";
        }
        internal ObjectEdit(Object obj)//существующая
        {
            InitializeComponent();
            FillForm(obj);
        }
        internal void FillForm(Object obj)//заполнение
        {
            nameBox.Text = obj.Name;
            numBox.Text = obj.Num;
            priceBox.Text = obj.Price.ToString();
            inRentBox.Text = obj.InRent.ToString();
            inStockBox.Value = obj.InStock;
            repairBox.Value = obj.Repair;
            quantityBox.Text = obj.Quantity.ToString();
            minTBox.Value = obj.MinT;
            maxTBox.Value = obj.MaxT;
            measureBox.Text = obj.Measure;
            descriptionBox.Text = obj.Description;
            damageBox.Text = obj.Damage;
        }
        private void saveButton_Click(object sender, EventArgs e)//сохранение
        {
            if (nameBox.Text == "" || numBox.Text == "" || priceBox.Text == "" ||
                numBox.Text == "")
            {
                MessageBox.Show("Для сохранения заполните все поля формы.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Заполнены не все поля");
            }
            else
            {
                SaveThisForm();
                Data.Status = false;
                MessageBox.Show("Данные успешно изменены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.stStrip.Items.Clear();
                MainForm.stStrip.Items.Add("Есть несохраненные данные");
                this.Close();
                ObjectView objectView = this.Owner as ObjectView;
                if(objectView != null) objectView.Close();
            }
        }
        private void SaveThisForm()//сохранение обновленной (или нет) формы
        {
            Data.CurrentObject.Name = nameBox.Text;
            Data.CurrentObject.Num = numBox.Text;
            Data.CurrentObject.Price = decimal.Parse(priceBox.Text);
            Data.CurrentObject.InStock = (int)inStockBox.Value;
            Data.CurrentObject.Repair = (int)repairBox.Value;
            Data.CurrentObject.Quantity = int.Parse(quantityBox.Text);
            Data.CurrentObject.InRent = int.Parse(inRentBox.Text);
            Data.CurrentObject.MinT = (int)minTBox.Value;
            Data.CurrentObject.MaxT = (int)maxTBox.Value;
            Data.CurrentObject.Measure = measureBox.Text;
            Data.CurrentObject.Description = descriptionBox.Text;
            Data.CurrentObject.Damage = damageBox.Text;
            Data.CurrentObject.Deleted = false;
            Data.CurrentObject.Rents = new List<int>();
            LoadCarPic();
            Data.Objects.ReplaceInfoObject(Data.CurrentObject);
        }
        private void LoadCarPic()
        {
            try
            {
                if (File.Exists(Data.Storage + $"DB/Pics/{Data.CurrentObject.Name}.jpg")) { File.Delete(Data.Storage + $"DB/Pics/{Data.CurrentObject.Name}.jpg"); }

                if (File.Exists(Data.PicPath))
                {
                    File.Move(Data.PicPath, Data.Storage + $"DB/Pics/{Data.CurrentObject.Name}.jpg");
                }
            }
            catch { }
        }
        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)//ввод только цифр
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void CarEdit_FormClosed(object sender, FormClosedEventArgs e)//изменение формы родителя
        {
            try
            {
                ObjectView carView = this.Owner as ObjectView;
                if (nameBox.Text == "" || numBox.Text == "" || priceBox.Text == "")
                {
                    Data.Objects.DelObject(Data.CurrentObject);
                    carView.Close();
                }
                carView.FillForm(Data.CurrentObject);
            }
            catch
            {
                ObjectsList carsList = this.Owner as ObjectsList;
                carsList.FillGrid();
            }
        }
        private void loadPicButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg|jpg files (*jpg)|*.jpg";
            openFileDialog.ShowDialog();
            Data.PicPath = openFileDialog.FileName;
            MessageBox.Show("Фото успешно добавлено.");
        }

        private void inStockBox_ValueChanged(object sender, EventArgs e)
        {
            try { quantityBox.Text = (inStockBox.Value + repairBox.Value + int.Parse(inRentBox.Text)).ToString(); }
            catch { }
        }

        private void repairBox_ValueChanged(object sender, EventArgs e)
        {
            try { quantityBox.Text = (inStockBox.Value + repairBox.Value + int.Parse(inRentBox.Text)).ToString(); }
            catch { }
        }

        private void measureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measureBox.Text == "дней") 
            {
                minTBox.Maximum = 60;
                maxTBox.Maximum = 60;
                measureLabel.Text = "в день";
            }
            if (measureBox.Text == "часов")
            {
                minTBox.Maximum = 48;
                maxTBox.Maximum = 48;
                measureLabel.Text = "в час";
            }
            if (measureBox.Text == "месяцев")
            {
                minTBox.Maximum = 12;
                maxTBox.Maximum = 12;
                measureLabel.Text = "в месяц";
            }
        }

        private void ObjectEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                try
                {
                    ObjectView objView = this.Owner as ObjectView;
                    ObjectsList objList = objView.Owner as ObjectsList;
                    objView.Close();
                    objList.Close();
                }
                catch
                {

                }
            }
        }
    }
}
