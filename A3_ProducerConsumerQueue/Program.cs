using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace A3_ProducerConsumerQueue;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");

        // TODO
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

        Producer producer1 = new Producer(1, queue);
        Producer producer2 = new Producer(2, queue);
        Producer producer3 = new Producer(3, queue);
        Producer producer4 = new Producer(4, queue);
        Producer producer5 = new Producer(5, queue);


        Console.WriteLine("Producer und Consumer gestartet...\n");

        // Überwachung: Jede Sekunde Queue-Füllstand ausgeben und auf >50 prüfen
        
        // TODO


        // Alle Producer stoppen
       

        // Consumer stoppen
       
       
    }
}
