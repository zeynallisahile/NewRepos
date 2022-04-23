using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Program
    {
        static void Main(string[] args)
        {

            Metods metod = new Metods();
        bool exit = false;
            do
            {
                Console.WriteLine("1.Add room\n2MakeReservation.\n0.Exit Program");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        metod.AddRoom();
                        break;
                    case "2":
                        Console.WriteLine("Axdarilacaq id daxil edin");
                        int id = Convert.ToInt32(Console.ReadLine());
        metod.MakeReservation(id);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        break;
                }
           } while (!exit) ;
        }
    }
}
