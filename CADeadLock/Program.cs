// See https://aka.ms/new-console-template for more information

using CADeadLock;

var wallet1 = new Wallet(1, "Issam", 100);
var wallet2 = new Wallet(2, "Reem", 50);
Console.WriteLine("\n Before Transaction");
Console.WriteLine("\n---------------------");
Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();
Console.WriteLine("\n After Transaction");
Console.WriteLine("\n---------------------");

var transferManager1 = new TransferManager(wallet1, wallet2, 50);
var transferManager2 = new TransferManager(wallet2, wallet1, 30);

var t1 = new Thread(transferManager1.Transfer);
t1.Name = "T1";
var t2 = new Thread(transferManager2.Transfer);
t2.Name = "T2";

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();

















