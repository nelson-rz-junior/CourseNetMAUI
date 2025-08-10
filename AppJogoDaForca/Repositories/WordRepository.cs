using AppJogoDaForca.Models;

namespace AppJogoDaForca.Repositories;

public class WordRepository
{
    private readonly List<Word> _words;

    public WordRepository()
    {
        _words = [
            new() 
            { 
                Text = "ELEFANTE", 
                Tips = "Um grande animal cinza com tromba:" 
            },
            new() 
            { 
                Text = "GIRAFA", 
                Tips = "O animal mais alto do mundo, com um pescoço longo:" 
            },
            new() 
            { 
                Text = "CANGURU", 
                Tips = "Um marsupial que salta e carrega seus filhotes na bolsa:" 
            },
            new() 
            { 
                Text = "TIGRE", 
                Tips = "Um grande felino listrado, conhecido por sua força e agilidade:" 
            },
            new() 
            { 
                Text = "PINGUIM", 
                Tips = "Uma ave que não voa, mas nada muito bem no gelo:" 
            },
            new() 
            { 
                Text = "LEAO", 
                Tips = "Conhecido como o 'rei da selva', é um grande felino com uma juba impressionante:" 
            },
            new() 
            { 
                Text = "URSO", 
                Tips = "Um grande mamífero que pode ser encontrado em florestas e montanhas:" 
            },
            new() 
            { 
                Text = "LOBO", 
                Tips = "Um canídeo selvagem conhecido por viver em matilhas e uivar para a lua:" 
            },
            new() 
            { 
                Text = "ZEBRA", 
                Tips = "Um animal parecido com um cavalo, mas com listras pretas e brancas:" 
            },
            new() 
            { 
                Text = "HIPOPOTAMO", 
                Tips = "Um grande mamífero semi-aquático que passa muito tempo na água:" 
            },
            new()
            {
                Text = "MACACO",
                Tips = "Um animal primata conhecido por sua inteligência e habilidade de escalar árvores:"
            }
        ];
    }

    public Word GetRandomWord()
    {
        Random random = new();
        return _words[random.Next(0, _words.Count)];
    }
}
