using System.Collections.Generic;

namespace FootballPlayerTeamAPI.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
        public int FoundedYear { get; set; }
        public string Coach { get; set; }
        public List<Player> Players { get; set; }
    }
}
