namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\salex.xlsx";
            ReportGenerator reportGenerator = new ReportGenerator(excelFilePath: file);
            Console.WriteLine($"{reportGenerator.ExcelFilePath} adresindeki verilerden {reportGenerator.DocumentFormat} türünde rapor üretildi");

            ReportGenerator report2 = new ReportGenerator(excelFilePath:"C:\\personal.xlsx", "HTML");
            Console.WriteLine($"{report2.ExcelFilePath} adresindeki verilerden {report2.DocumentFormat} türünde rapor üretildi");

        }
    }
}
