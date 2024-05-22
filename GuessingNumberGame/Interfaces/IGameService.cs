using GuessingNumberGame.Models;

namespace GuessingNumberGame.Interfaces
{
    public interface IGameService
    {
        void StartGame(Settings settings);
        string Guess(int guess);
        GameState GetGameState();
    }
}
