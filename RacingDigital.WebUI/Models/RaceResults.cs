namespace RacingDigital.WebUI.Models
{
    public class RaceResults
    {
        public int Id { get; set; }
        public string Race { get; set; } = string.Empty;
        public DateTime RaceDate { get; set; }
        public int RaceTime { get; set; }
        public string Racecourse { get; set; } = string.Empty;
        public int RaceDistance { get; set; }
        public string Jockey { get; set; } = string.Empty;
        public string Trainer { get; set; } = string.Empty;
        public string Horse { get; set; } = string.Empty;
        public int FinishingPosition { get; set; }
        public double DistanceBeaten { get; set; }
        public double TimeBeaten { get; set; }

        public bool Note { get; set; } = false;
    }
}
