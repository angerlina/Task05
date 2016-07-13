
using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main()
        {


            IEnumerable<object> collection = new[] { "ds", "dsd", "dfsfd", "fdfdf", "fdfdf" };



            var array = new DynamicArray();

            array.Add("dfdfsdsdsdf");
            array.AddRange(collection);

            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();

        }
    }
}