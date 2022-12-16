using Lesson1_LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_LibraryService.Services
{
    internal interface ILibraryRepositoryService
    {
        IList<Book> GetByTitle(string title);

        IList<Book> GetByAuthor(string authorName);

        IList<Book> GetByCategory(string category);
        IList<Book> GetByAgeLimit(string AgeLimit);

    }
}
