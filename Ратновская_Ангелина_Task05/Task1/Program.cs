using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество человек:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            IList<int> peopleList = new List<int>(10);
            for (var i = 0; i <= n - 1; i++)
            {
                peopleList.Add(i+1);
            }
            var remove = false;
            var counter = 0;
            while ( peopleList.Count()!=1)

            {
                    for (var i = 0; i < peopleList.Count; ++i)
                    {
                        if (remove)
                        {
                            peopleList.RemoveAt(i--);
                        }
                        remove = !remove;
                    }

                counter++;        
               Console.WriteLine($"круг №{counter}");

                foreach (var element in peopleList)
                {
                    Console.WriteLine(element);                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

