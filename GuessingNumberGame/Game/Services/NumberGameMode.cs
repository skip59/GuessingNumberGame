using GuessingNumberGame.Game.Interface;
using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;
using GuessingNumberGame.Services;

namespace GuessingNumberGame.Game.Services
{
    public class NumberGameMode : IGameMode
    {
        IGameService game = new GameService();
       public void StartGame()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Вы выбрали игру 'Угадай число'");
            Console.WriteLine("Задайте настройки игры");

            var settings = new Settings();

            Console.WriteLine("Введите диапазон генерации чисел");
            Console.WriteLine("Минимальное число:");

            settings.MinNumber = int.TryParse(Console.ReadLine(), out int resultMin) ? resultMin : 0;
            Console.WriteLine("Максимальное число:");
            settings.MaxNumber = int.TryParse(Console.ReadLine(), out int resultMax) ? resultMax : 0;
            Console.WriteLine("Количество попыток:");
            settings.MaxAttempts = int.TryParse(Console.ReadLine(), out int resultAttempts) ? resultAttempts : 0;
            Console.WriteLine("Настройки сохранены.");

            game.StartGame(settings);
            Console.WriteLine($"Игра началась! Введите число от {settings.MinNumber} до {settings.MaxNumber}");
            while (game.GetGameState().Attempts > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    var resultInput = game.TryGuess(guess);
                    Console.WriteLine(resultInput);
                    if (resultInput.Contains("ПОЗДРАВЛЯЕМ")) break;
                }
                else
                {
                    Console.WriteLine("Не верный ввод. Повторите попытку");
                }
            }
            if (game.GetGameState().Attempts == 0) Console.WriteLine("Игра окончена!");
        }
    }
}
