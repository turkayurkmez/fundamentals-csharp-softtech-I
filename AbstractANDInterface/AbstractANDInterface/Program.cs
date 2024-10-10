namespace AbstractANDInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             * Bir DMS (Document Management System) geliştiriyorsunuz. 
             * Dijital dokümanları arşivlemek ve erişim yönetimi.
             *   PDF, EXCEL, Word (Görüntüleme, Kaydetme, Kopya, Taşıma/Silme)
             */

            PDFDocument pdf = new PDFDocument();
            ExcelDocument excel = new ExcelDocument();
            WordDocument word = new WordDocument(); 

            DocumentSaverComponent documentSaver = new DocumentSaverComponent();
            documentSaver.Save(excel);

            DocumentPrinter printer = new DocumentPrinter();
            printer.Print(excel);
            printer.Print(word);
            




        }
    }
}
