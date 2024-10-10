using System.IO;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Bir klasör oluştur
             * 2. Bu klasörün içine dosya koy.
             */

            var info = Directory.CreateDirectory("C:\\TestFolder");
            Console.WriteLine($"{info.CreationTime} anında klasör oluşturuldu");
            File.WriteAllText($"{info.FullName}\\data.txt", "Bu ifade, uygulama ile oluşturuldu!");

            try
            {
                var images = ImageFileHelper.FindImages(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), isCreateLogFile:true);
                foreach (var image in images)
                {
                    Console.WriteLine(image);
                }

            }
            catch (DirectoryNotFoundException)
            {

                Console.WriteLine("Klasör bulunamadı");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Klasör adı belirtilmeli ");
            }
            catch (UnauthorizedAccessException ex)
            {

            }


        }
    }
}
