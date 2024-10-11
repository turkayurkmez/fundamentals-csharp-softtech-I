namespace recordTypes
{

    //Dikkat: immutable bir Person record:
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();




            Console.WriteLine($"Müşteri nesneleri eşit mi: {musteri1.Equals(musteri2)}");
            Console.WriteLine($"Müşteri 1: {musteri1.GetHashCode()}, Müşteri 2: {musteri2.GetHashCode()}");

            MusteriRecord musteriRecord1 = new MusteriRecord() { Ad = "Türkay" };
            musteriRecord1.Ad = "Türkay";
            Console.WriteLine($"record'un Ad özelliği: {musteriRecord1.Ad.GetHashCode()}");

            musteriRecord1.Ad = "Mehmet";
            Console.WriteLine($"record'un Ad özelliği: {musteriRecord1.Ad.GetHashCode()}");

            MusteriRecord musteriRecord2 = new MusteriRecord() { Ad = "Derya" };

            Console.WriteLine($"Müşteri record'ları eşit mi: {musteriRecord1 == musteriRecord2}");
            Console.WriteLine($"Müşteri 1: {musteriRecord1.GetHashCode()}, Müşteri 2: {musteri2.GetHashCode()}");
            Product p1 = new Product(1, "Küllük", 50, "Küllük işte");

            Console.WriteLine("-------------------------------------------------------------------");

            var phoneNumbers = new string[2];
            Person person = new("Kamuran", "Akkor", phoneNumbers);
            Console.WriteLine(person);

            //1. Eşitlik

            Person person2 = new("Kamuran", "Akkor", phoneNumbers);
            Console.WriteLine($"İki record (person==person2): {person == person2}");
            Console.WriteLine($"Referans karşılaştırması: {ReferenceEquals(person,person2)}");

            //iki record arasında alan kopyalama:
            person.PhoneNumbers[0] = "05352000101";
          
            Console.WriteLine($"Person2 == person1: {person2 == person}");
            Console.WriteLine($"Person2 ilk telefon: {person2.PhoneNumbers[0]}");

            Person person3 = person with { FirstName = "Aycan" };
            Console.WriteLine(person3);
//            person3.FirstName = "Türkay";

            Console.WriteLine($"Person == Person3 : {person == person3}");
        }
    }
}
