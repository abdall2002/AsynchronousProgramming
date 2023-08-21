// See https://aka.ms/new-console-template for more information

using System;
using CASequential;

var wallet = new Wallet("Issam", 80);

wallet.RunRandomTransactions();
Console.WriteLine("----------------");
Console.WriteLine($"{wallet}\n");

wallet.RunRandomTransactions();
Console.WriteLine("----------------");
Console.WriteLine($"{wallet}\n");







