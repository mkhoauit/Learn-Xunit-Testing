using System;
using LearnState.Classes;
using Xunit;
using Shouldly;

namespace LearnState.Test
{
    public class StateTest
    {
        [Fact]
        public void Input_Wrong_Button_To_Turn_On_TV_ShouldBe()
        {
            //Arrange
            Tv tv = new Tv();
            var checkButton = "mute";
            var checkEx = "Please choose button POWER to turn on TV!!!";
            //Action
            Action action = () => tv.PressThePowerButton(checkButton);

            //Assert
            var ex = action.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkEx);
            tv.tvState.GetType().Name.ShouldBe("TvOffState");
        }
        [Fact]
        public void Input_Wrong_Button_To_Turn_Off_TV_ShouldBe()
        {
            //Arrange
            Tv tv = new Tv();
            tv.PressThePowerButton("power");
            
            var checkButton = "mute";
            var checkEx = "Please choose button POWER to turn off TV!!!";
            //Action
            Action action = () => tv.PressThePowerButton(checkButton);

            //Assert
            var ex = action.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkEx);
            tv.tvState.GetType().Name.ShouldBe("TvOnState");
        }
        [Fact]
        public void Switch_Channel_Before_Turn_On_TV_ShouldBe()
        {
            //Arrange
            Tv tv = new Tv();
           
            var checkButton = 12;
            var checkEx = "You need to turn on TV first.";
            //Action
            Action action = () =>  tv.SwitchChannel(checkButton);

            //Assert
            var ex = action.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkEx);
            tv.tvState.GetType().Name.ShouldBe("TvOffState");
        }
        [Fact]
        public void Switch_Channel_After_Turn_On_TV_ShouldBe()
        {
            //Arrange
            Tv tv = new Tv();
            tv.PressThePowerButton("power");
            var checkButton = 12;
            var checkEx = "You need to press power button to turn off TV.";
            var checkChanged = "TV has been changed to 12 channel.";
            //Action
            

            //Assert
            tv.tvState.SwitchChannel(checkButton).ShouldContain(checkChanged);
            tv.SwitchChannel(checkButton).ShouldBe(checkEx);
            tv.tvState.GetType().Name.ShouldBe("TvOnState");
        }
    }
}