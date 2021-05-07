
using FantasyFootballWebApp.Data;
using FantasyFootballWebLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FantasyFootballWebApp.Controllers
{
    [Route("[Controller]")]
    public class PlayersController : Controller

    {

        private readonly ApplicationDbContext dbContext;
        public PlayersController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allplayers = dbContext.Players.ToList();
            return View(allplayers);
        }
        [Route("details/{id:int}")] //how to uniquely identify individual players 
        public IActionResult Details(int id)
        {
            var playerById = dbContext.Players.FirstOrDefault(t => t.ID == id);
            return View(playerById);
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var playerById = dbContext.Players.FirstOrDefault(t => t.ID == id);
            return View(playerById);
        }


        [HttpPost] //Sending data, create new data in a particular place.
        [Route("update/{id:int}")]
        public IActionResult Update(Player player, int id)
        {

            var playerToUpdate = dbContext.Players.FirstOrDefault(t => t.ID == id);
            playerToUpdate.FirstName = player.FirstName;
            playerToUpdate.LastName = player.LastName;
            playerToUpdate.Height = player.Height;
            playerToUpdate.PictureURL = player.PictureURL;
            playerToUpdate.Position = player.Position;
            dbContext.SaveChanges();
            return RedirectToAction("Index");


        }

        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var playerToDelete = dbContext.Players.FirstOrDefault(t => t.ID == id);
            dbContext.Players.Remove(playerToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}


