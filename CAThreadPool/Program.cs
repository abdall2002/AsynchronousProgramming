// See https://aka.ms/new-console-template for more information


using CAThreadPool;
using System;

// -> 1
//Task.Run(Print);
// -> 2
Print();

var employee = new Employee { Rate = 10, TotalHours = 40 };

await Task.Run(CalculateSalary);    // -> $400.00
void CalculateSalary()
{
    var emp = employee as Employee;
    if (employee is null)
        return;
    emp.TotalSalary = emp.TotalHours * emp.Rate;
    Console.WriteLine(emp.TotalSalary.ToString("C"));
}


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