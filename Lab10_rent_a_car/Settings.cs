using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    public class Settings
    {
        List<bool> boolSettings;
        int defaultPeriod;
        int round;
        public Settings()
        {
            boolSettings = new List<bool>();
        }
        public void AddSetting(bool setting) { boolSettings.Add(setting); }
        public List<bool> BoolSettings { get { return boolSettings; } }
        public int Round { get { return round; } set { round = value; } }
        public int DefaultPeriod { get { return defaultPeriod; } set { this.defaultPeriod = value; } }
        public void SaveSettings() { FileOperations.SaveSettings(this); }
    }
}
