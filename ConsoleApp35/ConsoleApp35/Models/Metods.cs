using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
   internal class Metods
    {
        Hotel Hotel = new Hotel();
        public void AddRoom()
        {
            Console.WriteLine("Otag adini daxil edin");
            string roomName = Console.ReadLine();
            Room room = new Room();
            room.Name = roomName;
            Hotel.Rooms.Add(room);
        }
        public void MakeReservation(int? id)
        {
            if (id == null)
                Console.WriteLine("Id null ola bilmez");
            Room room = Hotel.Rooms.Find(x => x.Id == id);
            if (room == null)
                Console.WriteLine("Bu otaq movcud deyil");
            if (room != null && room.IsAviable == true)
            {
                Reservation reservation = new Reservation();
                reservation.Reservations.Add(room);
                room.IsAviable = false;
                Console.WriteLine("Reservasiya yaradildi");
            }
            else
                Console.WriteLine("Bu otaq Reservasiya olunub!");
        }
    }
}
