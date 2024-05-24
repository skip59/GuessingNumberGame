namespace GuessingNumberGame.Interfaces
{
    public interface ISettings
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public int MaxAttempts { get; set; }
    }
}
