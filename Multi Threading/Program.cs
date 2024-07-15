using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threading
{
    internal class Program
    {
        static void Main()
        {
            // Create and start the first thread
            Thread thread1 = new Thread(PrintNumbers);
            thread1.Name = "Thread 1";
            thread1.Start();

            // Create and start the second thread
            Thread thread2 = new Thread(PrintNumbers);
            thread2.Name = "Thread 2";
            thread2.Start();

            // Wait for both threads to complete
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Both threads have completed.");
            Console.ReadKey();
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                Thread.Sleep(500); // Sleep for 500 milliseconds
            }
        }
    }
}
