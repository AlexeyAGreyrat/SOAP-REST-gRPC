using Lesson1_LibraryService.Models;
using Lesson1_LibraryService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson1_LibraryService.Services.Impl
{
    public class LibraryRepository : ILibraryRepositoryService
    {
        private readonly ILibraryDatabaseContextService _context;
        public LibraryRepository(ILibraryDatabaseContextService context)
        {
            _context = context;
        }
        public IList<Book> GetByTitle(string title)
        {
            try
            {
                return _context.Books.Where(book => book.Title.ToLower().Contains(title.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
        }       

        public IList<Book> GetByAuthor(string authorName)
        {
            try
            {
                return _context.Books.Where(book =>
                    book.Authors.Where(author => author.Name.ToLower().Contains(authorName.ToLower())).Count() > 0).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }

        }

        public IList<Book> GetByCategory(string category)
        {
            try
            {
                return _context.Books.Where(book => book.Category.ToLower().Contains(category.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
        }

        public IList<Book> GetByAgeLimit(string AgeLimit)
        {
            try
            {
                //return _context.Books.Where(book => book.AgeLimit.ToString().Contains(AgeLimit.ToLower())).ToList();
                return _context.Books.Where(book => book.AgeLimit.ToString() == AgeLimit).ToList();
            }
            catch (Exception ex)
            {

                return new List<Book>();
            }
        }
    }
}