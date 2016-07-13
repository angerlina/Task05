using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            IList<int> peopleList = new List<int>(10);
            for (var i = 0; i <= n - 1; i++)
            {
                peopleList.Add(i+1);
            }
            foreach (var element in peopleList  )
            {
                if (peopleList.IndexOf(element)%2 == 0)
                {
                   peopleList.Remove(element);               
                }
            }



        }
    }
}
