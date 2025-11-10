using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{

    static int counter = 0;
    static int counterDown = 100;
    
    public static void Main(string[] args)
    {
        Thread threadA = new Thread(CountUpThreadA);
        Thread threadB = new Thread(CountDownThreadB);

        threadA.Start();
        threadB.Start();

        threadA.Join();
        threadB.Join();
    }
    
    private static void CountUpThreadA()
    {
        for (;counter < 100; counter++)
        {
            Console.WriteLine($"Thread A: {counter}");
            Thread.Sleep(100);
        }
        
    }
    
    private static void CountDownThreadB()
    {
        for (;counterDown > 0; counterDown--)
        {
            counterDown--;
            Console.WriteLine($"Thread B: {counterDown}");
            Thread.Sleep(100);
        }
    }
}
