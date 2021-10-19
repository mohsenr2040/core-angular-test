using library.Data.Models;
using System.Collections.Generic;

namespace library.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int Id);
        
        void UpdateBook(int Id , Book newBook);
        void DeleteBook(int Id);
        void AddBook(Book newBook);
    }
}