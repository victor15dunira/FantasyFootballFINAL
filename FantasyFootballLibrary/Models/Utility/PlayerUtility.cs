using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Views;
using System.Collections.Generic;

namespace FantasyFootballWebLibrary.Utility
{
    public static class PlayerUtility
    {
        public static PlayerViewModel GetViewModel(this Player player)
        {
            var playerVM = new PlayerViewModel()
            {
                
                ID = player.ID,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Height = player.Height,
                Position = player.Position,
                PictureURL = player.PictureURL,
                CreatedAt = player.CreatedAt

            };
            return playerVM;
        }
        public static List<PlayerViewModel> GetViewModels(this List<Player> players)
        {
            var allplayersVM = new List<PlayerViewModel>();
            foreach (var player in players)
            {
                allplayersVM.Add(new PlayerViewModel()
                {
                    ID = player.ID,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Height = player.Height,
                    Position = player.Position,
                    PictureURL = player.PictureURL,
                    CreatedAt = player.CreatedAt
                });
            }
            return allplayersVM;
        }
    }
}