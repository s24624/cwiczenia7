using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();
            var t1 = LinqTasks.Task2();
            foreach (var tx in t1)
            {
                Console.WriteLine(t + "helo");
            }

        }
    }
}
