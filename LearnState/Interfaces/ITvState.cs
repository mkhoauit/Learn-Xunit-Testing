using System;
namespace LearnState.Interfaces

{
    public interface ITvState
    {
        string PressThePowerButton(string button);
        string SwitchChannel(int numberChannel);
    }
}