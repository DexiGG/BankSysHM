using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSyncHM
{
    public class BankSyns
    {
        public int Money { get; set; }
        private object lockObject = new object();
        private int Transactions;

        public void MoneyMOVE(object state)
        {
            lock (lockObject)
            {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine($"\n{currentThread.ManagedThreadId} начал свою работу c {Money}");

            int number = new Random().Next(0, 1000);

            Thread.Sleep(500);

            if (number > 50)
            {
                Money -= 100;
                Transactions -= 100;

            }
            else
            {
                Money += 100;
                Transactions += 100;

            }
            Console.WriteLine($"\n+-Тенге ({Transactions}) Операция ");
            Console.WriteLine($"\n{currentThread.ManagedThreadId} закончил свою работу {Money}");
           }
        }
    }
}
