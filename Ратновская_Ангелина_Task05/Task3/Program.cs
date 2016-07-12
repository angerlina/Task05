using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            

            IEnumerable<object> g = new[] {"ds", "dsd","dfsfd", "fdfdf", "fdfdf"};

            MyConfigSection section = (MyConfigSection)ConfigurationManager.GetSection("MySection");
            if (section != null)
            {
                System.Diagnostics.Debug.WriteLine(section.DefaultCapacity);
          
            }

            Console.ReadLine();


            DynamicArray d = new DynamicArray(2);
       

            d.Add("rrer");
            d.Add("ff");
            d.AddRange(g);
            d.Remove("ff");
            var c = d.Remove("dsd000");
            var n = d.Insert(3, "d");
            d.Insert(2, "ds");
            d[3] = "23";

            foreach (var element in d)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(d[0]);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
