using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 7,9,8,3,4,2,0 };

            Array.Sort(niz);
            foreach (int i in niz)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
