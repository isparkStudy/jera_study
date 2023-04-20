using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgorithmNugetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 33, 22, 55, 11 };

            int[] results = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var r in results)
            {
                Console.WriteLine(r);
            }

        }
    }
}
