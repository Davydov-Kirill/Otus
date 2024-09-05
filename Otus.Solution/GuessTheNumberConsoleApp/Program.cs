using GuessTheNumber.Console;

namespace GuessTheNumberConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var numberGenerator = new RandomNumberGenerator();
            var gameLogic = new GuessTheNumberGame(numberGenerator);
            var gameUI = new GameUI();
            var difficultyLevelSelector = new DifficultyLevelSelector();

            gameUI.DisplayWelcomeMessage();

            while (true)
            {
                int difficultyLevel = difficultyLevelSelector.GetDifficultyLevel();

                if (difficultyLevel == 0) break;

                gameLogic.StartGame(difficultyLevel);

                while (!gameLogic.IsGameOver())
                {
                    int userInput = new UserInput().GetUserGuess();

                    if (gameLogic.IsGuessedNumber(userInput)) break;
                }

                gameUI.DisplayGameResult(gameLogic.IsWin, gameLogic.GetTargetNumber());

                Console.WriteLine();
            }
        }
    }
}
