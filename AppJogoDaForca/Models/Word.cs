namespace AppJogoDaForca.Models;

public class Word
{
    public Word()
    {
        Text = string.Empty;
        Tips = string.Empty;
    }

    public string Tips { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;
}
