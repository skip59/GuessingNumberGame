using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;

namespace GuessingNumberGame.Services
{
    public class GameService : IGameService
    {
        private GameState _gameState;
        private Settings _gameSettings;

        public void StartGame(ISettings settings)
        {
            _gameSettings = settings as Settings;
            _gameState = new GameState
            {
                TargetNumber = new Random().Next(_gameSettings.MinNumber, _gameSettings.MaxNumber + 1),
                Attempts = _gameSettings.MaxAttempts
            };
        }

        public string TryGuess<T>(T guess)
        {
            if(guess is int _guess)
            {
                if (_gameState.Attempts <= 0)
                    return "Попыток больше не осталось, игра окончена";

                _gameState.Attempts--;

                if (_guess < _gameState.TargetNumber)
                    return "Введенное число меньше";
                if (_guess > _gameState.TargetNumber)
                    return "Введенное число больше";
                return "ПОЗДРАВЛЯЕМ, Вы угадали число.";
            }

            return "ОШИБКА, вы ввели не целочисленное число";
        }

        public IGameState GetGameState()
        {
            return _gameState;
        }

    }
}
