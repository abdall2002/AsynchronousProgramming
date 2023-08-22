using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CADeadLock
{
    public class TransferManager
    {
        private Wallet from;
        private Wallet to;

        private int amountToTransfer;

        public TransferManager(Wallet from, Wallet to, int amountToTransfer)
        {
            this.from = from;
            this.to = to;
            this.amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            var lock1 = from.Id < to.Id ? from : to;
            var lock2 = from.Id < to.Id ? to : from;

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {from}");
            lock (lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {from}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {to}");

                lock (lock2)
                {
                    from.Debit(amountToTransfer);
                    to.Credit(amountToTransfer);
                }
            }
        }
    }
}
