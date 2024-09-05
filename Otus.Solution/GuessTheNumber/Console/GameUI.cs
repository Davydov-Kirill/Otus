using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Console
{
    public class GameUI : IGameUI
    {
        public void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Добро пожаловать в игру \"Угадай число\"");
        }

        public void DisplayGameResult(bool isWin, int targetNumber)
        {
            if (isWin)
            {
                System.Console.WriteLine($"Поздравляю. Загаданное число {targetNumber}");
            }
            else
            {
                System.Console.WriteLine($"Извините, вы не угадали число {targetNumber}.");
            }
        }
    }
}
