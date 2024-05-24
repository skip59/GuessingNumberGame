using GuessingNumberGame.Interfaces;

namespace GuessingNumberGame.Models
{
    public class SettingsGuessWord : ISettings
    {
        public List<string> Words = ["World", "Eath", "Word", "Day", "Lib", "Team", "Work", "Power"]; 
        public int MaxAttempts { get; set; }
    }
}