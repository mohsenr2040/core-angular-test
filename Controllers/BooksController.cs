namespace library.controllers
{
    [Route("api/[controller]")]
    public class BooksController:controllers
    {
        
       private IBookService _bookService;
       public BooksController(IBookService  bookService)
       {
           _bookService=bookService;
       }

       [HttpPost("AddBook")]
       public iactionresult AddBook([FromBody]Book book)
       {
           _bookService.AddBook(book);
           return OK("Added");
       }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        //Update an existing book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

            //Delete a book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        //Get a single book by id
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookById(id);
            return Ok(book);
        }

    }
}