using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int var1 = 10;
            float var2 = 5;
            for(int counter = 0; counter < 5; counter++)
            {
                var1 += 1;
                var2 += (float)2.1;
            }
            if (var1 > var2 || var1 < var2)
            {
                var1 = (int)var2;
            }
            if (var2 > 15 && var1 == var2)
                var2 = var1;
            else
            {
                var1 += (int)var2;
            }
            var2 += var1;
            Console.WriteLine(var2);
            Console.ReadLine();

        }
    }
}
