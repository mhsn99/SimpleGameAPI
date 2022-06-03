using Gaming.DataAccess.Data;
using Gaming.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.DataAccess.Repositories
{
    public class EFGameRepository : IGameRepository
    {
        private GameDbContext context;

        public EFGameRepository(GameDbContext context)
        {
            this.context = context;
        }

        public async Task<IList<Game>> GetAll()
        {
            var games = await context.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetById(int id)
        {
           return await context.Games.FindAsync(id);
        }

        public async Task<IEnumerable<Game>> GetGameByName(string name)
        {
            return await context.Games.Where(x => x.GameName.Contains(name)).ToListAsync();
        }
    }
}
