//Array ve elemanlarını biliyorum
string ulke1 = "Almanya";
string ulke2 = "İngiltere";
string ulke3 = "Türkiye";


string[] countries = { "Almanya", "İngiltere", "Türkiye" };
int[] childAges = { 16, 22, 4 };

//bellekte 20 elemanlık bir int array'i oluştur:
//Array'ın 20 elemanlı olduğunu biliyorum. Değerleri bilmiyorum!
int[] ages = new int[20];
                                   //0          1         2         3
string[] seasons = new string[] { "Winter", "Spring", "Summer", "Fall" };

Console.WriteLine($"ages dizisinin eleman sayısı: {seasons.Length}");
Console.WriteLine(seasons[0]);
Console.WriteLine(seasons[3]);
Console.WriteLine(seasons[seasons.Length -1]);





//Kullanıcının girdiği iki basamaklı bir sayınının okunuşunu yazan bir program....
//42 -> Kırk iki


string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };


string cevap = "H";

while (cevap == "H")
{
	Console.WriteLine("İki basamaklı bir sayı giriniz:");
	int sayi = Convert.ToInt32(Console.ReadLine());
	int onlarBasamagi = sayi / 10;
	int birlerBasamagi = sayi % 10;

	Console.WriteLine(onlar[onlarBasamagi] + " " + birler[birlerBasamagi]);
	Console.WriteLine("Çıkmak ister misiniz? (E/H)");
	cevap = Console.ReadLine();

}
//Kullanıcı, uygulamadan çıkmak istemediği sürece sayıyı yazıya çevirmeye devam eder.
//Pişmediği sürece çorbayı karıştırmaya devam eder.