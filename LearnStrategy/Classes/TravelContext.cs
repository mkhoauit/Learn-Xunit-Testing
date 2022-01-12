using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }
       
        public int Ticket()
        {
            return travelStrategy.RoundTripTicket();
        }

        public int Distance(int dis)
        { 
            return travelStrategy.Distance(dis) ;
        }

        public int Total()
        {
            return travelStrategy.Total();

        }
    }
}
