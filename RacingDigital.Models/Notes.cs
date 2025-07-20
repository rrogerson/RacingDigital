namespace RacingDigital.Models
{
    public class Notes : Entity
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string NoteText { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
    }
}
