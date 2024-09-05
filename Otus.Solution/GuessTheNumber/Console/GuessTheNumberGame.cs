using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Console
{
    public class GuessTheNumberGame : IGameLogic
    {
        private readonly INumberGenerator _numberGenerator;
        private int _targetNumber;
        private int _attemptCount;
        private int _maxAttempts;

        private bool _isWin;
        public bool IsWin { get => _isWin; }

        public GuessTheNumberGame(INumberGenerator numberGenerator)
        {
            this._numberGenerator = numberGenerator;
        }

        public void StartGame(int difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case (int)DifficultyLevel.Easy:
                    _targetNumber = _numberGenerator.GenerateNumber(1, 10);
                    _maxAttempts = 5;
                    break;
                case (int)DifficultyLevel.Medium:
                    _targetNumber = _numberGenerator.GenerateNumber(1, 100);
                    _maxAttempts = 7;
                    break;
                case (int)DifficultyLevel.Hard:
                    _targetNumber = _numberGenerator.GenerateNumber(-500, 500);
                    _maxAttempts = 10;
                    break;
            }
            _attemptCount = 0;
        }

        public bool IsGuessedNumber(int guess)
        {
            _attemptCount++;
            _isWin = false;

            if (guess == _targetNumber)
            {
                _isWin = true;
                return true;
            }
            else if (guess < _targetNumber)
            {
                System.Console.WriteLine($"Число {guess} меньше загаданного.");
            }
            else
            {
                System.Console.WriteLine($"Число {guess} больше загаданного.");
            }
            return false;
        }

        public bool IsGameOver() => _attemptCount >= _maxAttempts;

        public int GetTargetNumber() => _targetNumber;
    }
}
