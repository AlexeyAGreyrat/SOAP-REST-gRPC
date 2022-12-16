using System.ComponentModel.DataAnnotations;

namespace Lesson1_LibraryWebService.Models
{
    public enum SearchType
    {
        [Display(Name = "Заголовок")]
        Title,
        [Display(Name = "Автор")]
        Autor,
        [Display(Name = "Категория")]
        Category,
        [Display(Name = "Возрастное ограничение")]
        AgeLimit         
    }
}
