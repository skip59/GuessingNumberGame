using GuessingNumberGame.Models;

namespace GuessingNumberGame.Interfaces
{
    public interface IGameService
    {
        void StartGame(ISettings settings);
        string TryGuess<T>(T guess);
        IGameState GetGameState();
    }
}
