namespace FootballPlayerTeamAPI.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
