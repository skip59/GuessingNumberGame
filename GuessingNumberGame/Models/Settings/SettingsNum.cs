using GuessingNumberGame.Interfaces;

namespace GuessingNumberGame.Models.Settings
{
    public class SettingsNum : ISettings<Settings>
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
    }
}
