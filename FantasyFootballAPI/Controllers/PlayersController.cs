using FantasyFootballAPI.Data;
using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Binding;
using FantasyFootballWebLibrary.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FantasyFootball.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PlayersController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpGet("")]
        public IActionResult GetAllPlayers()
        {
            var allplayers = dbContext.Players.ToList();
            return Ok(allplayers.GetViewModels());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetPlayerById(int id)
        {
            var playerById = dbContext.Players.FirstOrDefault(t => t.ID == id);
            if (playerById == null)
                return NotFound();
            return Ok(playerById.GetViewModel());
        }
        [HttpPost("")]
        public IActionResult CreatePlayer([FromBody] AddPlayerBindingModel bindingModel)
        {
            var playerToCreate = new Player
            {
                FirstName = bindingModel.FirstName,
                LastName = bindingModel.LastName,
                Height = bindingModel.Height,
                Position = bindingModel.Position,
                Team = dbContext.Teams.FirstOrDefault(t => t.ID == bindingModel.TeamID),
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            var createdPlayer = dbContext.Players.Add(playerToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(createdPlayer.GetViewModel());

        }
        [HttpPut("{id:int}")]
        public IActionResult UpdatePlayer([FromBody] Player player, int id)
        {
            var playerById = dbContext.Players.FirstOrDefault(c => c.ID == id);
            if (playerById == null)
                return NotFound();
            playerById.FirstName = player.FirstName;
            playerById.LastName = player.LastName;
            playerById.Height = player.Height;
            playerById.PictureURL = player.PictureURL;
            playerById.Position = player.Position;
            dbContext.SaveChanges();
            return Ok(playerById.GetViewModel());
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeletePlayer(int id)
        {
            var playerToDelete = dbContext.Players.FirstOrDefault(t => t.ID == id);
            if (playerToDelete == null)
                return NotFound();
            dbContext.Players.Remove(playerToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }
    }
}