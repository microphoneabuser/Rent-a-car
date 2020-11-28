using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_rent_a_car
{
    static class Data
    {
        public static Rents Rents { get; set; }
        public static Clients Clients { get; set; }
        public static Objects Objects { get; set; }
        public static AddServices AddServices { get; set; }
        public static Addresses Addresses { get; set; }
        public static Settings Settings { get; set; }
        public static Rent CurrentRent { get; set; }
        public static Client CurrentClient { get; set; }
        public static Object CurrentObject { get; set; }
        public static AddService CurrentService { get; set; }
        public static Address CurrentAddress { get; set; }
        public static User CurrentUser { get; set; }
        public static bool Status { get; set; }
        public static string Storage { get; set; }
        public static string PicPath { get; set; }

    }
}
