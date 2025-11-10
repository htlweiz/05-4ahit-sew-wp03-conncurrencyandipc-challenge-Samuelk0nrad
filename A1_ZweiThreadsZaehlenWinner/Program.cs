using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{

    static int counter = 0;
    static int counterDown = 100;

    static object lockObj = new Object();
    
    public static void Main(string[] args)
    {
        Thread threadA = new Thread(CountUpThreadA);
        Thread threadB = new Thread(CountDownThreadB);

        threadA.Start();
        threadB.Start();

        threadA.Join();
        threadB.Join();

        if(counter > counterDown)
        {
            Console.WriteLine("Thread A win");
        } else if(counter < counterDown)
        {
            Console.WriteLine("Thread B win");
        } else
        {
            Console.WriteLine("even");
        }
    }
    
    private static void CountUpThreadA()
    {
        while (counter < 100)
        {
            lock (lockObj)
            {
                if (counter == counterDown)
                {
                    break;
                }
                counter++;
            }
            Thread.Sleep(100);
        }
    }
    
    private static void CountDownThreadB()
    {
        while (counterDown > 0)
        {
            lock (lockObj)
            {
                if (counter == counterDown)
                {
                    break;
                }
                counterDown--;
            }
            Thread.Sleep(100);
        }
    }
}
