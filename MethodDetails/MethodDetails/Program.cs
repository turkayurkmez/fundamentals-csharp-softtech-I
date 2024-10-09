

namespace MethodDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int toplam = topla(7, 254);

            int kalan = 0;
            int sonuc = bol(20, 3, out kalan);
            Console.WriteLine($"Bölme işleminin sonucu: {sonuc} kalan: {kalan}");

            //var sonuc2 = bolme(25, 3);        
            int sayi = 8;
            islemYap(ref sayi);

            Console.WriteLine($"Sayı parametresinin değeri: {sayi}");

            int ortalama = ortalamaAl(44, 28, 30, 35, 33, 26, 13, 10, 10, 9);
            Console.WriteLine($"Yaş ortalaması: {ortalama}");

            int ort = ortalamaAl(22, 34);

            double kare = alanHesapla(12, "Kare");
            double daire = alanHesapla(7, "Daire");
            double ucgen = alanHesapla(3, 4, GeometrikSekil.Ucgen);
            var dikdortgen = alanHesapla(7, 8, GeometrikSekil.Dikdortgen);

            Console.WriteLine($"Kare: {kare}\nDaire:{daire}\nÜçgen:{ucgen}\nDikdörtgen:{dikdortgen}");

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ilkSayi"></param>
        /// <param name="ikinciSayi"></param>
        /// <returns></returns>
        private static int topla(int ilkSayi, int ikinciSayi)
        {
            return ilkSayi + ikinciSayi;
        }

        private static int bol(int bolunen, int bolen, out int kalan)
        {
            //hem bolüm sonucu hem de kalan değerini nasıl döndürürüm?
            kalan = bolunen % bolen;
            return bolunen / bolen;
        }
        //private static (int, int) bolme(int bolunen, int bolen)
        //{
        //    return (bolunen / bolen, bolunen % bolen);
        //}
        private static void islemYap(ref int sayi)
        {
            sayi *= 4;
            Console.WriteLine($"Metot Bitti. Yeni değer {sayi}");
        }

        /// <summary>
        /// Girilen sayıların aritmetik ortalamasını alır.
        /// </summary>
        /// <param name="numbers">int tipinde sayılarınızı girin</param>
        /// <returns>ortalama değer</returns>
        static int ortalamaAl(params int[] numbers)
        {
            return (int)numbers.Average();
        }

        /// <summary>
        /// Kare ya da Daire cisimlerinin alanını hesaplar.
        /// </summary>
        /// <param name="birimUzunluk">Birim uzunluk değeri</param>
        /// <param name="sekil">"Kare" veya "Daire" değerleri</param>
        /// <returns></returns>
        static double alanHesapla(double birimUzunluk, string sekil)
        {
            double sonuc = 0.0;

            switch (sekil)
            {
                case "Kare":
                    sonuc = Math.Pow(birimUzunluk, 2);
                    break;
                case "Daire":
                    sonuc = Math.PI * Math.Pow(birimUzunluk, 2);
                    break;
                default:
                    break;
            }

            return sonuc;
        }

        /// <summary>
        /// Üçgen veya Dikdörtgen.....
        /// </summary>
        /// <param name="birimUzunluk">ilk uzunluk</param>
        /// <param name="birimUzunluk2">ikinci....</param>
        /// <param name="sekil">"Üçgen" veya "Dikdörtgen"</param>
        /// <returns></returns>
        static double alanHesapla(double birimUzunluk, double birimUzunluk2, GeometrikSekil sekil)
        {
            double sonuc = 0.0;

            //switch (sekil)
            //{
            //    case "Üçgen":
            //        sonuc = (birimUzunluk * birimUzunluk2) / 2;
            //        break;
            //    case "Dikdörtgen":
            //        sonuc = birimUzunluk * birimUzunluk2;
            //        break;
            //    default:
            //        break;
            //}

            switch (sekil)
            {
                case GeometrikSekil.Ucgen:
                    sonuc = (birimUzunluk * birimUzunluk2) / 2;
                    break;
                case GeometrikSekil.Dikdortgen:
                    sonuc = birimUzunluk * birimUzunluk2;
                    break;
                default:
                    break;
            }

            return sonuc;
        }


    }

    public enum GeometrikSekil
    {
        Kare,
        Daire,
        Ucgen,
        Dikdortgen
    }

}
