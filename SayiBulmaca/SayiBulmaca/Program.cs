// See https://aka.ms/new-console-template for more information

int rastgeleSayiTut(int maksimum)
{
    Random randomNumberGenerator = new Random();
    int sayi = randomNumberGenerator.Next(1,maksimum);
    return sayi;
}

int kullanicidanTahminIste()
{
    Console.WriteLine("Tahmininizi girin:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    return tahmin;
}

string karsilastir(int tahmin, int tutulan)
{
    if (tahmin > tutulan)
    {
        return "Aşağı";
    }
    else if (tahmin < tutulan)
    {
        return "Yukarı";
    }
    else
    {
        return "Bildiniz";
    }

}


/*
 * 1. 1 ile 1000 arasında rastgele bir sayı tut.
 * 2. Kullanıcıya tahminini sor.
 * 3. Tahmin(x) ile Tutulan(y) sayıyı karşılaştır.
 *    x > y  ise "AŞAĞI" x < y ise "YUKARI" yaz.
 * 4. Sonucu yazdır.
 * 5. Bilene dek devam et (2. Adıma)
 */
int sayi = rastgeleSayiTut(1000);
bool kullaniciBildiMi = false;
while (!kullaniciBildiMi)
{
    int kullaniciTahmini = kullanicidanTahminIste();
    string sonuc = karsilastir(kullaniciTahmini, sayi);
    Console.WriteLine(sonuc);
    kullaniciBildiMi = sonuc == "Bildiniz";
}


 