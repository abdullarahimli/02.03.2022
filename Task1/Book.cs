using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Book
    {
        private static int _count = 1;
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            _count++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{Name[0..2].ToUpper()}{_count}";
        }
    }
}
