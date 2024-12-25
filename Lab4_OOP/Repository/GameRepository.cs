using Lab4_OOP.DB_context;
using Lab4_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly DbContext _context;

        public GameRepository(DbContext context)
        {
            _context = context;
        }

        public void AddGame(Game game)
        {
            _context.Games.Add(game);
        }

        public List<Game> GetAllGames()
        {
            return _context.Games;
        }


        public void DeleteGame(int gameId)
        {
            foreach (var game in _context.Games)
            {
                if (game.GameId == gameId)
                {
                    _context.Games.Remove(game);
                    break;
                }
            }

        }
    }
}
