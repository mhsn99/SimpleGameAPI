using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Gaming.DataAccess.Repositories;
using Gaming.Entities;
using Gaming.TransferObjects.Responses;

namespace Gaming.Business
{
    public class GameService: IGameService
    {
        private List<Game> games;
        private readonly IMapper mapper;
        private readonly IGameRepository gameRepository;
        public GameService(IGameRepository gameRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.gameRepository = gameRepository;
        }

        public async Task<IList<GameDisplayResponse>> GetGamesAsync()
        {
            var games = await gameRepository.GetAll();
            var result = mapper.Map<IList<GameDisplayResponse>>(games);

            return result;
        }

        public async Task<GameDisplayResponse> GetGame(int id)
        {
            var game = await gameRepository.GetById(id);
            var gameDisplayResponse = mapper.Map<GameDisplayResponse>(game);
            return gameDisplayResponse;
        }

        public async Task<IList<GameDisplayResponse>> GetGameByName(string name)
        {
            var game = await gameRepository.GetGameByName(name);
            var result = mapper.Map<IList<GameDisplayResponse>>(game);
            return result;
        }
    }
}
