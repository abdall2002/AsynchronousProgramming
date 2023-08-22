using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CADeadLock
{
    class Wallet
    {
        private readonly object bitcoinsLock = new object();
        public Wallet(int id, string name, int bitcoins)
        {
            Id = id;
            Name = name;
            Bitcoins = bitcoins;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Bitcoins { get; private set; }


        public void Debit(int amount)
        {
            lock (bitcoinsLock)
            {
                if (Bitcoins >= amount)
                {
                    Thread.Sleep(1000);

                    Bitcoins -= amount;
                }
            }
        }

        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
        }


        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
    

