
namespace StateDesignPattern
{
    public class DebitCardNotInsertState : ATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit Card. As no Debit Card in ATM Machine slot.");
        }

        public void EnterPin()
        {
            Console.WriteLine("You cannot enter the pin.As no Debit Card in ATM Machine slot.");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("You cannot withdraw money.As no Debit Card in ATM Machine slot.");
        }
    }
}
