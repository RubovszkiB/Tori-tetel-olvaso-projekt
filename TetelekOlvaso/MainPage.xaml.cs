using TetelekOlvaso.Pages;

namespace TetelekOlvaso;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OpenTetelekTapped(object? sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new TetelekPage());
    }

    private async void OpenQuizTapped(object? sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new QuizTetelSelectPage());
    }

    private async void OpenPersonQuizTapped(object? sender, TappedEventArgs e)
    {
        await Navigation.PushModalAsync(new PersonQuizTetelSelectPage());
    }
}