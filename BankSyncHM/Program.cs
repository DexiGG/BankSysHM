using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSyncHM
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new Thread[5];
            var bank = new BankSyns();

            for (int i = 0; i < threads.Length; i++)
            {
                var thread = new Thread(bank.MoneyMOVE);
                threads[i] = thread;
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }


            Console.ReadLine();
        }
    }
}
