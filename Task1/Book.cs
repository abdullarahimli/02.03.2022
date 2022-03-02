using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Book
    {
        private static int _count = 1;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book(string bookName, string authorName, int pageCount)
        {
            _count++;
            Name = bookName;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{bookName[0..2].ToUpper()}{_count}";
        }
        public override string ToString()
        {
            return $"Code: {Code}\nBook Name: {Name}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}";
        }

    }
}
