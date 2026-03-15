using System.Collections.ObjectModel;
using TetelekOlvaso.Models;
using TetelekOlvaso.Services;

namespace TetelekOlvaso.Pages;

public partial class TetelekPage : ContentPage
{
    private readonly DocumentService _documentService = new();
    private readonly List<DocumentItem> _allDocuments = new();
    private bool _isLoaded;

    public ObservableCollection<DocumentItem> FilteredDocuments { get; } = new();

    public TetelekPage()
    {
        InitializeComponent();
        BindingContext = this;
        DocumentsCollectionView.ItemsSource = FilteredDocuments;

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
        await LoadDocumentsAsync();
    }

    private async Task LoadDocumentsAsync()
    {
        try
        {
            var docs = await _documentService.LoadDocumentsAsync();

            _allDocuments.Clear();
            _allDocuments.AddRange(docs);

            FilterDocuments(SearchBarDocs.Text);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Hiba", $"Nem sikerült betölteni a dokumentumokat.\n\n{ex.Message}", "OK");
        }
    }

    private void SearchBarDocs_TextChanged(object sender, TextChangedEventArgs e)
    {
        FilterDocuments(e.NewTextValue);
    }

    private void FilterDocuments(string? searchText)
    {
        FilteredDocuments.Clear();

        var filtered = string.IsNullOrWhiteSpace(searchText)
            ? _allDocuments
            : _allDocuments.Where(d => d.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();

        foreach (var doc in filtered)
        {
            FilteredDocuments.Add(doc);
        }
    }

    private async void DocumentTapped(object? sender, TappedEventArgs e)
    {
        if (sender is Frame frame && frame.BindingContext is DocumentItem selectedDocument)
        {
            await Navigation.PushModalAsync(new DocumentPage(selectedDocument));
        }
    }
}