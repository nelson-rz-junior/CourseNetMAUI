using AppMauiGallery.Models;
using AppMauiGallery.Pages.Forms;
using AppMauiGallery.Pages.Layouts;
using AppMauiGallery.Views.Cells;
using AppMauiGallery.Views.Components.General;
using AppMauiGallery.Views.Lists;

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
                Name = "Controles (Views)",
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
                        Description = "Caixa de marcação de escolha múltipla.",
                        Page = typeof(CheckBoxPage)
                    },
                    new()
                    {
                        Title = "RadioButton",
                        Description = "Agrupamento de caixas de marcação de escolha única.",
                        Page = typeof(RadioButtonPage)
                    },
                    new()
                    {
                        Title = "Switch",
                        Description = "Cria um botão do tipo interruptor ON/OFF.",
                        Page = typeof(SwitchPage)
                    },
                    new()
                    {
                        Title = "Stepper",
                        Description = "Cria opções de incrementar ou decrementar um valor.",
                        Page = typeof(StepperPage)
                    },
                    new()
                    {
                        Title = "Slider",
                        Description = "Estrutura deslizante para incrementar ou decrementar um valor.",
                        Page = typeof(SliderPage)
                    },
                    new()
                    {
                        Title = "TimePicker",
                        Description = "Cria uma caixa de seleção de hora e minuto.",
                        Page = typeof(TimePickerPage)
                    },
                    new()
                    {
                        Title = "DatePicker",
                        Description = "Cria uma estrutura de seleção de datas.",
                        Page = typeof(DatePickerPage)
                    },
                    new()
                    {
                        Title = "SearchBar",
                        Description = "Cria uma caixa de pesquisa.",
                        Page = typeof(SearchBarPage)
                    },
                    new()
                    {
                        Title = "Picker",
                        Description = "Cria uma lista de seleção.",
                        Page = typeof(PickerPage)
                    }
                }
            },
            new Category
            {
                Name = "Células",
                Components = new List<Component>
                {
                    new()
                    {
                        Title = "TextCell",
                        Description = "Apresenta até duas labels onde uma é destinada ao título e outra ao conteúdo.",
                        Page = typeof(TextCellPage)
                    },
                    new()
                    {
                        Title = "ImageCell",
                        Description = "Apresenta uma imagem com duas labels onde uma é destinada ao título e outra ao conteúdo.",
                        Page = typeof(ImageCellPage)
                    },
                    new()
                    {
                        Title = "SwitchCell",
                        Description = "Apresenta uma label e um botão do tipo interruptor ON/OFF.",
                        Page = typeof(SwitchCellPage)
                    },
                    new()
                    {
                        Title = "EntryCell",
                        Description = "Apresenta uma label e um campo de entrada de texto.",
                        Page = typeof(EntryCellPage)
                    },
                    new()
                    {
                        Title = "ViewCell",
                        Description = "Apresenta uma célula com conteúdo personalizado.",
                        Page = typeof(ViewCellPage)
                    }
                }
            },
            new Category
            {
                Name = "Listas e Coleções",
                Components = new List<Component>
                {
                    new()
                    {
                        Title = "TableView",
                        Description = "Apresenta uma lista de células em linhas separadas organizadas em seções.",
                        Page = typeof(TableViewPage)
                    },
                    new()
                    {
                        Title = "Picker",
                        Description = "Apresenta uma lista de seleção única.",
                        Page = typeof(PickerListPage)
                    },
                    new()
                    {
                        Title = "ListView",
                        Description = "Apresenta uma lista de itens com rolagem vertical.",
                        Page = typeof(ListViewPage)
                    }
                }
            }
        };

        return categories;
    }
}
