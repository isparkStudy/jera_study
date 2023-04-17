using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortAlgorithm
{
    static void Main(string[] args)
    {
        int[] data = { 3, 1, 2, 5, 4 };
        //Array.Sort(data);
        //data.OrderBy(d => d);
        //data.OrderByDescending(d => d);

        // 선택 정렬 알고리즘
        for (int i = 0; i <= data.Length - 1; i++)
        {
            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[i] > data[j])  // 부등호 방향: 오름차순 >, 내림차순 <
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }

        for (int i = 0; i < data.Length; i++)
        {
            Console.Write($"{data[i]}");
        }
        Console.WriteLine();
    }
}