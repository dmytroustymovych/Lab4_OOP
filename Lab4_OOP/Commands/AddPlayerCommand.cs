﻿using Lab4_OOP.Service;


namespace Lab4_OOP.Commands
{
    public class AddPlayerCommand : ICommand
    {
        private readonly IGameAccountService _gameAccountService;

        public AddPlayerCommand(IGameAccountService playerService)
        {
            _gameAccountService = playerService;
        }

        public void Execute()
        {
            try
            {
                Console.Write("Enter player name: ");
                string playerName = Console.ReadLine();

                Console.WriteLine("Enter account type: 1. Standard 2. DoubleRating");
                Console.Write("Select an account type: ");
                int input = int.Parse(Console.ReadLine());

                string accountType = input switch
                {
                    1 => "standard",
                    2 => "doubleRating"

                };

                _gameAccountService.CreateGameAccount(playerName, accountType);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public string GetDescription() => "Add a new player";


    }
}
