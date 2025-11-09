using Tarta_Mara_Lab2.Models;

namespace Tarta_Mara_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; } 
    }
}
