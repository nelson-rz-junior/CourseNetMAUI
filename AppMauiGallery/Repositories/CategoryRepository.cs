using AppMauiGallery.Models;
using AppMauiGallery.Pages.Forms;
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
                    },
                    new()
                    {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos (obsoleto).",
                        Page = typeof(FramePage)
                    },
                    new()
                    {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    },
                    new()
                    {
                        Title = "Shadow",
                        Description = "Adiciona uma sombra ao elemento.",
                        Page = typeof(ShadowPage)
                    }
                }
            },
            new Category
            {
                Name = "Formulários",
                Components = new List<Component>
                {
                    new()
                    {
                        Title = "Entry",
                        Description = "Campo de entrada de texto de uma única linha.",
                        Page = typeof(EntryPage)
                    },
                    new()
                    {
                        Title = "Editor",
                        Description = "Campo de entrada de texto de múltiplas linhas.",
                        Page = typeof(EditorPage)
                    },
                    new()
                    {
                        Title = "CheckBox",
                        Description = "Caixa de seleção.",
                        Page = typeof(CheckBoxPage)
                    },
                    new()
                    {
                        Title = "RadioButton",
                        Description = "Botão de opção.",
                        Page = typeof(RadioButtonPage)
                    },
                    new()
                    {
                        Title = "Switch",
                        Description = "Botão de alternância.",
                        Page = typeof(SwitchPage)
                    },
                    new()
                    {
                        Title = "Picker",
                        Description = "Caixa de seleção suspensa.",
                        Page = typeof(PickerPage)
                    },
                }
            }
        };

        return categories;
    }
}
