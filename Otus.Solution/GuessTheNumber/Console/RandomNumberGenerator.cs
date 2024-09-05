using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Console
{
    public class RandomNumberGenerator : INumberGenerator
    {
        private readonly Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random();
        }

        public int GenerateNumber(int minValue, int maxValue) => _random.Next(minValue, maxValue + 1);
    }
}
