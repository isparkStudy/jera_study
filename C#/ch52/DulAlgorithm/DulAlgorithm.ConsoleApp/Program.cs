using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgorithm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1] Input
            int[] data = { 1, 4, 3, 2, 5 };

            // [2] Process
            int[] numbers = DulAlgorithm.Algorithm.SelectionSort(data);

            // [3] Output
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}