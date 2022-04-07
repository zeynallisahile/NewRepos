using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Book> _books;
        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
                
            throw new NullReferenceException("Id null ola bilmez");

            return _books.Find(b=>b.Id==id);
        }

        public void RemoveOrderByNo(int id)
        {
            _books.Remove(_books.Find(x => x.Id ==id));
        }
    }
}
