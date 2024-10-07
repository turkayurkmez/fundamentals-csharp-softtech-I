Console.WriteLine("Hello, World!");
try
{
	Console.WriteLine("Bölünecek sayı:");
	int dividedNumber = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Bölen sayı:");
	int divider = int.Parse(Console.ReadLine());
	int division = dividedNumber / divider;
	Console.WriteLine(division);

}
catch (FormatException)
{
    Console.WriteLine("Lütfen sayısal değer giriniz!");

}
catch (DivideByZeroException)
{
    Console.WriteLine("Tam sayılar 0'a bölünemez!");
}
catch(Exception exception)
{
    Console.WriteLine($"Genel bir hata oluştu: {exception.Message}");
}

