using System;

namespace task_6_3_2
{
    class Program
    {
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue)
                {
                    Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
                }
                else
                {
                    Console.WriteLine("Автобус пуст!");
                }
            }
        }
        static void Main(string[] args)
        {
            new Bus().PrintStatus();
            new Bus { Load = 5 }.PrintStatus();
            Console.ReadKey();
        }
    }
}
