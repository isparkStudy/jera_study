using System;

// 반복문: for문(구간반복), while문(조건반복), do문(실행반복), foreach문(배열반복)
class repetitiveStatement
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Hello");
        }
        Console.WriteLine();

        const int N = 100;
        int sum = 0;
        int s = 1;
        while (s <= N)
        {
            sum += s;
            s++;
        }
        Console.WriteLine($"1부터 {N}까지의 합은 : {sum}");
        Console.WriteLine();

        int dosum = 0;
        int t = 1;
        do
        {
            if(t % 3 == 0 && t % 4 ==0)
            {
                dosum += t;
            }
            t++;
        } while (t <= 100);
        Console.WriteLine($"합계: {dosum}");
        Console.WriteLine();

        string[] names = { "C#", "ASP.NET" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}