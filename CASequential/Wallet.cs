using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CASequential
{
    class Wallet
    {
        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public string Name { get; set; }
        public int Bitcoins { get; set; }

        public void Debit(int amount)
        {
            Bitcoins -= amount;
        }

        public void Credit(int amount)
        {
            Bitcoins += amount;
        }

        public void RunRandomTransactions()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 }; // 80

            foreach (var amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                    Debit(absValue);
                else
                    Credit(absValue);
                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}" +
                    $", Processor Id: {Thread.GetCurrentProcessorId()}] {amount}");
            }
        }

        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
