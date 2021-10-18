using System;
using library.Data;
using library.Data.Models;
using library.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class BooksController:Controller
    {
        
       private IBookService _bookService;
       public BooksController(IBookService  bookService)
       {
           _bookService=bookService;
       }

       [HttpPost("AddBook")]
       public IActionResult AddBook([FromBody]Book book)
       {
           _bookService.AddBook(book);
           return Ok(book);
       }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        //Update an existing book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
            _bookService.UpdateBook(id, book);
            return Ok(book);
        }

        //Delete a book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok();
        }

        //Get a single book by id
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }

    }
}