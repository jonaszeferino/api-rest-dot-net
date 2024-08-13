namespace FutebolAPI.Models
{
    public class Partida
    {
        public string Id { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime MatchTime { get; set; }
        public string Stadium { get; set; } = string.Empty;
        public string ScoreHomeTeam { get; set; } = string.Empty;
        public string ScoreAwayTeam { get; set; } = string.Empty;
        public string? Winner { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVisible { get; set; }
        public string Championship { get; set; } = string.Empty;
        public string? Location { get; set; }
        public string ChampionshipId { get; set; } = string.Empty;
        public string HomeTeamName { get; set; } = string.Empty;
        public string HomeTeamLogo { get; set; } = string.Empty;
        public string AwayTeamName { get; set; } = string.Empty;
        public string AwayTeamLogo { get; set; } = string.Empty;
        public string ChampionshipLogo { get; set; } = string.Empty;
    }
}