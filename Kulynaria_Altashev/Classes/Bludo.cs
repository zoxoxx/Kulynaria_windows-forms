using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulynaria_Altashev.Classes
{
    public class Bludo
    {
        public int Identityb { get; set; }
        public string bludo { get; set; }
        public string Numbo { get; set; }
        public string Osnova { get; set; }
        public int Vyhod { get; set; }
        public Image Bludo_image { get; set; }

        public Bludo(int id, string bludoname, string categoriya, string osnova, int vyhod, string image) 
        {
            Identityb = id;
            bludo = bludoname;
            Numbo = categoriya;
            Osnova = osnova;
            Vyhod = vyhod;

            if (image != "")
                Bludo_image = Image.FromFile(image);
            else
                Bludo_image = Image.FromFile(@"..\..\Images\picture.jpg");
        }
    }
}
