using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballLibrary.Interfaces
{
    public interface IRepositoryWrapper
    {
        ITeamRepository Teams { get; }

        IPlayerRepository Players { get; }

        void Save();


    }
}
