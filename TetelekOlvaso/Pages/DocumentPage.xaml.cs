using TetelekOlvaso.Models;
using TetelekOlvaso.Services;

namespace TetelekOlvaso.Pages;

public partial class DocumentPage : ContentPage
{
    private readonly DocumentItem _document;
    private readonly DocumentService _documentService = new();
    private bool _isLoaded;

    public DocumentPage(DocumentItem document)
    {
        InitializeComponent();

        _document = document;
        Title = "Olvasó";
        TitleLabel.Text = document.Title;
        ContentLabel.Text = "Betöltés...";

        ToolbarItems.Add(new ToolbarItem("Vissza", null, async () =>
        {
            await Navigation.PopModalAsync();
        }));
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (_isLoaded)
            return;

        _isLoaded = true;

        try
        {
            ContentLabel.Text = await _documentService.ReadDocumentContentAsync(_document.FileName);
        }
        catch (Exception ex)
        {
            ContentLabel.Text = $"Hiba a dokumentum betöltésekor:\n{ex.Message}";
        }
    }
}