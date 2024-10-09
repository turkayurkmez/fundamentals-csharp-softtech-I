// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * while
 * do While
 * for
 * foreach
 */

//int number = 1;
//int total = 0;
//process: total = total + number;
//if (number < 10)
//{
//    number++;
//    goto process;
//}

//Console.WriteLine(total);
List<string> cities = new List<string>() { "Adana", "Urfa", "İstanbul", "Eskişehir", "İstanbul", "İstanbul", "Adana" };

cities.Add("Yozgat");
//sürekli yapılacak işlem sayısal bir koşula dayalıysa for:
for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine(cities[i]);
}

int number = 0;
bool isContinue = number != 0;
int length = 0;
//sürekli yapılacak işlem mantıksal bir koşula dayalıysa while:
while (isContinue)
{
    length++;
    number = number / 10;
    isContinue = number != 0;
}
Console.WriteLine(length);

bool isPagaAvailable = true;
while (isPagaAvailable)
{
    isPagaAvailable = false;
    //sayfayı yazdır
}
//sürekli yapılacak işlem mantıksal bir koşula dayalıysa fakat [ÖNCE işlem yapılması şart ise] do while:
do
{
    Console.WriteLine("İki sayı girin:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("...");
    int y = Convert.ToInt32(Console.ReadLine());
    int total = x + y;
    Console.WriteLine(total);
    Console.WriteLine("Bir işlem yapmak ister misin (E/H)");
} while (Console.ReadLine().ToLower()=="e");




foreach (string city in cities)
{
   
    Console.WriteLine(city);
}
