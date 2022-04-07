using System;
using System.IO;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\acer\source\repos\ConsoleApp12\";
            Directory.CreateDirectory(path + "Files");
            if (!FileStyleUriParser.Exists(path + @"Files\database.json"))
                File.Create(path + @"Files\database.json");
           

            Book book1 = new Book()
            {
                Name = "Psixologizm",
                AuthorName = "Psixoloji",
                Price = 10
            };

            Book book2 = new Book()
            {
                Name = "Cinayet ve Ceza",
                AuthorName = "Roman",
                Price = 15
            };

            Library library = new Library()
            {
                Name = "BakuBookCenter",
                Id = 1
            };
          
        }
    }
}
