// See https://aka.ms/new-console-template for more information


using System;

//Task.Run(Print); 
Print();
async Task Print()
{
    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}, Thread Name: {Thread.CurrentThread.Name}");
    Console.WriteLine($"Is Pooled thread: {Thread.CurrentThread.IsThreadPoolThread}");
    Console.WriteLine($"Background: {Thread.CurrentThread.IsBackground}");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Cycle {i + 1}");
    }

}

//void Print(object state)
//{
//    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}, Thread Name: {Thread.CurrentThread.Name}");
//    Console.WriteLine($"Is Pooled thread: {Thread.CurrentThread.IsThreadPoolThread}");
//    Console.WriteLine($"Background: {Thread.CurrentThread.IsBackground}");
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Cycle {i + 1}");
//    }
//}