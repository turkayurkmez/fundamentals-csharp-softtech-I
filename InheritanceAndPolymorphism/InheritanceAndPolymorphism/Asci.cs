using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Asci
    {
        //Asci nesnesinin .................. vardır
        public string Ad { get; set; }

        //Aşçı nesnesiyle ............. yapılır VEYA
        //Aşçı nesnesi ....................... yapar

        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
            yemek.SunumYap();
        }

    }
}
