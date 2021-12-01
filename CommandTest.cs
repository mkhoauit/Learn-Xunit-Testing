using System;
using PracticeCommand.Classes;
using Xunit;
using Shouldly;

namespace PracticeCommand.Test
{
    public class Calculator_Test
    {
        [Fact]
        public void Wrong_Input_Operator_In_Calculator_ShouldBe()
        {
            //Arrange
            Client client = new Client();
            
            var c = $"Do not have that calculation!";
            //Action
            Action act = () => client.Compute('%',100);
            var check = act.ShouldThrow<Exception>();

            //Assert
            check.Message.ShouldBe(c);
        }

        [Fact] 
        public void Check_Compute_In_Client_ShouldContain()
        {
            //Arrange
            Client client = new Client();
            
            var c = $"Current value = {0+100} (following + 100)";
            //Action
            var check= client.Compute('+', 100);
            //Assert
            check.ShouldContain(c);
        }
       
        [Fact] 
        public void Not_Compute_Then_Check_Undo_In_Client_ShouldBe()
        {
            //Arrange
            Client client = new Client();
            
            var c = "You need to Compute first!";
           
            //Action
            Action act = () => client.Undo(1);
            var check = act.ShouldThrow<Exception>();
            //Assert
            check.Message.ShouldBe(c);
        }
        [Fact] public void Not_Undo_Then_Check_Redo_In_Client_ShouldBe()
        {
            //Arrange
            Client client = new Client();
            client.Compute('+', 100);
            client.Compute('-', 50);
            client.Compute('*', 10);
          
            var c = "You need to Undo first!";
           
            //Action
            Action act = () => client.Redo(1);
            var check = act.ShouldThrow<Exception>();
            //Assert
            check.Message.ShouldBe(c);
        }
        [Fact] 
        public void Check_Undo_In_Client_ShouldContain()
        {
            //Arrange
            Client client = new Client();
            client.Compute('+', 100);
            client.Compute('-', 50);
            client.Compute('*', 10);
          
            var c = $"Current value = {500/10} (following / 10)\n";
            c += $"Current value = {50+50} (following + 50)\n";
            //Action
            var check= client.Undo(2);
            //Assert
            check.ShouldContain(c);
        }
        [Fact] 
        public void Check_Redo_In_Client_ShouldContain()
        {
            //Arrange
            Client client = new Client();
            client.Compute('+', 100);
            client.Compute('-', 50);
            client.Compute('*', 10);
            
            client.Undo(3);
            
            var c = $"Current value = {0+100} (following + 100)\n";
            c += $"Current value = {100-50} (following - 50)\n";
            //Action
            var check= client.Redo(2);
            //Assert
            check.ShouldContain(c);
        }
    }
}