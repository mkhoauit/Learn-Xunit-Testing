using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Interfaces
{
    public interface ITravelStrategy
    {
       
        int RoundTripTicket();
        int Distance(int dis);
        int Total();
    }
}
