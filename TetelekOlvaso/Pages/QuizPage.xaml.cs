using TetelekOlvaso.Models;
using TetelekOlvaso.Services;

namespace TetelekOlvaso.Pages;

public partial class QuizPage : ContentPage
{
    private readonly QuizService _quizService = new();
    private readonly int _tetelNumber;
    private readonly string _tetelTitle;
    private List<YearQuestion> _questions = new();
    private int _currentIndex = 0;
    private int _score = 0;

    public QuizPage(int tetelNumber, string tetelTitle)
    {
        InitializeComponent();

        _tetelNumber = tetelNumber;
        _tetelTitle = tetelTitle;
        TetelLabel.Text = $"{tetelNumber}. tétel – {_tetelTitle}";

        ToolbarItems.Add(new ToolbarItem("Vissza", null, async () =>
        {
            await Navigation.PopModalAsync();
        }));

        LoadQuiz();
    }

    private void LoadQuiz()
    {
        _questions = _quizService.GetQuestionsForTetel(_tetelNumber);
        _currentIndex = 0;
        _score = 0;
        ScoreLabel.Text = "Pontszám: 0";
        LoadCurrentQuestion();
    }

    private void LoadCurrentQuestion()
    {
        if (_questions.Count == 0)
        {
            QuestionLabel.Text = "Ehhez a tételhez még nincs kérdés.";
            ResultLabel.Text = "Később feltöltjük.";
            HideAnswerButtons();
            return;
        }

        if (_currentIndex >= _questions.Count)
        {
            QuestionLabel.Text = "Vége a gyakorlásnak!";
            ResultLabel.Text = $"Elért pontszám: {_score}/{_questions.Count}";
            HideAnswerButtons();
            return;
        }

        var q = _questions[_currentIndex];
        QuestionLabel.Text = q.Question;
        ResultLabel.Text = "";

        AnswerButton1.Text = q.Answers[0];
        AnswerButton2.Text = q.Answers[1];
        AnswerButton3.Text = q.Answers[2];
        AnswerButton4.Text = q.Answers[3];

        ShowAnswerButtons();
    }

    private async void AnswerButton_Clicked(object sender, EventArgs e)
    {
        if (sender is not Button button || _currentIndex >= _questions.Count)
            return;

        var current = _questions[_currentIndex];

        DisableAnswerButtons();

        if (button.Text == current.CorrectAnswer)
        {
            _score++;
            ResultLabel.Text = "✅ Helyes!";
        }
        else
        {
            ResultLabel.Text = $"❌ Rossz. A helyes válasz: {current.CorrectAnswer}";
        }

        ScoreLabel.Text = $"Pontszám: {_score}";

        await Task.Delay(1100);

        _currentIndex++;
        LoadCurrentQuestion();
    }

    private void HideAnswerButtons()
    {
        AnswerButton1.IsVisible = false;
        AnswerButton2.IsVisible = false;
        AnswerButton3.IsVisible = false;
        AnswerButton4.IsVisible = false;
    }

    private void ShowAnswerButtons()
    {
        AnswerButton1.IsVisible = true;
        AnswerButton2.IsVisible = true;
        AnswerButton3.IsVisible = true;
        AnswerButton4.IsVisible = true;

        AnswerButton1.IsEnabled = true;
        AnswerButton2.IsEnabled = true;
        AnswerButton3.IsEnabled = true;
        AnswerButton4.IsEnabled = true;
    }

    private void DisableAnswerButtons()
    {
        AnswerButton1.IsEnabled = false;
        AnswerButton2.IsEnabled = false;
        AnswerButton3.IsEnabled = false;
        AnswerButton4.IsEnabled = false;
    }
}