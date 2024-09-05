namespace GuessTheNumber.Interfaces
{
    public interface IGameUI
    {
        void DisplayWelcomeMessage();
        void DisplayGameResult(bool isWin, int targetNumber);
    }
}
