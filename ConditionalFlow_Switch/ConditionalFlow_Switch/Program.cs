// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;

Console.WriteLine("Trafik Lamasını seçin");
Console.WriteLine("1. Kırmızı");
Console.WriteLine("2. Sarı");
Console.WriteLine("3. Yeşil");

string choose = Console.ReadLine();
if (choose == "1")
{
    Console.WriteLine("Dur!");
}
else if (choose == "2")
{
    Console.WriteLine("Dikkat!");
}
else if (choose == "3")
{
    Console.WriteLine("Geç");
}
else
{
    Console.WriteLine("Lütfen sadece seçeneklerden birini seçin!");
}


switch (choose)
{
    case "1":
        Console.WriteLine("Dur!");
        break;
    case "2":
        Console.WriteLine("Dikkat!");
        break;
    case "3":
        Console.WriteLine("Geç");
        break;
    default:
        Console.WriteLine("Lütfen sadece seçeneklerden birini seçin!");
        break;
}

//hafta içi mi hafta sonu mu?
switch (DateTime.Now.DayOfWeek)
{

    //case DayOfWeek.Monday:   
    //case DayOfWeek.Tuesday:       
    //case DayOfWeek.Wednesday:       
    //case DayOfWeek.Thursday:     
    //case DayOfWeek.Friday:
    //    Console.WriteLine("Hafta içi...");
    //    break;   
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Hafta sonu...");
        break;
  
    default:
        Console.WriteLine("Hafta içi...");
        break;
}

//.net 7.0:

string haftaninGunu = DateTime.Now.DayOfWeek 
switch
{
     DayOfWeek.Monday => "Pazartesi",
     DayOfWeek.Sunday => "Pazar"
};

