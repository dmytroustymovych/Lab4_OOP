using Lab4_OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Commands
{
    public class ShowAllPlayersCommand : ICommand
    {
        private readonly IGameAccountService _playerService;

        public ShowAllPlayersCommand(IGameAccountService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.WriteLine("All Players:");
            _playerService.ShowAllGameAccounts();
        }

        public string GetDescription() => "Show all players";
    }
}
