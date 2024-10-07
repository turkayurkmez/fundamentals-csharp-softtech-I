namespace TypesAndVariables
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aldığı verileri işleyerek sonuç üreten yapılar.
             * 
             * 
             */

            //Değişkenler ve veri tipleri
            //Primitive and Complex Types

            //1. Sayısal tip:
            //Tam sayı:
            byte mini = 255;

            sbyte signedByte = -128;

            short onaltiBit = -32768;

            ushort unsignedShort = 65535;


            int otuzikiBit = 2000000000;

            uint unsignedInt = 4000000000;

            long altmisDortBit = 9223372036854775807;

            ulong unsignedLong = 0;


            //Ondalıklı:
            double pi1 = 3.14;

            float pi2 = 3.14f;

            decimal pi3 = 3.14593351465465464556454546464646546984797465464654646461456497864684m;


            //2. Sözel tipler:
            char symbol = '!';
            string name = "Türkay";

            //3. mantıksal
            bool isCanceled = false;

            //implicitly casting: otomatik çevir
            byte toplam = 254 + 1; //implicit
            byte b1 = 255;
            byte b2 = 5;
            //explicit casting: Zorla çevir
            byte expTotal = (byte)(b1 + b2);
            Console.WriteLine(expTotal);

            Console.WriteLine("Bir sayı giriniz:");
            string ilkSayi = Console.ReadLine();

            Console.WriteLine("İkinci sayıyı giriniz:");
            string ikinciSayi = Console.ReadLine();

            byte num1 = Convert.ToByte(ilkSayi);
            byte num2 = Convert.ToByte(ikinciSayi);


            try
            {
                checked
                {
                    byte total = (byte)(num1 + num2);
                    Console.WriteLine(total);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Girdiğiniz sayılar toplamı byte sınırlarını aşıyor!");
            }

            











        }
    }
}
