using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;

namespace GuessingNumberGame.Services
{
    public class GameGuessWordService : IGameService
    {
        private GameState _gameState;
        private SettingsGuessWord _gameSettings;
        public IGameState GetGameState()
        {
            return _gameState;
        }

        public void StartGame(ISettings settings)
        {
            _gameSettings = settings as SettingsGuessWord;
            _gameState = new GameState
            {
                TargetWord = _gameSettings.Words[new Random().Next(_gameSettings.Words.Count + 1)],
                Attempts = _gameSettings.MaxAttempts
            };
        }
        public string TryGuess<T>(T guess)
        {
            if (guess is string _guess)
            {
                if (_gameState.Attempts <= 0)
                    return "Попыток больше не осталось, игра окончена";

                _gameState.Attempts--;

                if (_guess == _gameState.TargetWord) return "ПОЗДРАВЛЯЕМ, Вы угадали слово.";

                return "Не угадали) Попробуйте еще раз.";
            }

            return string.Empty;
        }
    }
}
