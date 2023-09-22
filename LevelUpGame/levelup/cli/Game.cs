using Sharprompt;
using System.Collections;
namespace levelup.cli;
class Game
{
    static GameController gameController = new GameController();
    static List<GameController.GameStatus> gameHistory = new List<GameController.GameStatus>();
    static Boolean isGameStarted = false;

    public enum startingMenuCommands
    {
        Help,
        CreateCharacter,
        StartGame,
        Exit
    }

    public enum inGameCommands
    {
        Help,
        North,
        South,
        East,
        West,
        Exit
    }
    static void Main(string[] args)
    {
        printWelcomeMessage();

        while (!isGameStarted)
        {
            var type = Prompt.Select<startingMenuCommands>("Choose game command:");

            switch (type)
            {
                case startingMenuCommands.Help:
                    Help();
                    break;
                case startingMenuCommands.CreateCharacter:
                    CreateCharacter();
                    break;
                case startingMenuCommands.Exit:
                    EndGame();
                    break;
                case startingMenuCommands.StartGame:
                    StartGame();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        while (true)
        {
            var type = Prompt.Select<inGameCommands>("Choose game command:");

            switch (type)
            {
                case inGameCommands.Help:
                    Help();
                    break;
                case inGameCommands.Exit:
                    EndGame();
                    break;
                case inGameCommands.North:
                    MoveNorth();
                    break;
                case inGameCommands.South:
                    MoveSouth();
                    break;
                case inGameCommands.East:
                    MoveEast();
                    break;
                case inGameCommands.West:
                    MoveWest();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    static void Help()
    {
        //TODO: FILL OUT USER HELP INSTRUCTIONS
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("HELP!");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Choose a command below using your arrow keys.");
        Console.WriteLine("Once a game is started, you will be able to move and explore.");
        Console.WriteLine("Once you are done exploring, choose Exit to see a summary.");
        Console.WriteLine("-------------------------------------------------");
    }

    private static void printWelcomeMessage()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("LEVEL UP GAMES");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Use your arrow keys to select a command below");
        Console.WriteLine("Create a character with a custom name.");
        Console.WriteLine("Then, start the game to start your adventure.");
        Console.WriteLine("-------------------------------------------------");
    }

    static void CreateCharacter()
    {
        var characterName = Prompt.Input<string>("What is your character's name?");
        gameController.CreateCharacter(characterName);
        var gameStatusCharacterName = gameController.GetStatus().characterName;
        Console.WriteLine($"Your character, {gameStatusCharacterName}, is created!");
    }
    static void StartGame()
    {
        isGameStarted = true;
        gameController.StartGame();
        // TODO: Update this prompt. Also, do you want to get the game status and tell
        // the character where their character is?
        Console.WriteLine("Welcome to Forests and Monsters! You have entered a mysterious place.");

    }
    static void MoveNorth()
    {
        gameController.Move(DIRECTION.NORTH);
        updateStatus(gameController.GetStatus());
        gameHistory.Add(gameController.status);
    }
    static void MoveSouth()
    {
        gameController.Move(DIRECTION.SOUTH);
        updateStatus(gameController.GetStatus());
        gameHistory.Add(gameController.status);
    }
    static void MoveEast()
    {
        gameController.Move(DIRECTION.EAST);
        updateStatus(gameController.GetStatus());
         gameHistory.Add(gameController.status);
    }

    static void MoveWest()
    {
        gameController.Move(DIRECTION.WEST);
        updateStatus(gameController.GetStatus());
        gameHistory.Add(gameController.status);
    }

    static void EndGame()
    {
        var answer = Prompt.Confirm("Do you want to exit?");
        if (answer == true)
        {
            //TODO: PRINT FINAL SUMMARY
            Console.WriteLine("You exit the mysterious world.");
            PrintSummary();
            Environment.Exit(0);
        }
    }

    static void PrintSummary()
    {
        Console.WriteLine("Exiting the mysterious land!");
        foreach (GameController.GameStatus status in gameHistory)
        {
            // TODO: Override toString on game status to print pretty
            Console.WriteLine(string.Format("Character Name: {0}; Current Position: X:{1} ;Y:{2}; Move Count: {3}",status.characterName,status.currentPosition.X, status.currentPosition.Y,status.moveCount));
            Console.WriteLine(status);
        }
        // TODO: Print anything else you committed to in your mockup

    }

    private static void updateStatus(GameController.GameStatus status)
    {
        gameHistory.Add(status);
    }


}