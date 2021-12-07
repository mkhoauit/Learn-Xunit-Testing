using System;
using LearnState.Interfaces;

namespace LearnState.Classes
{
    public class TvOnState : ITvState
    {
        public string PressThePowerButton(string button)
        {
            switch (button.ToLower())
            {
                case "power" or "button power":
                    return $"{button.ToUpper()} has been selected.\n";
                    break;
                default:
                    throw new Exception("Please choose button POWER to turn off TV!!!");
                    break;
                
            }
        }

        public string SwitchChannel(int numberChannel)
        {
            return $"TV has been changed to {numberChannel} channel.\n";
        }
    }
}