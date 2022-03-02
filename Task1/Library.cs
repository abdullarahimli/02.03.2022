using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Task1
{
    class Library
    {


        private List<Book> _books;
        public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }
       
        public List<Book> FindAllBooksByName(string bookNameFind)
        {
            List<Book> bookfind = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(bookNameFind.ToLower()))
                {
                    bookfind.Add(item);
                }
            }
            return bookfind;

        }
        public void RemoveAllBookByName(string bookNameRemove)
        {
            List<Book> bookremove = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(bookNameRemove.ToLower()))
                {
                    bookremove.Add(item);
                }
            }
            foreach (var item in bookremove)
            {
                _books.Remove(item);
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int bookNameMinCount, int bookNameMaxCount)
        {
            List<Book> bookcount = new List<Book>();
            foreach (var item in _books)
            {
                if (item.PageCount > bookNameMinCount && item.PageCount < bookNameMaxCount)
                {
                    bookcount.Add(item);
                }
            }
            return bookcount;
        }
        public void RemoveByNo(string bookNameRemoveNo)
        {
            Book bookremoveno = null;
            foreach (var item in _books)
            {
                if (item.Code.ToLower().Contains(bookNameRemoveNo.ToLower()))
                {
                    bookremoveno = item;
                }
            }
            _books.Remove(bookremoveno);
        }
        public void GetBook()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"{book}");
            }
        }
        public void AddBook(string name, string authorName, int pageCount)
        {
            Book book = new Book(name, authorName, pageCount);
            _books.Add(book);
        }
        public List<Book> SearchBooks(string bookNameSearch)
        {
            List<Book> booksearch = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(bookNameSearch.ToLower()) || item.PageCount.ToString().Contains(bookNameSearch) || item.AuthorName.ToLower().Contains(bookNameSearch.ToLower()))
                {
                    booksearch.Add(item);
                }
            }
            return booksearch;
        }
    }
}
