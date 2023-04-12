using System;

// 배열(Array): 하나의 이름으로 같은 데이터 형식을 여러 개 보관해 놓는 그릇
class Array
{
    static void Main(string[] args)
    {
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i,j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        string[] names = { "C#", "Windows Forms", "ASP.NET" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine();

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}