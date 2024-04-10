using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulynaria_Altashev.Classes
{
    internal class Recept
    {
        public int Identityr {  get; set; }
        public string Recept_Name {  get; set; }
        public Recept (int identityr, string recept_Name)
        {
            Identityr = identityr;
            Recept_Name = recept_Name;
        }
    }
}
