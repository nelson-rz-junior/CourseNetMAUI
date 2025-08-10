using AppJogoDaForca.Models;
using AppJogoDaForca.Repositories;

namespace AppJogoDaForca;

public partial class MainPage : ContentPage
{
    private Word _word;
    private int _errors = 0;

    public MainPage()
    {
        InitializeComponent();
        ResetScreen();
    }

    #region Initialization

    private void GenerateNewWord()
    {
        var repository = new WordRepository();
        _word = repository.GetRandomWord();
    }

    #endregion

    #region Display Word

    private char[] UpdateWordDisplay(string letter)
    {
        // Update the displayed word with the correct letter
        char[] displayedWord = lblWord.Text.ToCharArray();

        for (int i = 0; i < _word.Text.Length; i++)
        {
            if (_word.Text[i].ToString() == letter)
            {
                displayedWord[i] = letter[0];
            }
        }

        return displayedWord;
    }

    private void ProcessWrongLetter(Button button)
    {
        _errors++;

        imgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
        button.Style = GetStyleButton("Error");
    }

    #endregion

    #region Virtual Keyboard

    private void ResetScreen()
    {
        GenerateNewWord();
        ResetErrors();
        ResetScreenElements();
        ResetVirtualKeyboard();
    }

    private void ResetErrors()
    {
        _errors = 0;
    }

    private void ResetScreenElements()
    {
        imgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
        lblTips.Text = _word.Tips;
        lblWord.Text = new string('_', _word.Text.Length);
    }

    private void ResetVirtualKeyboard()
    {
        foreach (var child in keyboardContainer.Children)
        {
            if (child is HorizontalStackLayout horizontalStack)
            {
                foreach (var innerChild in horizontalStack.Children)
                {
                    if (innerChild is Button button)
                    {
                        button.IsEnabled = true;
                        button.Style = null;
                    }
                }
            }
        }
    }

    private Style GetStyleButton(string key)
    {
        return App.Current.Resources.MergedDictionaries.ElementAt(1)[key] as Style;
    }

    #endregion

    #region Game Logic

    private async Task IsWordGuessed()
    {
        // Check if the player has guessed the entire word
        if (string.Equals(_word.Text, lblWord.Text, StringComparison.OrdinalIgnoreCase))
        {
            // Show congratulations message and reset the screen
            await DisplayAlert("CONGRATULATIONS", "You have guessed the word!", "NEW GAME");

            ResetScreen();
        }
    }

    private async Task IsGameOver()
    {
        // Check if the player has reached the maximum number of errors
        if (_errors >= 6)
        {
            // Show game over message and reset the screen
            await DisplayAlert("GAME OVER", $"You have made too many mistakes. The word was: {_word.Text}", "NEW GAME");

            ResetScreen();
        }
    }

    #endregion

    #region Event Handlers

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;

        // Disable the button after it has been clicked
        button.IsEnabled = false;

        string letter = button.Text;

        if (_word.Text.Contains(letter))
        {
            // If the letter is correct, update the displayed word
            char[] displayedWord = UpdateWordDisplay(letter);

            // Update the label with the new displayed word
            lblWord.Text = new string(displayedWord);

            // Change the button style to indicate success
            button.Style = GetStyleButton("Success");

            await IsWordGuessed();
        }
        else
        {
            ProcessWrongLetter(button);
            await IsGameOver();
        }
    }

    private void OnButtonResetGame_Clicked(object sender, EventArgs e)
    {
        ResetScreen();
    }

    #endregion
}
