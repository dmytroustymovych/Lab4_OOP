using Lab4_OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Repository
{
    public interface IGameRepository
    {
        void AddGame(Game game);
        List<Game> GetAllGames();

        void DeleteGame(int gameId);

    }
}
