using AppMauiGallery.Models;
using AppMauiGallery.Pages.Layouts;

namespace AppMauiGallery.Repositories;

public class CategoryRepository
{
    public List<Category> GetCategories()
    {
        List<Category> categories = new()
        {
            new Category
            {
                Name = "Layout",
                Components = new List<Component>
                {
                    new()
                    {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    }
                }
            }
        };

        return categories;
    }
}
