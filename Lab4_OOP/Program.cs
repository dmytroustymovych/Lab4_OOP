using Lab4_OOP.Commands;
using Lab4_OOP.DB_context;
using Lab4_OOP.Repository;
using Lab4_OOP.Service;

public class Program
{
    public static void Main(string[] args)
    {
        int commandNumber = 0;

        var dbContext = new DbContext();
        var gameAccountRepository = new GameAccountRepository(dbContext);
        var gameRepository = new GameRepository(dbContext);
        var gameAccountService = new GameAccountService(gameAccountRepository);
        var gameService = new GameService(gameRepository, gameAccountRepository);


        var commandMenu = new MenegmentCommand();
        commandMenu.RegisterCommand(new ExitProgram());
        commandMenu.RegisterCommand(new AddPlayerCommand(gameAccountService));
        commandMenu.RegisterCommand(new PlayGameCommand(gameService));
        commandMenu.RegisterCommand(new DeletePlayerCommand(gameAccountService));
        commandMenu.RegisterCommand(new ShowPlayerCommand(gameAccountService));
        commandMenu.RegisterCommand(new ShowAllPlayersCommand(gameAccountService));

        while (commandNumber != 1)
        {
            Console.WriteLine("---- Main Menu ----");
            commandMenu.ShowMenu();

            commandNumber = int.Parse(Console.ReadLine());

            commandMenu.ExecuteCommand(commandNumber);


        }
    }
}
