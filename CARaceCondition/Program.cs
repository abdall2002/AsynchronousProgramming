// See https://aka.ms/new-console-template for more information

using System;
using CARaceCondition;

var wallet = new Wallet("Issam", 50);

//wallet.Debit(40);
//wallet.Debit(30); // 10


var t1 = new Thread(() => wallet.Debit(40));
var t2 = new Thread(() => wallet.Debit(30));

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine(wallet);














