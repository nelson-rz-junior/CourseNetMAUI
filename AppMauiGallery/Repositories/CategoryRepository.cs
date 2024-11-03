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
                    },
                    new()
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new()
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new()
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            }
        };

        return categories;
    }
}
