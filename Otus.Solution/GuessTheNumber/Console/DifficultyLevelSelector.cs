using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Console
{
    public class DifficultyLevelSelector : IDifficultyLevelSelector
    {
        public int GetDifficultyLevel()
        {
            System.Console.WriteLine("Выберите уровень сложности или нажмите \"Enter\" чтобы завершить:");
            System.Console.WriteLine("1. Легкий (1 - 10)");
            System.Console.WriteLine("2. Средний (1 - 100)");
            System.Console.WriteLine("3. Тяжелый (-500 - 500)");

            string? userInput = System.Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
                return 0;

            if (int.TryParse(userInput, out int difficultyLevel)
                && difficultyLevel >= 1 && difficultyLevel <= 3)
                return difficultyLevel;
            else
            {
                System.Console.WriteLine("Введенное значение должно быть числом, больше 1 и меньше 4");
                return -1;
            }
        }
    }
}
