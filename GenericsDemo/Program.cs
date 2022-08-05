using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {

        
       public static void Toprint(double[] inputarray)
        {
            foreach (double element in inputarray)
            {
                Console.WriteLine(element);
            }
        Console.WriteLine("--------------------");
        }

        public static void Toprint(char[] inputarray)
        {
            foreach(char element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------");

        }
        static void Main(string[] args)
        {
            double[]IntArray = {1.2,1.3,1.4,1.6};
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

          
            Program.Toprint(IntArray);
            Program.Toprint(charArray);

        }

    }
}
