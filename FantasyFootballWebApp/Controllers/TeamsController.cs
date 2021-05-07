using FantasyFootballWebApp.Data;
using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Binding;
using FantasyFootballWebLibrary.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FantasyFootballWebApp.Controllers
{
    [Route("[Controller]")]
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public TeamsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        #region Team
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allTeams = dbContext.Teams.ToList();
            return View(allTeams);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var TeamById = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            return View(TeamById);
        }
        //CREATE
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddTeamBindingModel bindingModel)
        {
            var teamToCreate = new Team
            {
                Name = bindingModel.Name,
                Numberofplayers = bindingModel.Numberofplayers,
                TeamColour = bindingModel.TeamColour,
                PictureURL = "https://www.drafthound.com/_nuxt/img/fanteam-shield-blue.e4be520.png",
                CreatedAt = DateTime.Now
            };
            dbContext.Teams.Add(teamToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var teamById = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            return View(teamById);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Team team, int id)
        {
            var teamToUpdate = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            teamToUpdate.Name = team.Name;
            teamToUpdate.PictureURL = team.PictureURL;
            teamToUpdate.Numberofplayers = team.Numberofplayers;
            teamToUpdate.TeamColour = team.TeamColour;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var teamToDelete = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            dbContext.Teams.Remove(teamToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        #region Player
        //player Section
        //CREATE
        [Route("addplayer/{teamID:int}")]
        public IActionResult CreatePlayer(int TeamID)
        {
            var team = dbContext.Teams.FirstOrDefault(t => t.ID == TeamID);
            ViewBag.TeamName = team.Name;
            return View();
        }
        [HttpPost]
        [Route("addplayer/{teamID:int}")]
        public IActionResult CreatePlayer(AddPlayerBindingModel bindingModel, int teamID)
        {
            bindingModel.TeamID = teamID;
            var playerToCreate = new Player
            {
                FirstName = bindingModel.FirstName,
                LastName = bindingModel.LastName,
                Height = bindingModel.Height,
                Position = bindingModel.Position,
                Team = dbContext.Teams.FirstOrDefault(c => c.ID == teamID),
                PictureURL = "https://freepngimg.com/download/football/66114-soccer-photography-football-royalty-free-player-stock-playing.png",
                CreatedAt = DateTime.Now
            };
            dbContext.Players.Add(playerToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/players")]
        public IActionResult ViewPlayers(int id)
        {
            var team = dbContext.Teams.FirstOrDefault(t => t.ID == id);
            var players = dbContext.Players.Where(t => t.Team.ID == id).ToList();
            ViewBag.TeamName = team.Name;
            return View(players);
        }

       
        #endregion
        //#region Visit
        //[Route("addvisit/{teamID:int}")]
        //public IActionResult CreateVisit(int teamID)
        //{
        //    var team = dbContext.Teams.FirstOrDefault(t => t.ID == teamID);
        //    ViewBag.TeamName = team.Name;
        //    var pageInject = new AddVisitBindingModel { Vets = dbContext.Vets.ToList().GetViewModels() };
        //    return View(pageInject);
        //}
        //[HttpPost]
        //[Route("addvisit/{teamID:int}")]
        //public IActionResult CreateVisit(AddVisitBindingModel bindingModel, int teamID)
        //{
        //    var visitToCreate = new Visit
        //    {
        //        VisitDate = DateTime.Now,
        //        Vet = dbContext.Vets.FirstOrDefault(v => v.ID == bindingModel.VetID),
        //        Team = dbContext.Teams.FirstOrDefault(c => c.ID == teamID)
        //    };
        //    dbContext.Visits.Add(visitToCreate);
        //    dbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //[Route("{id:int}/Visits")]
        //public IActionResult ViewVisits(int id)
        //{
        //    var cat = dbContext.Cats.FirstOrDefault(c => c.ID == id);
        //    var Visits = dbContext.Visits.Where(c => c.Cat.ID == id).ToList();
        //    ViewBag.CatName = cat.Name;
        //    return View(Visits);
        //}
        //#endregion
    }
}