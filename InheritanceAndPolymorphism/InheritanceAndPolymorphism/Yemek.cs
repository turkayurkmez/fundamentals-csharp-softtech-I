using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Yemek
    {
        //Her yemeğin ............................. vardır.
        public decimal Fiyat { get; set; }      
        public int PismeSuresi { get; set; }
        public List<string> Malzemeler { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().FullName}, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında pilav ile sunuldu");
        }
    }

    public class Corba : Yemek
    {
        public bool TereyagVarMi { get; set; }
        public bool SogukMu { get; set; }
    }

    public class DomatesCorba : Corba
    {
        public bool KasarliMi { get; set; }
    }

    public class EtYemegi : Yemek
    {
       
    }

    public class Kofte: EtYemegi
    {

    }
    public class Kebap : EtYemegi
    {
        //her kebabın ............................. vardır
        //kebaba özel özellikler
        public bool AciOlsunMu { get; set; }
        public string SunumYontemi { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında soğan satalası ile sunuldu");
        }
    }

    public class Tatli: Yemek
    {
       

    }

    public class Baklava : Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında dondurma ile sunuldu");
        }
    }


   


}
