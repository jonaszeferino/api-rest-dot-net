using FutebolAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FutebolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidasController : ControllerBase
    {
        private static readonly List<Partida> Partidas = new List<Partida>
        {
            new Partida {
                Id = "8",
                CreatedAt = DateTime.Parse("2024-08-09T03:22:25.708Z"),
                MatchTime = DateTime.Parse("2024-08-11T01:00:00.000Z"),
                Stadium = "Arena Pantanal",
                ScoreHomeTeam = "0",
                ScoreAwayTeam = "0",
                Winner = null,
                IsDeleted = false,
                IsVisible = true,
                Championship = "Campeonato Campeonato Brasileiro Série A",
                Location = null,
                ChampionshipId = "3",
                HomeTeamName = "Cuiabá",
                HomeTeamLogo = "https://i.imgur.com/VwUJH5L.png",
                AwayTeamName = "Grêmio",
                AwayTeamLogo = "https://i.imgur.com/hEdikGr.png",
                ChampionshipLogo = "https://i.imgur.com/1kZH0n4.png"
            },
            new Partida {
                Id = "10",
                CreatedAt = DateTime.Parse("2024-08-09T03:24:42.437Z"),
                MatchTime = DateTime.Parse("2024-08-12T01:00:00.000Z"),
                Stadium = "Beira-Rio",
                ScoreHomeTeam = "0",
                ScoreAwayTeam = "0",
                Winner = null,
                IsDeleted = false,
                IsVisible = true,
                Championship = "Campeonato Campeonato Brasileiro Série A",
                Location = null,
                ChampionshipId = "3",
                HomeTeamName = "Internacional",
                HomeTeamLogo = "https://i.imgur.com/ZW1a1Nh.png",
                AwayTeamName = "Athletico Paranaense",
                AwayTeamLogo = "https://i.imgur.com/f1Pwc1d.png",
                ChampionshipLogo = "https://i.imgur.com/1kZH0n4.png"
            },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Partida>> Get()
        {
            return Ok(Partidas);
        }
    }
}