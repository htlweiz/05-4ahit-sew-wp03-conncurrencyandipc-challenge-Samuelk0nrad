using System;
using System.Threading;

namespace A2_RaceConditionBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
        
        // Bankkonto mit Startwert 1000 EUR erstellen
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");

        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; ++i)
        {
            threads[i] = new Thread(() => PerformBankOperations(account));
            threads[i].Start();
        }


        for (int i = 0; i < threads.Length; ++i)
        {
            threads[i].Join();
        }

        Console.WriteLine("account: ", account.GetBalance);
    }
    
    private static void PerformBankOperations(BankAccount account)
    {
        account.Deposit(100);

        Thread.Sleep(100);

        account.Withdraw(150);
        
    }
}

