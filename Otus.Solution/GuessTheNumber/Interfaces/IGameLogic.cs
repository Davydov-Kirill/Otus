namespace GuessTheNumber.Interfaces
{
    public interface IGameLogic
    {
        void StartGame(int difficultyLevel);
        bool IsGuessedNumber(int guess);
        bool IsGameOver();
    }
}
