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
            for (int i = 0; i < 3; i++)
            {
               var tt = new RuntimeTextTemplate1();
                tt.GetName = "Name_" + i.ToString();
                string output = tt.TransformText();
                Console.WriteLine(output);
                Console.WriteLine("\r\n");

            }
        }
    }
}
