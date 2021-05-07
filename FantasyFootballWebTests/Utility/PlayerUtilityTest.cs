using FantasyFootballWebLibrary.Models;
using FantasyFootballWebLibrary.Models.Views;
using FantasyFootballWebLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FantasyFootballWebTests.Utility
{
    public class PlayerUtilityTest
    {

      
            [Fact]
            public void GetViewModel()
            {

                //Arrange
                Player testPlayer = new Player()
                {
                    ID = 1,
                    FirstName = "Victor",
                    LastName = "D",
                    Height = 178,
                    Position = "LW/ST",
                    PictureURL = "https://freepngimg.com/download/football/66114-soccer-photography-football-royalty-free-player-stock-playing.png",
                    CreatedAt = DateTime.Now.AddMonths(-2)

                };

                //Act
                var testPlayerVM = testPlayer.GetViewModel();
                //Assert
                Assert.IsType<PlayerViewModel>(testPlayerVM); //confirm that testteamvm is of type teamviewmodel
                Assert.NotNull(testPlayerVM); //confirm that it is not null

            }


            [Fact]
            public void GetViewModels()
            {
                //Arrange
                List<Player> testPlayers = new List<Player>()
            {
                new Player()

                    {
                    ID = 1,
                    FirstName = "Victor",
                    LastName = "D",
                    Height = 178,
                    Position = "LW/ST",
                    PictureURL = "https://freepngimg.com/download/football/66114-soccer-photography-football-royalty-free-player-stock-playing.png",
                    CreatedAt = DateTime.Now.AddMonths(-2)

                }, new Player()


                    {
                    ID = 2,
                    FirstName = "Dennis",
                    LastName = "Bergkamp",
                    Height = 188,
                    Position = "ST",
                    PictureURL = "https://freepngimg.com/download/football/66114-soccer-photography-football-royalty-free-player-stock-playing.png",
                    CreatedAt = DateTime.Now.AddMonths(-2)

                },new Player()

                  {
                    ID = 3,
                    FirstName = "Harry",
                    LastName = "Baker",
                    Height = 193,
                    Position = "CB",
                    PictureURL = "https://freepngimg.com/download/football/66114-soccer-photography-football-royalty-free-player-stock-playing.png",
                    CreatedAt = DateTime.Now.AddMonths(-2)

                },


        };

                //Act

                var testPlayersVM = testPlayers.GetViewModels();

                //Assert
                Assert.NotEmpty(testPlayersVM);
                Assert.IsType<List<PlayerViewModel>>(testPlayersVM);
            }

        }

}
