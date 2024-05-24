using GuessingNumberGame.Interfaces;

namespace GuessingNumberGame.Models
{
    public class GameState : IGameState
    {
        public int TargetNumber { get; set; }
        public int Attempts { get; set; }
        public string TargetWord { get; set; }
    }
}
