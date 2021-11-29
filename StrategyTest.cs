using System;
using LearnStrategy.Classes;
using Xunit;
using Shouldly;

namespace LearnStrategy.Test
{
    public class StrategyTest
    {
        public class BusTest
        {
            [Fact]
            public void Ticket_1km_Bus_ShouldBe_5000_And_RoundTrip_Ticket_ShouldBe_9500()
            {
                //Arrange
                BusStrategy strategy = new BusStrategy();

                var ticket = 5000;
                var distance = 1;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);
                var checkRT = strategy.RoundTripTicket();
                //Action

                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_3km_Bus_ShouldBe_15000_And_RoundTrip_Ticket_ShouldBe_28500()
            {
                //Arrange
                BusStrategy strategy = new BusStrategy();


                var ticket = 5000;
                var distance = 3;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);

                //Action
                strategy.Distance(3);
                var checkRT = strategy.RoundTripTicket();
                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_4km_Bus_ShouldBe_20000_With_No_RoundTrip()
            {
                //Arrange
                BusStrategy strategy = new BusStrategy();


                var ticket = 5000;
                var distance = 4;
                var total = ticket * distance;
                //Action
                strategy.Distance(4);
                //Assert
                strategy.Total().ShouldBe(total);

            }
        }

        public class GrabBikeTest
        {
            [Fact]
            public void Ticket_1km_GrabBike_ShouldBe_30000_And_RoundTrip_Ticket_ShouldBe_57000()
            {
                //Arrange
                GrabBikeStrategy strategy = new GrabBikeStrategy();

                var ticket = 30000;
                var distance = 1;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);
                var checkRT = strategy.RoundTripTicket();
                //Action

                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_3km_GrabBike_ShouldBe_90000_And_RoundTrip_Ticket_ShouldBe_171000()
            {
                //Arrange
                GrabBikeStrategy strategy = new GrabBikeStrategy();

                var ticket = 30000;
                var distance = 3;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);

                //Action
                strategy.Distance(3);
                var checkRT = strategy.RoundTripTicket();
                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_4km_GrabBike_ShouldBe_120000_With_No_RoundTrip()
            {
                //Arrange
                GrabBikeStrategy strategy = new GrabBikeStrategy();
                
                var ticket = 30000;
                var distance = 4;
                var total = ticket * distance;
                //Action
                strategy.Distance(4);
                //Assert
                strategy.Total().ShouldBe(total);
            }
        }
        public class GrabCarTest
        {
            [Fact]
            public void Ticket_1km_GrabCar_ShouldBe_40000_And_RoundTrip_Ticket_ShouldBe_76000()
            {
                //Arrange
                GrabCarStrategy strategy = new GrabCarStrategy();

                var ticket = 40000;
                var distance = 1;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);
                var checkRT = strategy.RoundTripTicket();
                //Action

                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_3km_GrabCar_ShouldBe_1200000_And_RoundTrip_Ticket_ShouldBe_228000()
            {
                //Arrange
                GrabCarStrategy strategy = new GrabCarStrategy();

                var ticket = 40000;
                var distance = 3;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);

                //Action
                strategy.Distance(3);
                var checkRT = strategy.RoundTripTicket();
                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_4km_GrabBike_ShouldBe_160000_With_No_RoundTrip()
            {
                //Arrange
                GrabCarStrategy strategy = new GrabCarStrategy();
                
                var ticket = 40000;
                var distance = 4;
                var total = ticket * distance;
                //Action
                strategy.Distance(4);
                //Assert
                strategy.Total().ShouldBe(total);
            }
        }
        public class TrainTest
        {
            [Fact]
            public void Ticket_1km_Train_ShouldBe_60000_And_RoundTrip_Ticket_ShouldBe_114000()
            {
                //Arrange
                TrainStrategy strategy = new TrainStrategy();

                var ticket = 60000;
                var distance = 1;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);
                var checkRT = strategy.RoundTripTicket();
                //Action

                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_3km_Train_ShouldBe_1800000_And_RoundTrip_Ticket_ShouldBe_342000()
            {
                //Arrange
                TrainStrategy strategy = new TrainStrategy();

                var ticket = 60000;
                var distance = 3;
                var roundTripTicket = ticket * distance * 2 - (ticket * distance * 10 / 100);

                //Action
                strategy.Distance(3);
                var checkRT = strategy.RoundTripTicket();
                //Assert
                checkRT.ShouldBe(roundTripTicket);

            }

            [Fact]
            public void Ticket_4km_Train_ShouldBe_240000_With_No_RoundTrip()
            {
                //Arrange
                TrainStrategy strategy = new TrainStrategy();
                
                var ticket = 60000;
                var distance = 4;
                var total = ticket * distance;
                //Action
                strategy.Distance(4);
                //Assert
                strategy.Total().ShouldBe(total);
            }
        }
    }
}