using Microsoft.EntityFrameworkCore;
using FootballPlayerTeamAPI.Models;
using System;

namespace FootballPlayerTeamAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for teams
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = 1, Name = "FC Barcelona", Stadium = "Camp Nou", FoundedYear = 1899, Coach = "Xavi" },
                new Team { TeamId = 2, Name = "Real Madrid", Stadium = "Santiago Bernabéu", FoundedYear = 1902, Coach = "Carlo Ancelotti" },
                new Team { TeamId = 3, Name = "Manchester United", Stadium = "Old Trafford", FoundedYear = 1878, Coach = "Ralf Rangnick" },
                new Team { TeamId = 4, Name = "Bayern Munich", Stadium = "Allianz Arena", FoundedYear = 1900, Coach = "Julian Nagelsmann" },
                new Team { TeamId = 5, Name = "Liverpool FC", Stadium = "Anfield", FoundedYear = 1892, Coach = "Jürgen Klopp" },
                new Team { TeamId = 6, Name = "Juventus FC", Stadium = "Allianz Stadium", FoundedYear = 1897, Coach = "Massimiliano Allegri" },
                new Team { TeamId = 7, Name = "Paris Saint-Germain", Stadium = "Parc des Princes", FoundedYear = 1970, Coach = "Mauricio Pochettino" },
                new Team { TeamId = 8, Name = "Chelsea FC", Stadium = "Stamford Bridge", FoundedYear = 1905, Coach = "Thomas Tuchel" },
                new Team { TeamId = 9, Name = "AC Milan", Stadium = "San Siro", FoundedYear = 1899, Coach = "Stefano Pioli" },
                new Team { TeamId = 10, Name = "Manchester City", Stadium = "Etihad Stadium", FoundedYear = 1880, Coach = "Pep Guardiola" },
                new Team { TeamId = 11, Name = "Arsenal FC", Stadium = "Emirates Stadium", FoundedYear = 1886, Coach = "Mikel Arteta" },
                new Team { TeamId = 12, Name = "Tottenham Hotspur", Stadium = "Tottenham Hotspur Stadium", FoundedYear = 1882, Coach = "Antonio Conte" },
                new Team { TeamId = 13, Name = "Inter Milan", Stadium = "San Siro", FoundedYear = 1908, Coach = "Simone Inzaghi" },
                new Team { TeamId = 14, Name = "Atletico Madrid", Stadium = "Wanda Metropolitano", FoundedYear = 1903, Coach = "Diego Simeone" },
                new Team { TeamId = 15, Name = "Borussia Dortmund", Stadium = "Signal Iduna Park", FoundedYear = 1909, Coach = "Marco Rose" },
                new Team { TeamId = 16, Name = "Ajax Amsterdam", Stadium = "Johan Cruyff Arena", FoundedYear = 1900, Coach = "Erik ten Hag" },
                new Team { TeamId = 17, Name = "FC Porto", Stadium = "Estádio do Dragão", FoundedYear = 1893, Coach = "Sérgio Conceição" },
                new Team { TeamId = 18, Name = "Benfica", Stadium = "Estádio da Luz", FoundedYear = 1904, Coach = "Nelson Veríssimo" },
                new Team { TeamId = 19, Name = "Sevilla FC", Stadium = "Ramón Sánchez-Pizjuán", FoundedYear = 1890, Coach = "Julen Lopetegui" },
                new Team { TeamId = 20, Name = "RB Leipzig", Stadium = "Red Bull Arena", FoundedYear = 2009, Coach = "Jesse Marsch" }
            );

            // Seed data for players
            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, Name = "Lionel Messi", Position = "Forward",Age= 37, DateOfBirth = new DateTime(1987, 6, 24), TeamId = 1 },
                new Player { PlayerId = 2, Name = "Cristiano Ronaldo", Position = "Forward",Age = 39, DateOfBirth = new DateTime(1985, 2, 5), TeamId = 3 },
                new Player { PlayerId = 3, Name = "Kylian Mbappé", Position = "Forward",Age = 25, DateOfBirth = new DateTime(1998, 12, 20), TeamId = 1 },
                new Player { PlayerId = 4, Name = "Robert Lewandowski", Position = "Forward",Age = 35, DateOfBirth = new DateTime(1988, 8, 21), TeamId = 4 },
                new Player { PlayerId = 5, Name = "Mohamed Salah", Position = "Forward",Age = 32, DateOfBirth = new DateTime(1992, 6, 15), TeamId = 5 },
                new Player { PlayerId = 6, Name = "Neymar Jr", Position = "Forward", Age = 32,DateOfBirth = new DateTime(1992, 2, 5), TeamId = 7 },
                new Player { PlayerId = 7, Name = "Kevin De Bruyne", Position = "Midfielder", Age = 33, DateOfBirth = new DateTime(1991, 6, 28), TeamId = 10 },
                new Player { PlayerId = 8, Name = "Virgil van Dijk", Position = "Defender", Age = 33,DateOfBirth = new DateTime(1991, 7, 8), TeamId = 5 },
                new Player { PlayerId = 9, Name = "Sergio Ramos", Position = "Defender", Age = 38, DateOfBirth = new DateTime(1986, 3, 30), TeamId = 2 },
                new Player { PlayerId = 10, Name = "Paul Pogba", Position = "Midfielder",Age = 31, DateOfBirth = new DateTime(1993, 3, 15), TeamId = 3 },
                new Player { PlayerId = 11, Name = "Eden Hazard", Position = "Forward",Age = 33, DateOfBirth = new DateTime(1991, 1, 7), TeamId = 2 },
                new Player { PlayerId = 12, Name = "Sadio Mané", Position = "Forward",Age =32, DateOfBirth = new DateTime(1992, 4, 10), TeamId = 5 },
                new Player { PlayerId = 13, Name = "Bruno Fernandes", Position = "Midfielder", Age = 29, DateOfBirth = new DateTime(1994, 9, 8), TeamId = 3 },
                new Player { PlayerId = 14, Name = "Romelu Lukaku", Position = "Forward",Age = 31, DateOfBirth = new DateTime(1993, 5, 13), TeamId = 13 },
                new Player { PlayerId = 15, Name = "Harry Kane", Position = "Forward", Age = 30, DateOfBirth = new DateTime(1993, 7, 28), TeamId = 12 },
                new Player { PlayerId = 16, Name = "Luis Suárez", Position = "Forward", Age = 37, DateOfBirth = new DateTime(1987, 1, 24), TeamId = 14 },
                new Player { PlayerId = 17, Name = "Angel Di María", Position = "Midfielder",Age = 36, DateOfBirth = new DateTime(1988, 2, 14), TeamId = 7 },
                new Player { PlayerId = 18, Name = "Thomas Müller", Position = "Forward",Age = 34, DateOfBirth = new DateTime(1989, 9, 13), TeamId = 4 },
                new Player { PlayerId = 19, Name = "Gareth Bale", Position = "Forward", Age = 34, DateOfBirth = new DateTime(1989, 7, 16), TeamId = 2 },
                new Player { PlayerId = 20, Name = "Erling Haaland", Position = "Forward", Age = 23,DateOfBirth = new DateTime(2000, 7, 21), TeamId = 15 }
        );
        }
    }
}
