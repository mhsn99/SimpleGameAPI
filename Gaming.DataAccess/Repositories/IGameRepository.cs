using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming.Entities;

namespace Gaming.DataAccess.Repositories
{
    public interface IGameRepository: IRepository<Game>
    {
        Task<IEnumerable<Game>> GetGameByName(string name);
    }
}
