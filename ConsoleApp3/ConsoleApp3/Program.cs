using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = null;
            bool check = false;
            Console.WriteLine("User yaratmaq ucun datalari daxil edin!");
            do
            {
                Console.WriteLine("User-in adini daxil edin:");
                string fullname = Console.ReadLine();

                Console.WriteLine("User-in Email-ni daxil edin:");
                string email = Console.ReadLine();

                Console.WriteLine("User-in sifresini daxil edin(sifrede en az bir boyuk herf,bir kicik ve reqem olmalidir)");
                string password;
                do
                {
                    password = Console.ReadLine();
                } while (!PasswordChecker(password));

                User user = new User(fullname, email, password);
                bool checkmenu = false;
                do
                {
                    Console.WriteLine("\n------>>Giris menyusu<<-----");
                    Console.WriteLine("1. User-in melumatlarini goster");
                    Console.WriteLine("2. Yeni grup yatar");
                    Console.WriteLine("3. Esas menyu");
                    Console.WriteLine("0. Cixis");
                    string choise = Console.ReadLine();
                    switch (choise)
                    {
                        case "1":
                            user.ShowInfo();
                            break;
                        case "2":
                            Console.WriteLine("Grupun adini daxil edin:");
                            string groupName;
                            do
                            {
                                groupName = Console.ReadLine();
                            } while (!CheckGroupNo(groupName));
                            Console.WriteLine("Grupun telebe limitini daxil edin:");
                            int limit;
                            do
                            {
                                limit = Convert.ToInt32(Console.ReadLine());
                            } while (limit <= 5 || limit >= 18);
                            group = new Group(groupName, limit);
                            break;
                        case "3":
                            bool checkMenu = true;
                            Console.WriteLine("----->>Esas menyuya kecid etdiniz");
                            do
                            {
                                Console.WriteLine("1. Butun telebeleri goster");
                                Console.WriteLine("2. Id ile axtaris");
                                Console.WriteLine("3. Telebe elave et");
                                Console.WriteLine("0. Geri");

                                string menu = Console.ReadLine();
                                switch (menu)
                                {
                                    case "1":
                                        foreach (var item in group.GetAllStudents())
                                        {
                                            Console.WriteLine(item.ShowInfo());
                                        }
                                        break;
                                    case "2":
                                        Console.WriteLine("Id-ni daxil edin:");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine(group.GetStudent(id).Fullname);
                                        break;
                                    case "3":
                                        Console.WriteLine("Telebe datalarini daxil edin:");
                                        Console.WriteLine("Telebenin adini daxil edin:");
                                        string fullnames = Console.ReadLine();
                                        Console.WriteLine("Telebenin balini daxil edin:");
                                        double point;
                                        do
                                        {
                                            point = Convert.ToDouble(Console.ReadLine());
                                        } while (point <= 0 || point >= 100);
                                        Student student1 = new Student(fullnames, point);
                                        group.AddStudent(student1);
                                        break;
                                    case "0":
                                        checkmenu = false;
                                        break;
                                    default:
                                        Console.WriteLine("Duzgun secim edin!!!");
                                        break;
                                }
                            } while (checkMenu);
                            break;
                        case "0":
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin!!!");
                            break;
                    }
                } while (!checkmenu);
            } while (check);
        }
    }
}
