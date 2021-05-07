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

         ITeamRepository _teams;
        IPlayerRepository _players;

         void Save()
        {
            throw new NotImplementedException();
        }
    }
}
