namespace GuessingNumberGame.Interfaces
{
    public interface IGameState
    {
        public int TargetNumber { get; set; }
        public int Attempts { get; set; }
    }
}
