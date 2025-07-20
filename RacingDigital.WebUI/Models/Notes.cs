namespace RacingDigital.WebUI.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string NoteText { get; set; } = string.Empty;
    }
}
