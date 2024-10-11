using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recordTypes
{
    //Düşünün, uygulamanızda, aynı adresteki müşterilerinizi filtrelemek istiyorsunuz.
    //Yani iki müşteriyi adresleri üzerinden eşitlik karşılaştırması yapacaksınız
    
    public class Musteri 
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKimlik { get; set; }
        public string Adres { get; set; }

        //Equals fonksiyonunu ezerek (override), iki Musteri nesnesinin birbirlerine eşitliğini nasıl denetleyeceğinizi belirtebilirsiniz. Ancak bu yetmez ve == operatörünü de tanımlamak zorunda kalırsınız.... 
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

     

    }
}
