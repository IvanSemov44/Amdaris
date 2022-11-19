﻿using StateDesignPattern;

ATMMachine atmMachine = new ATMMachine();
Console.WriteLine("ATM Machine Current state : "
                + atmMachine.atmMachineState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.EjectDebitCard();
atmMachine.InsertDebitCard();
Console.WriteLine();

Console.WriteLine("ATM Machine Current state : "
                + atmMachine.atmMachineState.GetType().Name);
Console.WriteLine();
atmMachine.EnterPin();
atmMachine.WithdrawMoney();
atmMachine.InsertDebitCard();
atmMachine.EjectDebitCard();
Console.WriteLine("");

Console.WriteLine("ATM Machine Current state : "
                + atmMachine.atmMachineState.GetType().Name);
Console.Read();