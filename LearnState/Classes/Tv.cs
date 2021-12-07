using System;
using LearnState.Interfaces;

namespace LearnState.Classes
{
    public class Tv : ITvState
    {
        public ITvState tvState { get; set; }

        public Tv()
        {
            tvState = new TvOffState();
        }

        public string PressThePowerButton(string button)
        {
            Console.WriteLine(tvState.PressThePowerButton(button));
            if (tvState is TvOffState)
            {
                tvState = new TvOnState();
                return $"TV state has been moved to: {tvState.GetType().Name}.";
            }
            else
            {
                tvState = new TvOffState();
                return $"TV state has been moved to: {tvState.GetType().Name}.";
            }
        }

        public string SwitchChannel(int numberChannel)
        {
            Console.WriteLine ( tvState.SwitchChannel(numberChannel));
            if (tvState is TvOnState)
            {
                
                return $"You need to press power button to turn off TV.";
            }
            else
            {
                
                throw new Exception( "You need to turn on TV first.");

            }
        }
    }
}