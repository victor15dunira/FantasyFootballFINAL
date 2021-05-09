using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFootballLibrary.Data;
using FantasyFootballLibrary.Interfaces;

namespace FantasyFootballLibrary.Respositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        ApplicationDbContext _repoContext;

        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;

        }

        ITeamRepository _teams;  //private fields 
        IPlayerRepository _players; //private fields which are called bt the classes below


        public ITeamRepository Teams
        {
            get                          //If team is empty create a new team repository and then return the team back
            {
                if (_teams == null)
                {
                    _teams = new TeamRepository(_repoContext);
                }
                return _teams;
            }

        }


        public IPlayerRepository Players
        {
            get
            {
                if (_players == null)
                {
                    _players = new PlayerRepository(_repoContext);
                }
                return _players;
            }

        }

        void IRepositoryWrapper.Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
