using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedProject1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();

            p.id = 1;
            p.name = "Kevin";

            Console.WriteLine(p.name);

        }
    }
}
