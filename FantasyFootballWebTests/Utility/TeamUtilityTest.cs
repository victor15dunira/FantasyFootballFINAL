using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Binding;
using FantasyFootballWebLibrary.Models.Views;
using FantasyFootballWebLibrary.Utility;
using System;
using System.Collections.Generic;
using Xunit;

namespace FantasyFootballWebTests.Utility
{
    public class TeamUtilityTest
    {
        [Fact]
        public void GetViewModel()
        {

            //Arrange
            Team testTeam = new Team()
            {
                ID = 1,
                Name ="Arsenal",
                PictureURL= "https://www.drafthound.com/_nuxt/img/fanteam-shield-blue.e4be520.png",
                Numberofplayers= Numberofplayers.One,
                TeamColour="Red",
                CreatedAt= DateTime.Now.AddMonths(-2)
            
            };

            //Act
            var testTeamVM = testTeam.GetViewModel();
            //Assert
            Assert.IsType<TeamViewModel>(testTeamVM); //confirm that testteamvm is of type teamviewmodel
            Assert.NotNull(testTeamVM); //confirm that it is not null

        }


        [Fact]
        public void GetViewModels()
        {
            //Arrange
            List<Team> testTeams = new List<Team>()
            {
                new Team()


                   {
                ID = 1,
                Name ="Arsenal",
                PictureURL= "https://www.drafthound.com/_nuxt/img/fanteam-shield-blue.e4be520.png",
                Numberofplayers= Numberofplayers.One,
                TeamColour="Red",
                CreatedAt= DateTime.Now.AddMonths(-2)

            }, new Team()


                   {
                ID = 2,
                Name ="Liverpool",
                PictureURL= "https://www.drafthound.com/_nuxt/img/fanteam-shield-blue.e4be520.png",
                Numberofplayers= Numberofplayers.Five,
                TeamColour="Red",
                CreatedAt= DateTime.Now.AddMonths(-4)

            },new Team()


                   {
                ID = 3,
                Name ="Norwich",
                PictureURL= "https://www.drafthound.com/_nuxt/img/fanteam-shield-blue.e4be520.png",
                Numberofplayers= Numberofplayers.Three,
                TeamColour="Yellow",
                CreatedAt= DateTime.Now.AddMonths(-5)

            },


        };

            //Act

            var testTeamsVM = testTeams.GetViewModels();

            //Assert
            Assert.NotEmpty(testTeamsVM);
            Assert.IsType<List<TeamViewModel>>(testTeamsVM);
        }

    }
}
