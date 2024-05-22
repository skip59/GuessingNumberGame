﻿using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;

namespace GuessingNumberGame.Services
{
    public class GameService : IGameService
    {
        private GameState _gameState;
        private Settings _gameSettings;

        public void StartGame(Settings settings)
        {
            _gameSettings = settings;
            _gameState = new GameState
            {
                TargetNumber = new Random().Next(_gameSettings.MinNumber, _gameSettings.MaxNumber + 1),
                Attempts = _gameSettings.MaxAttempts
            };
        }

        public string Guess(int guess)
        {
            if (_gameState.Attempts <= 0)
                return "Попыток больше не осталось, игра окончена";

            _gameState.Attempts--;

            if (guess < _gameState.TargetNumber)
                return "Введенное число меньше";
            if (guess > _gameState.TargetNumber)
                return "Введенное число больше";

            return "ПОЗДРАВЛЯЕМ, Вы угадали число.";
        }

        public GameState GetGameState()
        {
            return _gameState;
        }
    }
}