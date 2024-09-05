using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Console
{
    public class UserInput : IUserInput
    {
        public int GetUserGuess()
        {
            System.Console.Write("Введите ваше число: ");
            int.TryParse(System.Console.ReadLine(), out int number);
            return number;
        }
    }
}
