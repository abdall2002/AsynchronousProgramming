// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Diagnostics;


Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");       // 9865 any number
Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");  // 1
Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}");     // 6 or 2 or 8

















