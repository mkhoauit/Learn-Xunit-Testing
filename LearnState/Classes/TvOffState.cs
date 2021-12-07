using System;
using LearnState.Interfaces;

namespace LearnState.Classes
{
    public class TvOffState : ITvState
    {
        public string SwitchChannel(int numberChannel)
        {
            return "TV can not Switch channel because TV state is OFF!!\n";
        }
        public string PressThePowerButton(string button)
        {
            switch (button.ToLower())
            {
                case "power" or "button power":
                    return $"{button.ToUpper()} has been selected.\n";
                    break;
                default:
                    throw new Exception("Please choose button POWER to turn on TV!!!");
                    break;
                
            }
           
        }
    }
}