using Lesson1_LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_LibraryService.Services
{
    public interface ILibraryDatabaseContextService
    {
        IList<Book> Books { get; }
    }
}
