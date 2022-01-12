using System;
using System.ServiceModel.Channels;
using PracticeChainOfResp.Classes;
using Xunit;
using Shouldly;

namespace PracticeChainOfResp.Test
{
    public class ATM_Test
    {
        [Fact]
        public void Check_YourAmount_Lower_Than_MinimumAmount_ShouldBe()
        {
            //Arrange
            ATM atm = new ATM();
           
            var Amount = 40000;

            //Action
            Action act = () => atm.checkYourAmount(Amount);
            //Assert
            var excep = act.ShouldThrow<Exception>();
            excep.Message.ShouldBe("Your amount is too low to withdraw!");
            atm.minimumAmount.ShouldBe(50000);
        }
        [Fact]
        public void Check_YourAmount_Lower_Than_100000_ShouldBe()
        {
            //Arrange
            ATM atm = new ATM();
           
            var Amount = 90000;

            //Action
            Action act = () => atm.checkYourAmount(Amount);
            //Assert
            var excep = act.ShouldThrow<Exception>();
            excep.Message.ShouldBe("Your amount is too low to draw any banknotes!");
            
        }
        [Fact]
        public void Check_RequestAmount_Higher_Than_YourAmount_ShouldBe()
        {
            //Arrange
            ATM atm = new ATM();
            var     Amount    = 400000;
            var requestAmount = 500000;

            //Action
            atm.checkYourAmount(Amount);
            Action act = () => atm.withdraw(requestAmount);
            //Assert
            var excep = act.ShouldThrow<Exception>();
            excep.Message.ShouldBe("Not enough money in your account");
            atm.minimumAmount.ShouldBe(50000);
        }
        [Fact]
        public void Check_YourAmount_Minus_RequestAmount_Lower_Than_MinimumAmount_ShouldBe()
        {
            //Arrange
            ATM atm = new ATM();
            var     Amount    = 500000;
            var requestAmount = 460000;

            //Action
            atm.checkYourAmount(Amount);
            Action act = () => atm.withdraw(requestAmount);
            //Assert
            var excep = act.ShouldThrow<Exception>();
            excep.Message.ShouldBe("Minimum amount must not lower than 50.000 VND");
            atm.minimumAmount.ShouldBe(50000);
        }
        
        [Fact]
        public void Check_Withdraw_Lower_Than_50000_ShouldBe()
        {
            //Arrange
            ATM atm = new ATM();
            var     Amount    = 500000;
            var requestAmount = 40000;

            //Action
            atm.checkYourAmount(Amount);
            Action act = () => atm.withdraw(requestAmount);
            //Assert
            var excep = act.ShouldThrow<Exception>();
            excep.Message.ShouldBe("We do not have any banknote that lower than 50.000 VND");
           
        }
        [Fact]
        public void Check_YourAmount_After_Withdraw_RequestAmount()
        {
            //Arrange
            ATM atm = new ATM();
            var     Amount    = 1500000;
            var requestAmount = 1200000;

            //Action
            atm.checkYourAmount(Amount);
            atm.withdraw(requestAmount);
            //Assert
            
            atm.currentAmount().ShouldBe(Amount-requestAmount);
                
        }
    }
}