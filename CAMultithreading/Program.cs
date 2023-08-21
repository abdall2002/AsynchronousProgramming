// See https://aka.ms/new-console-template for more information

using System;
using CAMultithreading;


Thread.CurrentThread.Name = "Main Thread";
Console.WriteLine(Thread.CurrentThread.Name);
Console.WriteLine($"Background Thread: {Thread.CurrentThread.IsBackground}");
var wallet = new Wallet("Issam", 80);

Thread t1 = new Thread(wallet.RunRandomTransactions);
t1.Name = "T1";
Console.WriteLine($"T1 Background Thread: {t1.IsBackground}");
//Console.WriteLine($"after declaration {t1.Name} state is: {t1.ThreadState}");

//t1.Start();
//Console.WriteLine($"after start() {t1.Name} state is: {t1.ThreadState}");
//t1.Join();

//Thread t2 = new Thread(new ThreadStart(wallet.RunRandomTransactions));
//t2.Name = "T2";
//t2.Start();

//Console.WriteLine($"after start {t1.Name} state is: {t1.ThreadState}");
