using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab10_rent_a_car
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()//инициализация
        {
            InitializeComponent();
            FillForm();
        }
        public void FillForm()//запонение формы настроек
        {
            DefaultPrice.Checked = Data.Settings.BoolSettings[0];
            DefaultDeposit.Checked = Data.Settings.BoolSettings[1];
            DefaultPeriod.Text = Data.Settings.DefaultPeriod.ToString();
            roundBox.SelectedIndex = Data.Settings.Round;
            dbPathBox.Text = Data.Storage + "DB";
        }
        private void okButton_Click(object sender, EventArgs e)//выход
        {
            if (DefaultPrice.Checked) { Data.Settings.BoolSettings[0] = true; }
            if (!DefaultPrice.Checked) { Data.Settings.BoolSettings[0] = false; }
            if (DefaultDeposit.Checked) { Data.Settings.BoolSettings[1] = true; }
            if (!DefaultDeposit.Checked) { Data.Settings.BoolSettings[1] = false; }
            Data.Settings.DefaultPeriod = int.Parse(DefaultPeriod.Text);
            Data.Settings.Round = roundBox.SelectedIndex;
            this.Close();
        }
        private void About_Click(object sender, EventArgs e)//открытие "О программе"
        {
            About about = new About();
            about.ShowDialog();
        }

        private void copyDB_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Выберите папку, в которую хотите копировать данные программы.";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists($"{folderBrowserDialog.SelectedPath}/DB_Backup")) { Directory.Delete($"{folderBrowserDialog.SelectedPath}/DB_Backup", true); }
                Directory.CreateDirectory($"{folderBrowserDialog.SelectedPath}/DB_Backup");
                DirectoryCopy(Data.Storage + "DB", $"{folderBrowserDialog.SelectedPath}/DB_Backup", true);
                MessageBox.Show("Папка данных успешно скопирована");
                MainForm.stStrip.Items.Add("Папка данных успешно скопирована"); 
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            okButton_Click(sender, e);
        }


        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderBrowserDialog.Description = "Выберите папку, в которой хотите хранить данные программы.";
                    if (!Directory.Exists($"{folderBrowserDialog.SelectedPath}/DB")) { Directory.CreateDirectory($"{folderBrowserDialog.SelectedPath}/DB"); }
                    else { Directory.Delete($"{folderBrowserDialog.SelectedPath}/DB", true); Directory.CreateDirectory($"{folderBrowserDialog.SelectedPath}/DB"); }
                    DirectoryCopy(Data.Storage + "DB", $"{folderBrowserDialog.SelectedPath}/DB", true);
                    Data.Storage = folderBrowserDialog.SelectedPath + "\\";
                    if (Data.Storage == "\\") { Data.Storage = ""; }
                    Data.Status = false;
                    MainForm.stStrip.Items.Clear();
                    MainForm.stStrip.Items.Add("Местоположение базы данных успешно изменено, выполните сохранение.");
                    MessageBox.Show("Местоположение базы данных успешно изменено");
                    dbPathBox.Text = Data.Storage + "DB";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при изменении места хранения базы данных");
            }
        }
    }
}
