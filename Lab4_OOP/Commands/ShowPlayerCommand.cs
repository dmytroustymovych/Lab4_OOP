using Lab4_OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Commands
{
    public class ShowPlayerCommand : ICommand
    {
        private readonly IGameAccountService _playerService;

        public ShowPlayerCommand(IGameAccountService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.Write("Enter player name to view stats: ");
            string player = Console.ReadLine();
            _playerService.ShowGameAccountStats(player);
        }

        public string GetDescription() => "Show player stats";

    }
}
