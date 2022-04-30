using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {

        public string Fullname { get; set; }
        public double Point { get; set; }
        private int _id;
        public int Id { get => _id; }
        public Student()
        {
            _id++;
            Fullname = Fullname;
            Point = Point;
        }
    }
}
