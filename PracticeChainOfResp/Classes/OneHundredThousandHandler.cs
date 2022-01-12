using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChainOfResp.Classes
{
    public class OneHundredThousandHandler : Handler
    {
        public override void checkDispatchRs(long requestedAmount)
        {
            
            long numberofNotesToBeDispatched = requestedAmount / 100000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                     Console.WriteLine ($" {numberofNotesToBeDispatched} One Hundred Thousand VND are drawn");
                }
                else
                {
                     Console.WriteLine ($"Only {numberofNotesToBeDispatched} One Hundred Thousand VND is drawn");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 100000;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.checkDispatchRs(pendingAmountToBeProcessed);
            }

            
        }
    }
}
