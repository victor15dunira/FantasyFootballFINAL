using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballWebLibrary.Utility
{
    public static class TeamUtility
    {
        public static TeamViewModel GetViewModel(this Team team)
        {
            var teamVM = new TeamViewModel()
            {
                ID = team.ID,
                Name = team.Name,
                Numberofplayers = team.Numberofplayers,
                TeamColour = team.TeamColour,
                PictureURL = team.PictureURL,
                CreatedAt = team.CreatedAt
            };
            return teamVM;
        }
        public static List<TeamViewModel> GetViewModels(this List<Team> teams)
        {
            var allTeamsVM = new List<TeamViewModel>();
            foreach (var team in teams)
            {
                allTeamsVM.Add(new TeamViewModel()
                {
                    ID = team.ID,
                    Name = team.Name,
                    Numberofplayers = team.Numberofplayers,
                    TeamColour = team.TeamColour,
                    PictureURL = team.PictureURL,
                    CreatedAt = team.CreatedAt
                });
            }
            return allTeamsVM;
        }
    }


   


}