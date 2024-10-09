namespace ClassVSObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Emlak uygulaması....
             * 
             * Bu uygulama ile müşteriler, ilan arayarak diledikleri emlağın ayrıntılarını inceleyecekler.
             */

            Ilan satilikEv = new Ilan();

            // satilikEv.Baslik = "Sahibinden lüks.....";
            satilikEv.SetBaslik("Sahibinden lüks.....");

            satilikEv.Lokasyon = "İstanbul";

            Ilan kiralikDukkan = new Ilan();
            //kiralikDukkan.Baslik = "Zemin kat bakkala uygun";
            kiralikDukkan.SetBaslik("Zemin kat bakkala uygun");
            kiralikDukkan.Lokasyon = "Sivas";

            Console.WriteLine($"Dükkan, {kiralikDukkan.Lokasyon} lokasyonunda başlığı ise {kiralikDukkan.GetBaslik()}");


            Ilan mustakil = null;
            //mustakil.Baslik = "üç katlı";

            Ilan yazlik = satilikEv;
            yazlik.Lokasyon = "Muğla";

            Console.WriteLine($"Satılık evin lokasyonu: {satilikEv.Lokasyon}");
            Console.WriteLine($"Yazlık evin lokasyonu: {yazlik.Lokasyon}");

            Ilan yeniIlan = new Ilan();
            Console.WriteLine("İlan başlığını girin");
            string baslik = Console.ReadLine();
            //if (string.IsNullOrEmpty(baslik))
            //{
            //    throw new Exception("İlan başlığı boş olamaz");
            //}
            //yeniIlan.Baslik = baslik;
            yeniIlan.SetBaslik(baslik);
            yeniIlan.Lokasyon = "Çanakkale";

            yeniIlan.IlanTarihi = new DateTime(2024, 8, 30);
            yeniIlan.Resimler = new List<string> { "1.png" };
          

            Console.WriteLine(yeniIlan.GetBaslik());




        }
    }
}
