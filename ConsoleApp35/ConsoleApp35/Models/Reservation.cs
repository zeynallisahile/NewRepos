using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Reservation
    {

        private static int _id;
        public int Id { get { return _id; } }
        public List<Room> Reservations { get; set; }
        public Reservation()
        {
            _id++;
            Reservations = new List<Room>();
        }
    }
}
