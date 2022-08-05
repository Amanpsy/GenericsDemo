using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class PrintArray<T>
    {
        public T[] inputArray;
        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toDisplay()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------");

        }


    }
    public class program
    {
         public static void Main(string[] args)
        {
            double[] doubleArray = { 1.2, 1.3, 1.4, 1.5, 1.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            int[] intArray = { 0, 1, 2, 3, 4, 5, };


            new PrintArray<int>(intArray).toDisplay();
            new PrintArray<char>(charArray).toDisplay();
            new PrintArray<double>(doubleArray).toDisplay();

        } 
    }
    


   








}

