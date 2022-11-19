using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ATMMachine : ATMState
    {
        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertState();
        }

        public ATMState atmMachineState { get; set; }
        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
        }

        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }

        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();
            if(atmMachineState is DebitCardNotInsertState)
            {
                atmMachineState = new DebitCardInsertedState();

                Console.WriteLine("ATM Machine internal state has been moved to : "
                               + atmMachineState.GetType().Name);
            }
        }

        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
}
