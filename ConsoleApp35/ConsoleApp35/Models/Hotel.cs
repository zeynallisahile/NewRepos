using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Hotel
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
        public Hotel()
        {
            Rooms = new List<Room>();
        }
    }
}
