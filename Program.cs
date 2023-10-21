using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BTL_UML
{
    public class Daumuc
    {
        public int Masach { get; set; }
        public string Tensach { get; set; }
        public int MaNCC { get; set; }
       
        public string GetBookDetails()
        {
            return $"{Masach}: {Tensach} ,{MaNCC}";
        }
    }

    public class BookManager
    {
        private List<Daumuc> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            Book bookToRemove = books.Find(b => b.BookId == bookId);
            if (bookToRemove != null)
                books.Remove(bookToRemove);
        }

        public void UpdateBook(int bookId, Book updatedBook)
        {
            Book bookToUpdate = books.Find(b => b.BookId == bookId);
            if (bookToUpdate != null)
            {
                bookToUpdate.Title = updatedBook.Title;
                bookToUpdate.Author = updatedBook.Author;
                bookToUpdate.Price = updatedBook.Price;
            }
        }

        public Book GetBookById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}