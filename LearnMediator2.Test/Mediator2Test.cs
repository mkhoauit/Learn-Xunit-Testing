using System;
using System.Configuration;
using System.IO.Compression;
using LearnMediator2.Classes;
using Xunit;
using Shouldly;

namespace LearnMediator2.Test
{
    public class UnitTest1
    {
        [Fact] 
        public void Check_Input_NullOrEmpty_Name_In_Messenger_ShouldBe()
        {
            //Arrange
            var check = "";
            var checkEx = "Please input your name correctly!";
            //Action
            Action act = () => new Messenger(check);
            
            //Assert
            var ex = act.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkEx);
        }
        [Fact] 
        public void Check_Input_NullOrEmpty_Name_In_Zalo_ShouldBe()
        {
            //Arrange
            var check = "";
            var checkEx = "Please input your name correctly!";
            //Action

            Action act1 = () => new Zalo(check);
            
            //Assert
            var ex = act1.ShouldThrow<Exception>();
            ex.Message.ShouldBe(checkEx);
        }
        [Fact] 
        public void Check_Register_Chatroom_ShouldBe()
        {
            //Arrange
            var check = "Hoa";
            var checkAssert = "Register for Hoa successfully.";
            Chatroom chatroom = new Chatroom();
            Participant a = new Zalo(check);
            //Action
            
            //Assert
            chatroom.Register(a).ShouldBe(checkAssert);
        }
        [Fact] 
        public void Check_Send_Receive_Message_ToMessenger_ShouldBe()
        {
            //Arrange
            var checkParti1 = "Hoa";
            var checkParti2 = "Long";
            var checkSend = $"To Messenger:{checkParti1} to {checkParti2}: hello";
            
            var checkReceive = "To Messenger:Long to Hoa: Hi";
            
            Chatroom chatroom = new Chatroom();
            
            Participant a = new Messenger(checkParti1);
            Participant b = new Messenger(checkParti2);
            chatroom.Register(a);
            chatroom.Register(b);
            
            //Action
            var send = a.Send(checkParti2, "hello");
            var receive = a.Receive(checkParti2, "Hi");
            //Assert
            send.ShouldContain(checkSend);
            receive.ShouldContain(checkReceive);
            
        }
        [Fact] 
        public void Check_Send_Receive_Message_ToZalo_ShouldBe()
        {
            //Arrange
            var checkParti1 = "Hoa";
            var checkParti2 = "Long";
            var checkSend = $"To Zalo:{checkParti1} to {checkParti2}: Hello";
            
            var checkReceive = "To Zalo:Long to Hoa: Hi";
            
            Chatroom chatroom = new Chatroom();
            
            Participant a = new Zalo(checkParti1);
            Participant b = new Zalo(checkParti2);
            chatroom.Register(a);
            chatroom.Register(b);
            
            //Action
            var send = a.Send(checkParti2, "Hello");
            var receive = a.Receive(checkParti2, "Hi");
            //Assert
            send.ShouldContain(checkSend);
            receive.ShouldContain(checkReceive);
            
        }
    }
}