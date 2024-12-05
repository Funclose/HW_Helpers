using HW_Helpers.Models;
using HW_Helpers.Service;
using HW_Helpers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace HW_Helpers.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View(_bookService.GetAllBooks());
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            if(ModelState.IsValid)
            {
                var book = new Book()
                { 
                    Title = model.Title,
                    Author = model.Author,
                    Genre = model.Genre,
                    Age = model.Age,
                };

                _bookService.AddBook(book);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                var st = new StringBuilder();
                foreach(var value in ModelState.Values)
                {
                    foreach(var error in value.Errors)
                    {
                        st.Append(error.ErrorMessage + "</br>");
                    }
                }
                model.Error = st.ToString();
            }
            return View(model);
        }
    }
}
