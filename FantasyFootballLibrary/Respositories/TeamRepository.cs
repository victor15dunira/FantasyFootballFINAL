using FantasyFootballLibrary.Data;
using FantasyFootballLibrary.Interfaces;
using FantasyFootballWebLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFootballLibrary.Respositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext dbContext) : base(dbContext)  //takes dbcontext from Teamrepository injection and passess it into base class, chained to base class 
            {
             } //constrcutor to take the applicatiodbcontext as an arguement 


    }

   
}
