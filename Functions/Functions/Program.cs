void showMessage(string message)
{
    Console.WriteLine(message);
}

bool isEven(int number)
{
    return number % 2 == 0;
}

string isStrongPassword(string password)
{
    bool isDigit = false;
    bool isLetter = false;
    bool isSymbol = false;
    //123AB6?!
    foreach (char character in password)
    {
        if (char.IsDigit(character))
        {
            isDigit = true;
        }
        else if (char.IsLetter(character)) 
        { 
            isLetter = true;
        }
        else
        {
            isSymbol = true;
        }



    }

    string report = string.Empty;
    if (isLetter && isDigit && isSymbol)
    {
        report = "Güçlü!";
    }
    else if ((isLetter && isDigit) || (isLetter && isSymbol) || (isDigit && isSymbol))
    {
        report = "ORTA";
    }
    else
    {
        report = "ZAYIF!";
    }

    return report;
}

showMessage("İşlem tamamlandı");
string output = isEven(20) ? "Çift" : "Tek";
Console.WriteLine(isEven(15)? "Çift":"Tek");

do
{
    Console.WriteLine("Şifrenizi Giriniz:");
    string pass = Console.ReadLine();
    string result = isStrongPassword(pass);
    Console.WriteLine(result);
    Console.WriteLine("Yeniden denemek ister misin? (E/H)");
} while (Console.ReadLine()=="E");


//Kullanıcının girdiği bir şifrenin güvenli olup olmadığını bildiren fonksiyon.
/*
 *  sadece harf ya da rakam -> ZAYIF
 *  Harf ve Rakam... -> ORTA
 *  Hem harf, hem rakam hem de sembol -> GÜÇLÜ
 */


