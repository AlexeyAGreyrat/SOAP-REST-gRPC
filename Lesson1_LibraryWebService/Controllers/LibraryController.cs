using Lesson1_LibraryWebService.Models;
using LibraryServiceReference;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson1_LibraryWebService.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;

        public LibraryController(ILogger<LibraryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(SearchType searchType, string searchString)
        {
            try
            {

                LibraryWebServiceSoapClient client =
                    new LibraryWebServiceSoapClient(LibraryWebServiceSoapClient.EndpointConfiguration.LibraryWebServiceSoap);

                if (!string.IsNullOrEmpty(searchString) && searchString.Length >= 1)
                {
                    switch (searchType)
                    {
                        case SearchType.Title:
                            return View(new BookCategoryViewModel
                            {
                                Books = client.GetBooksByTitle(searchString)
                            });
                        case SearchType.Autor:
                            return View(new BookCategoryViewModel
                            {
                                Books = client.GetBooksByAuthor(searchString)
                            });
                        case SearchType.Category:
                            return View(new BookCategoryViewModel
                            {
                                Books = client.GetBooksByCategory(searchString)
                            });
                        case SearchType.AgeLimit:
                            return View(new BookCategoryViewModel
                            {
                                Books = client.GetBooksByAgeLimit(searchString)
                            });
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return View(new BookCategoryViewModel
            {
                Books = new Book[] { }
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}