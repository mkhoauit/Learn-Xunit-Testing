using System;
using System.ServiceModel.Channels;
using LearnTemplateMethod.Classes;
using Xunit;
using Shouldly;
namespace LearnTemplateMethod.Test
{
    public class TemplateMethodTest
    {
        //add correct tea
        //flavor not null or empty
        //total of drink
        
        [Fact]
        public void AddTea_Correctly_In_BubbleTea_And_ShouldNotBeNullOrEmpty()
        {
            //Arrange
            MilkteaTemplate tea = new BubbleTea();
            var checkTea = "Normal Tea";
            //Action
            
            //Assert
            tea.AddTea().ShouldNotBeNullOrEmpty("");
            tea.AddTea().ShouldMatch(checkTea);
        }
        
        [Fact]
        public void AddTea_Correctly_In_BlackTea_And_ShouldNotBeNullOrEmpty()
        {
            //Arrange
            MilkteaTemplate tea = new BlackTea();
            var checkTea = "Black Tea";
            //Action
            
            //Assert
            tea.AddTea().ShouldNotBeNullOrEmpty("");
            tea.AddTea().ShouldMatch(checkTea);
        }
        
        [Fact]
        public void AddTea_Correctly_In_GreenTea_And_ShouldNotBeNullOrEmpty()
        {
            //Arrange
            MilkteaTemplate tea = new GreenTea();
            var checkTea = "Green Tea";
            //Action
            
            //Assert
            tea.AddTea().ShouldNotBeNullOrEmpty("");
            tea.AddTea().ShouldMatch(checkTea);
        }
        
        [Fact]
        public void AddTea_Correctly_In_PeachTea_And_ShouldNotBeNullOrEmpty()
        {
            //Arrange
            MilkteaTemplate tea = new PeachTea();
            var checkTea = "Peach Tea";
            //Action
            
            //Assert
            tea.AddTea().ShouldNotBeNullOrEmpty("");
            tea.AddTea().ShouldMatch(checkTea);
        }
        
        [Fact]
        public void AddFlavor_In_All_Tea_ShouldNotBeNullOrEmpty()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            
            //Assert
            blackTea.AddFlavor().ShouldNotBeNullOrEmpty("");
            bubbleTea.AddFlavor().ShouldNotBeNullOrEmpty("");
            greenTea.AddFlavor().ShouldNotBeNullOrEmpty("");
            peachTea.AddFlavor().ShouldNotBeNullOrEmpty("");
        }
        
        [Fact]
        public void Total_In_All_Tea_With_NoTopping_ShouldBe()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            bubbleTea.checkFlavor = "No topping";
            blackTea.checkFlavor = "No topping";
            greenTea.checkFlavor = "No topping";
            peachTea.checkFlavor = "No topping";
            //Assert
            bubbleTea.Total().ShouldBe(25000);
            blackTea.Total().ShouldBe(20000);
            greenTea.Total().ShouldBe(24000);
            peachTea.Total().ShouldBe(25000);
        }
        [Fact]
        public void Total_In_All_Tea_With_Topping_Flan_Or_Pearl_ShouldBe()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            bubbleTea.checkFlavor = "flan";
            blackTea.checkFlavor = "pearl";
            greenTea.checkFlavor = "flan";
            peachTea.checkFlavor = "pearl";
            //Assert
            bubbleTea.Total().ShouldBe(25000+5000);
            blackTea.Total().ShouldBe(20000+5000);
            greenTea.Total().ShouldBe(24000+5000);
            peachTea.Total().ShouldBe(25000+5000);
        }
        [Fact]
        public void Total_In_All_Tea_With_Topping_Cheese_Or_Orange_ShouldBe()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            bubbleTea.checkFlavor = "cheese";
            blackTea.checkFlavor = "orange";
            greenTea.checkFlavor = "cheese";
            peachTea.checkFlavor = "orange";
            //Assert
            bubbleTea.Total().ShouldBe(25000+7000);
            blackTea.Total().ShouldBe(20000+7000);
            greenTea.Total().ShouldBe(24000+7000);
            peachTea.Total().ShouldBe(25000+7000);
        }
        [Fact]
        public void Total_In_All_Tea_With_Topping_Jelly_ShouldBe()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            bubbleTea.checkFlavor = "jelly";
            blackTea.checkFlavor = "jelly";
            greenTea.checkFlavor = "jelly";
            peachTea.checkFlavor = "jelly";
            //Assert
            bubbleTea.Total().ShouldBe(25000+6000);
            blackTea.Total().ShouldBe(20000+6000);
            greenTea.Total().ShouldBe(24000+6000);
            peachTea.Total().ShouldBe(25000+6000);
        }
        [Fact]
        public void Total_In_All_Tea_With_Topping_Peach_ShouldBe()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            //Action
            bubbleTea.checkFlavor = "peach";
            blackTea.checkFlavor = "peach";
            greenTea.checkFlavor = "peach";
            peachTea.checkFlavor = "peach";
            //Assert
            bubbleTea.Total().ShouldBe(25000+8000);
            blackTea.Total().ShouldBe(20000+8000);
            greenTea.Total().ShouldBe(24000+8000);
            peachTea.Total().ShouldBe(25000+8000);
            
        }
        [Fact]
        public void Wrong_Input_Flavor_ShouldBe_Total_NoTopping()
        {
            //Arrange
            BubbleTea bubbleTea = new BubbleTea();
            BlackTea blackTea = new BlackTea();
            GreenTea greenTea = new GreenTea();
            PeachTea peachTea = new PeachTea();
            
            
            //Action
            bubbleTea.checkFlavor = "red";
            blackTea.checkFlavor = "blue";
            greenTea.checkFlavor = "hello";
            peachTea.checkFlavor = " ";
            //Assert
            bubbleTea.Total().ShouldBe(25000);
            blackTea.Total().ShouldBe(20000);
            greenTea.Total().ShouldBe(24000);
            peachTea.Total().ShouldBe(25000);
        }
    }
}