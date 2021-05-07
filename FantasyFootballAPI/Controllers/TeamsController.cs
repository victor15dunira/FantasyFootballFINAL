using FantasyFootballAPI.Data;
using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Binding;
using FantasyFootballWebLibrary.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFootball.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public TeamsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [HttpGet("")]
        public IActionResult GetAllTeams()
        {
            var allTeams = dbContext.Teams.ToList();
            return Ok(allTeams.GetViewModels());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetTeamById(int id)
        {
            var TeamById = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            if (TeamById == null)
                return NotFound();
            return Ok(TeamById.GetViewModel());
        }
        [HttpPost("")]
        public IActionResult CreateTeam([FromBody] AddTeamBindingModel bindingModel)
        {
            var TeamToCreate = new Team
            {
                Name = bindingModel.Name,
                Numberofplayers = bindingModel.Numberofplayers,
                TeamColour = bindingModel.TeamColour,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            var createdCat = dbContext.Teams.Add(TeamToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(TeamToCreate.GetViewModel());

        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateTeam([FromBody] Team Team, int id)
        {
            var TeamById = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            if (TeamById == null)
                return NotFound();
            TeamById.Name = Team.Name;
            TeamById.PictureURL = Team.PictureURL;
            TeamById.Numberofplayers = Team.Numberofplayers;
            TeamById.TeamColour = Team.TeamColour;
            dbContext.SaveChanges();
            return Ok(TeamById.GetViewModel());
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteTeam(int id)
        {
            var TeamToDelete = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            if (TeamToDelete == null)
                return NotFound();
            dbContext.Teams.Remove(TeamToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }
    }
}