using Gaming.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.DataAccess.Data
{
    public class GameDbContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }

        public GameDbContext(DbContextOptions<GameDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().Property(x => x.GameName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Game>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Game>().HasOne(x => x.Company)
                .WithMany(x => x.Games)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Company>().HasData(
                new Company() { Id = 1, CompanyName = "Rocksteady" },
                new Company() { Id = 2, CompanyName = "Ubisoft" },
                new Company() { Id = 3, CompanyName = "Frogwares" },
                new Company() { Id = 4, CompanyName = "EA Sports" },
                new Company() { Id = 5, CompanyName = "Rare Ltd" },
                new Company() { Id = 6, CompanyName = "Psyonix"}
                );

            modelBuilder.Entity<Game>().HasData(
                 new Game
                 {
                     Id = 1,
                     GameName = "Assassin's Creed II",
                     GamePrice = 45,
                     GameCategory = "Suikastçı",
                     GamePlatform = "PC",
                     CompanyId = 2,
                     GameScore = 4.5
                 },
                new Game
                {
                    Id = 2,
                    GameName = "Batman Arkham Knight",
                    GamePrice = 50,
                    GameCategory = "Süper Kahraman",
                    GamePlatform = "PC",
                    CompanyId = 1,
                    GameScore = 4.2
                },
                new Game
                {
                    Id = 3,
                    GameName = "Sherlock Holmes: Chapter One",
                    GamePrice = 109.45,
                    GameCategory = "Dedektif",
                    GamePlatform = "PC",
                    CompanyId = 3,
                    GameScore = 4.7
                },
                new Game
                {
                    Id = 4,
                    GameName = "Sherlock Holmes: Crimes and Punishments",
                    GamePrice = 39.15,
                    GameCategory = "Dedektif",
                    GamePlatform = "PC",
                    CompanyId = 3,
                    GameScore = 3.9
                },
                new Game
                {
                    Id = 5,
                    GameName = "FIFA 2022",
                    GamePrice = 800,
                    GameCategory = "Futbol",
                    GamePlatform = "Konsol",
                    CompanyId = 4,
                    GameScore = 4.4
                },
                new Game
                {
                    Id = 6,
                    GameName = "Sea of Thieves",
                    GamePrice = 61,
                    GameCategory = "Macera",
                    GamePlatform = "PC",
                    CompanyId = 5,
                    GameScore = 4.6
                },
                new Game
                {
                    Id = 7,
                    GameName = "Rocket League",
                    GamePrice = 0,
                    GameCategory = "Spor",
                    GamePlatform = "PC",
                    CompanyId = 6,
                    GameScore = 4.8
                },
                new Game
                {
                    Id = 8,
                    GameName = "Far Cry 6",
                    GamePrice = 134.15,
                    GameCategory = "Nişancı",
                    GamePlatform = "PC",
                    CompanyId = 2,
                    GameScore = 4.5
                }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
