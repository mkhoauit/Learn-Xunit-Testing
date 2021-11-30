using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChainOfResp.Classes
{
    
    public class ATM
    {   
        public long yourAmount =0;
        public long minimumAmount = 50000;
        
        private FiveHundredThousandHandler fiveHundredThousandHandler = new FiveHundredThousandHandler();
        private FiftyThousandHandler       fiftyThousandHandler       = new FiftyThousandHandler();
        private TwoHundredThousandHandler  twoHundredThousandHandler  = new TwoHundredThousandHandler();
        private OneHundredThousandHandler  oneHundredThousandHandler  = new OneHundredThousandHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            fiveHundredThousandHandler.nextHandler(twoHundredThousandHandler);
            twoHundredThousandHandler.nextHandler(oneHundredThousandHandler);
            oneHundredThousandHandler.nextHandler(fiftyThousandHandler);
            
        }
        public void withdraw(long requestedAmount)
        {
            if (this.yourAmount<requestedAmount)
            {
                throw new Exception(message: "Not enough money in your account");
            }
            else if(this.yourAmount-requestedAmount<minimumAmount)
            {
                throw new Exception(message: "Minimum amount must not lower than 50.000 VND");
            }
            this.yourAmount = this.yourAmount- minimumAmount -requestedAmount;

            fiveHundredThousandHandler.checkDispatchRs(requestedAmount);
            

        }

        public long checkYourAmount(long amount)
        {
            this.yourAmount = amount;
            
            
            if (amount < minimumAmount)
            {
                throw new Exception(message: "Your amount is too low to withdraw!");
            }
            else if (amount < 100000)
            {
                throw new Exception(message: "Your amount is too low to draw any banknotes!");
            }
            return this.yourAmount;
        }

        public long currentAmount()
        {
            this.yourAmount += minimumAmount;
            
            return this.yourAmount;
        }
    }
}
