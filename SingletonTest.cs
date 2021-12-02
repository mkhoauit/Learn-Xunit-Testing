using System;
using LearnSingleton.Classes;
using Xunit;
using Shouldly;

namespace LearnSingleton.Test
{
    public class SingletonTest
    {
        [Fact]
        public void Use_1_Instance_Logger()
        {
            //Arrange
            Logger log1 = Logger.GetLogger();
            Logger log2 = Logger.GetLogger();
            var check = 1;
            //Action

            //Assert
            Logger.instanceCounter.ShouldBe(check);

        }
        [Fact]
        public void Message_In_Logger_ShouldNotBeNullOrEmpty()
        {
            //Arrange
           
            //Action
            
            //Assert
            Logger.GetLogger().Messages.ShouldNotBeNullOrEmpty();
            
        }
        [Fact]
        public void Check_WriteMessage_BeNullOrEmpty_ShouldThrow()
        {
            //Arrange
            var check = " ";
            var name = "Na";
            var checkThrow = "Please input your message correctly!";
            //Action
            Action act = () => Logger.GetLogger().WriteMessage(check,name);
            
            //Assert
            var ex = act.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkThrow);

        }
        [Fact]
        public void Not_Find_Message_ShouldBe()
        {
            //Arrange
            Logger log1 = Logger.GetLogger();
            Logger log2 = Logger.GetLogger();
            log1.WriteMessage("hello","Max");
            log2.WriteMessage("bye","Ming");
            var check = "hihi";
            var checkThrow = "Not Found!";
            //Action
            Action act = () => Logger.GetLogger().FindMessage(check);
            
            //Assert
            var ex = act.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkThrow);
        }
        [Fact]
        public void Find_Message_ShouldBe()
        {
            //Arrange
            Logger log1 = Logger.GetLogger();
            Logger log2 = Logger.GetLogger();
            log1.WriteMessage("hello","Max");
            log2.WriteMessage("bye","Min");
            var check = "bye";
            var checkShouldBe = "There is message: bye";
            //Action

            //Assert
            Logger.GetLogger().FindMessage(check).ShouldBe(checkShouldBe);
        }
    }
}