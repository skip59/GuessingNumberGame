﻿using GuessingNumberGame.Interfaces;

namespace GuessingNumberGame.Models
{
    public class Settings : ISettings
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public int MaxAttempts { get; set; }
    }
}
