using Lab4_OOP.Repository;
using Lab4_OOP.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Service
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGameAccountRepository _playerRepository;

        public GameService(IGameRepository gameRepository, IGameAccountRepository playerRepository)
        {
            _gameRepository = gameRepository;
            _playerRepository = playerRepository;
        }

        public void PlayGame(string player1Name, string player2Name, bool isWin, string gameType)
        {
            var player1 = _playerRepository.GetGameAccountByName(player1Name);
            var player2 = _playerRepository.GetGameAccountByName(player2Name);



            var (winnerGame, loserGame) = GameFactory.CreateGame(gameType, player1, player2, isWin);
            player1.WinGame(winnerGame);
            player2.LoseGame(loserGame);

            _gameRepository.AddGame(winnerGame);
            _gameRepository.AddGame(loserGame);
        }


        public void ShowAllGames()
        {
            var uniqueGames = _gameRepository.GetAllGames()
                .GroupBy(game => game.GameId)
                .Select(group => group.First());
            Console.WriteLine("All Games:");

            foreach (var game in uniqueGames)
            {
                Console.WriteLine($"Game ID: {game.GameId},  {game.WinnerName} vs {game.OpponentName}");
            }

        }

        public void DeleteGame(int gameId)
        {
            _gameRepository.DeleteGame(gameId);
        }

    }
}
