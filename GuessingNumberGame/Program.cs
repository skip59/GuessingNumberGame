using GuessingNumberGame.Interfaces;
using GuessingNumberGame.Models;
using GuessingNumberGame.Services;

namespace GuessingNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGameService game = new GameService();
            Console.WriteLine("Добро пожаловать в игру Угадай число");
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
                if(int.TryParse(Console.ReadLine(), out int guess))
                {
                    var result = game.Guess(guess);
                    Console.WriteLine(result);
                    if(result.Contains("ПОЗДРАВЛЯЕМ")) break;
                }
                else
                {
                    Console.WriteLine("Не верный ввод. Повторите попытку");
                }
            }
            if (game.GetGameState().Attempts == 0) Console.WriteLine("Игра окночена!");
        }
    }
}
