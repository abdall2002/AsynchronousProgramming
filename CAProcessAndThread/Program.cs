// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Diagnostics;


Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");
Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}");

















