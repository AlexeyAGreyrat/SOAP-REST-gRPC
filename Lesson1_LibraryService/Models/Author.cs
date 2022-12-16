using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson1_LibraryService.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Lang { get; set; }
        public override string ToString() => $"{Name} ({Lang})"; 

    }
}