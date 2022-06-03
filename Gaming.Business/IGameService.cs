using Gaming.Entities;
using Gaming.TransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.Business
{
    public interface IGameService
    {
        Task<IList<GameDisplayResponse>> GetGamesAsync();
        Task<GameDisplayResponse> GetGame(int id);
        Task<IList<GameDisplayResponse>> GetGameByName(string name);
        
    }
}
