using System;
using LearnBuilder.Classes;
using Xunit;
using Shouldly;

namespace Builder.Test
{
    public class BuilderTest
    {
        [Fact]
        public void NormalService_ShouldBe_40000()
        {
            //Arrange
            Barber barber = new Barber();
            var checkCost= 40000;
            
            //Action
            
            //Assert
            barber.CostNor().ShouldBe(checkCost);

        }
        [Fact]
        public void FullService_ShouldBe_55000()
        {
            //Arrange
            Barber barber = new Barber();
            var checkCost= 55000;
            
            //Action

            //Assert
            barber.Cost().ShouldBe(checkCost);
        }
        [Fact]
        public void CustomService_ShouldBe_15000_or_25000()
        {
            //Arrange
            Barber barber = new Barber();
            var checkCostHair= 25000 ;
            var checkCostEarOrBeard = 15000;

            //Action
            
            //Assert
            barber.CostCustom("clean ear").ShouldBe(checkCostEarOrBeard);
            barber.CostCustom("hair cut").ShouldBe(checkCostHair);

        }
    }
}