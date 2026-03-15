namespace TetelekOlvaso.Models
{
    public class PersonQuestion
    {
        public int TetelNumber { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Answers { get; set; } = new();
        public string CorrectAnswer { get; set; } = string.Empty;
    }
}