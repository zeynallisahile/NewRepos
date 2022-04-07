using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Book
    {
        private int _id;
        public int Id { get; }
        public Book()
        {
            _id++;
            Id =_id;
        }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public string ShowInfo()
        {
            return $"Id:{Id} - Name:{Name} - AuthorName:{AuthorName} - Price:{Price}";
        }
    }
}
