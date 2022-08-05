using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        public static void Toprint<T>(T[] inputarray)
        {
            foreach( var element in inputarray )
            {
                Console.WriteLine(element);
            
            }
            Console.WriteLine("------------------");

        }


   
       
        static void Main(string[] args)
        {
            double[]DoubleArray = {1.2,1.3,1.4,1.6};
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            int[] intArray = { 0, 1, 2, 3, 4 };          
           

        Program.Toprint<int>(intArray);
        Program.Toprint<Char>(charArray);
        Program.Toprint<Double>(DoubleArray);



        }

    }
}
