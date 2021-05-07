using FantasyFootballLibrary.Data;
using FantasyFootballLibrary.Interfaces;
using FantasyFootballWebLibrary.Models;

namespace FantasyFootballLibrary.Respositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
