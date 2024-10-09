// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string word = "sofftech";
//1. Kelimeyi düzelt:
word = word.Replace("ff", "ft");
//2. Kelimeninin tamamını büyük harfe çevirmek.
word = word.ToUpper();

/*
 * SOFTTECH - 0
 * OFTTECH - 1
 * FTTECH - 2
 * TTECH
 * TECH
 * ECH
 * CH
 * H 
 */

//Console.WriteLine(word.Substring(1));
int startIndex = 0;
int length = word.Length;
string subWord = string.Empty;
while (startIndex < length)
{
    subWord = word.Substring(startIndex);
    startIndex++;
    Console.WriteLine(subWord);
}

Console.WriteLine("Bir kelime giriniz:");
string userWord = Console.ReadLine();
Console.WriteLine("Bir harf giriniz:");
string letter = Console.ReadLine();
int index = word.IndexOf(letter, 4);
Console.WriteLine(index);
/*
 *  Kelime'de harf bulunduğu SÜRECE
 *  Aramaya devam et
 *  Bulunduğun her index değerinin bir sonraki noktasından ara.
 */
bool isWordContainingLetter = false;
List<int> findingIndexes = new List<int>();
int searchIndex = 0;
do
{
    int findingIndex = userWord.IndexOf(letter, searchIndex);
    isWordContainingLetter = findingIndex != -1;
    if (isWordContainingLetter)
    {
        findingIndexes.Add(findingIndex);
    }  
    searchIndex = findingIndex + 1;

} while (isWordContainingLetter);

Console.WriteLine($"{letter} harfi kelimenin {string.Join(',',findingIndexes.ToArray())} indekslerinde bulundu");

