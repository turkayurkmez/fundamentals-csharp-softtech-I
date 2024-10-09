using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSObject
{
    //Bu bir tanım. Sokrates için Idea, Aristotales için Form'dur.
    public class Ilan
    {

        //Her ilanın ................ vardır.
        private string baslik;

        public void SetBaslik(string deger)
        {
            if (string.IsNullOrEmpty(deger))
            {
                throw new Exception("İlan başlığı boş olamaz");
            }

            this.baslik = deger;
        }

        public string GetBaslik()
        {
            return this.baslik;
        }

        //2001
        private string lokasyon;
        public string Lokasyon
        {
            get { return lokasyon; }
            set { lokasyon = value; }

        }

        public DateTime IlanTarihi { get; set; }
        public bool AktifMi { get; set; }

        public List<string> Resimler { get; set; }



    }
}
