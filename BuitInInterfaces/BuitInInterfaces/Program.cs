namespace BuitInInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bu uygulama; bir lisenin öğrenci işlemlerini yapan bir uygulamadır.
             */
            StudentService studentService = new StudentService();
            studentService.Add(
                new Student { Id = 1, Name = "Türkay", LastName = "Ürkmez", Age = 44, Score = 65 },
                new Student { Id = 1, Name = "Gökay", LastName = "Uygun", Age = 26, Score = 85 },
                new Student { Id = 1, Name = "Gamze ", LastName = "Çakır", Age = 33, Score = 90 },
                new Student { Id = 1, Name = "Serap", LastName = "Üresin", Age = 38, Score = 80 }
                );

            var sortedStudents =   studentService.SortStudents();
            Console.WriteLine("Öğrenci Adı\tPuanı");
            Console.WriteLine("------------\t------");
            foreach (var student in studentService)
            {
                Console.WriteLine($"{student.Name} {student.LastName}\t{student.Score}");
            }
        }
    }
}
