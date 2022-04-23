using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35.Models
{
    class Room
    {
        private static int _id;
        public int Id { get => _id; }
        public string Name { get; set; }
        public bool IsAviable = true;
        public Room()
        {
            _id++;
        }
    }
}
