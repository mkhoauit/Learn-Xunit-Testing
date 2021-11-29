using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
     public class BusStrategy : ITravelStrategy
    {
        public int ticketBus = 5000;
        public int distance = 1;
        public int ticketRT = 0;

       

        public int RoundTripTicket()
        {
            this.ticketRT = ticketBus *distance *2 - ticketBus *distance *10 /100;
            return this.ticketRT;
        }

        public int Distance(int dis)
        {
            this.distance = dis;
            return this.distance;
        }

        public int Total()
        {
            switch (this.ticketRT)
            {
                case 0 :
                    return this.ticketBus * this.distance;
                    break;
                default:
                    return this.ticketRT;
                    break;
            }
            
        }
    }
}
