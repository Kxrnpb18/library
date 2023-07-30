using System.Collections.Generic;
using library.Models; // Make sure this namespace is correct
using library.Services; // Make sure this namespace is correct
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace library.Pages
{
    public class booksModel : PageModel
    {
        private readonly bookService _bookService;

        public booksModel(bookService bookService)
        {
            _bookService = bookService;
        }

        public List<books> books { get; private set; }

        public void OnGet()
        {
            books = _bookService.GetBooks();
        }
    }
}
