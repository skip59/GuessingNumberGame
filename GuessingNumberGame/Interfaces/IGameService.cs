using GuessingNumberGame.Models;

namespace GuessingNumberGame.Interfaces
{
    public interface IGameService
    {
        void StartGame(ISettings settings);
        string Guess(int guess);
        IGameState GetGameState();
    }
}
