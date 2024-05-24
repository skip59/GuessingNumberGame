using GuessingNumberGame.Game.Interface;
using GuessingNumberGame.Game.Services;

namespace GuessingNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру 'Угадай число или слово'");
            Console.WriteLine("Во что будем играть в числа или слова? Укажите 1 если в числа, 2 в слова");
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                if(result == 1)
                {
                    IGameMode gameMode = new NumberGameMode();
                    gameMode.StartGame();
                }
                else if (result == 2)
                {
                    IGameMode gameMode = new WordGameMode();
                    gameMode.StartGame();
                }
                else Console.WriteLine("Неверный ввод.");
            }
        }
    }
}
