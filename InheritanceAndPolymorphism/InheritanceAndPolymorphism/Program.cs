namespace InheritanceAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             * Oyunda oyuncu bir aşçıdır ve kendisinden istenen yemeği yapar.
             */
            Kofte kofte = new Kofte();
            kofte.PismeSuresi = 25;
            DomatesCorba domatesCorba = new DomatesCorba();
            domatesCorba.PismeSuresi = 30;

            Baklava baklava = new Baklava() { PismeSuresi = 60 };
            Console.WriteLine("!!!!DİKKAT!!!");
            baklava.SunumYap();

            Kebap kebap = new Kebap() { PismeSuresi= 45, AciOlsunMu = true, SunumYontemi="Şiş"};

            Asci asci = new Asci();
            asci.Pisir(domatesCorba);
            asci.Pisir(kofte);
            asci.Pisir(baklava);
            asci.Pisir(kebap);

            object o1 = 1;
            //Boxing:
            object o2 = new Kebap();


        }
    }
}
