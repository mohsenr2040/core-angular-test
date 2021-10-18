namespace library.Data
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