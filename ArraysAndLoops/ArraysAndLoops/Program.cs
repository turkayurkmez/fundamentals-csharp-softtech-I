// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> cities = new List<string>() { "Adana", "Urfa", "Istanbul", "Eskisehir", "Istanbul", "Istanbul", "Adana" };
List<int> numbers = new() { 30, 12, -4, 5, 9, 0 };

int min = numbers[0];
for (int i = 1; i < numbers.Count; i++)
{
	if (numbers[i] < min)
	{
		min = numbers[i];
	}

}

Console.WriteLine(min);
int max = numbers[0];
foreach (var number in numbers)
{
	if (number > max)
	{
		max = number;
	}
}
Console.WriteLine(max);
Console.WriteLine("Aradığınız il:");
string city = Console.ReadLine();
//Eğer city değeri koleksiyonda varsa, "Var" yoksa "Yok" desin!
bool isFind = false;
foreach (var cityInList in cities)
{
	if (city == cityInList)
	{
		isFind = true;
		break;
	}
}

string message = isFind ? "var" : "yok";
Console.WriteLine($"{city} ili listede {message}");

//numbers içindeki pozitif sayıları topla.
var total = 0;
foreach (var number in numbers)
{
	if (number<0)
	{
		continue;
	}
	total += number;

}

//Aranan il, hangi indexte bulunuyor?

Console.WriteLine("Aradığınız il:");
city = Console.ReadLine();
int findingIndex = -1;
for (int i = 0; i < cities.Count; i++)
{
	if (city == cities[i])
	{
		findingIndex = i;
		break;
	}
}

if (findingIndex != -1)
{
    Console.WriteLine($"{city} ili {findingIndex}. index değerinde bulundu!");
}

List<string> cityList = new List<string>();
foreach (var item in cities)
{
	if (!cityList.Contains(item))
	{
		cityList.Add(item);
	}
}

foreach (var item in cityList)
{
    Console.WriteLine(item);
}