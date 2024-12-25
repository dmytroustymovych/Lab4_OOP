using Lab4_OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Commands
{
    public class DeletePlayerCommand : ICommand
    {
        private readonly IGameAccountService _playerService;

        public DeletePlayerCommand(IGameAccountService playerService)
        {
            _playerService = playerService;
        }

        public void Execute()
        {
            Console.WriteLine("Input player name:");
            string usermane = Console.ReadLine();
            _playerService.DeleteGameAccount(usermane);
        }

        public string GetDescription() => "Delete Player";
        
    }
}
