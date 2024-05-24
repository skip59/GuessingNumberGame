using GuessingNumberGame.Game.Interface;
using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;
using GuessingNumberGame.Services;

namespace GuessingNumberGame.Game.Services
{
    public class WordGameMode : IGameMode
    {
        IGameService gameGuessWord = new GameGuessWordService();
       public void StartGame()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Вы выбрали игру 'Угадай слово'");
            Console.WriteLine("Задайте настройки игры");

            var settings = new SettingsGuessWord();

            Console.WriteLine("Количество попыток:");
            settings.MaxAttempts = int.TryParse(Console.ReadLine(), out int resultAttempts) ? resultAttempts : 0;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Перед вами набор слов, я загадал одно из них. Попробуй угадать?");

            gameGuessWord.StartGame(settings);

            foreach (var word in settings.Words)
            {
                Console.WriteLine(word);
            }
            while (gameGuessWord.GetGameState().Attempts > 0)
            {
                var resultInput = gameGuessWord.TryGuess(Console.ReadLine());
                Console.WriteLine(resultInput);
                if (resultInput.Contains("ПОЗДРАВЛЯЕМ")) break;

            }
            if (gameGuessWord.GetGameState().Attempts == 0) Console.WriteLine("Игра окночена!");
        }
    }
}
