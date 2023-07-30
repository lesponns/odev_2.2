using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number, input, last;

            Console.Write("Give me a one number: ");
            last = double.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++) {
                Console.Clear();
                Console.Write("Give me a another one number: ");
                input = double.Parse(Console.ReadLine());
                last = last + input;
            }
            Console.Clear();
            Console.Write("Sum of Numbers:: " + last);
            Console.ReadKey();
        }
    }
}
