using AppMauiGallery.Models;
using AppMauiGallery.Pages.Layouts;
using AppMauiGallery.Views.Components.General;

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
            },
            new Category
            {
                Name = "Componentes (Views)",
                Components = new List<Component>
                {
                    new()
                    {
                        Title = "BoxView",
                        Description = "Cria uma caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },
                    new()
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela.",
                        Page = typeof(LabelPage)
                    },
                    new()
                    {
                        Title = "Button",
                        Description = "Apresenta um botão na tela.",
                        Page = typeof(ButtonPage)
                    },
                    new()
                    {
                        Title = "Image",
                        Description = "Apresenta uma imagem na tela.",
                        Page = typeof(ImagePage)
                    },
                    new()
                    {
                        Title = "ImageButton",
                        Description = "Apresenta uma imagem com comportamento de botão.",
                        Page = typeof(ImageButtonPage)
                    }
                }
            }
        };

        return categories;
    }
}
