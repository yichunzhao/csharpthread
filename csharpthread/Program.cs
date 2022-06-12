using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpThread
{
    static class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("C sharp M-Threads!");
            await Task.Run(() =>
            {
                var c = 0;
                while (c < 20)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "b-thd: " + c);
                    c++;
                }
            });

            await Task.Run(() =>
                {
                    var counter=0;
                    while (counter < 10)
                    {
                        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "a-thd:" + counter);
                        counter++;
                    }
                }
            );
        }
    }
}