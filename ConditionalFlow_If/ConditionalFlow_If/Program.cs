// See https://aka.ms/new-console-template for more information

DateTime myBirthDate = DateTime.Now;

if (myBirthDate.Month == 10 && myBirthDate.Day == 7)
{
    Console.WriteLine("Türkay'ın doğum günü :)");
}
else
{
    Console.WriteLine("İyi günler....");
}


Console.WriteLine("Bir ay ismi giriniz:(Örneğin Ocak)");
string month = Console.ReadLine();
if (month == "Aralık" || month =="Ocak" || month == "Şubat")
{
    Console.WriteLine("Kış");
}
else if (month == "Mart" || month == "Nisan" || month == "Mayıs")
{

}
else
{

}

Console.WriteLine("Bir sayı girin:");
int number = Convert.ToInt32(Console.ReadLine());
string message = string.Empty;

if (number % 2 == 0)
{
    message = "Çift sayı";
}
else
{
    message = "Tek Sayı";
}

Console.WriteLine(message);

string message2 = number % 2 == 0 ? "Çift" : "Tek";



