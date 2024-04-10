using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulynaria_Altashev.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Belki { get; set; }
        public int Zhire { get; set; }
        public int Uglev { get; set; }

        public Product(int id, string productName, int belki, int zhire, int uglev) 
        {
            Id = id;
            ProductName = productName;
            Belki = belki;
            Zhire = zhire;
            Uglev = uglev;
        }

    }
}
