using TetelekOlvaso.Models;
using TetelekOlvaso.Services;

namespace TetelekOlvaso.Pages;

public partial class QuizTetelSelectPage : ContentPage
{
    private readonly QuizService _quizService = new();
    private readonly TetelTitleService _tetelTitleService = new();

    public QuizTetelSelectPage()
    {
        InitializeComponent();

        ToolbarItems.Add(new ToolbarItem("Vissza", null, async () =>
        {
            await Navigation.PopModalAsync();
        }));

        LoadTetels();
    }

    private void LoadTetels()
    {
        var availableTetels = _quizService.GetAvailableTetelNumbers();
        var tetels = _tetelTitleService.GetTetelsByNumbers(availableTetels);
        TetelCollectionView.ItemsSource = tetels;
    }

    private async void TetelTapped(object? sender, TappedEventArgs e)
    {
        if (sender is Frame frame && frame.BindingContext is TetelListItem tetel)
        {
            await Navigation.PushModalAsync(new QuizPage(tetel.Order, tetel.Title));
        }
    }
}