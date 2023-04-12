using System;

// for (초기식; 조건식; 증감식) {}
class ForDescription
{
    static void Main(string[] args)
    {
        int n = 100;
        int sum = 0;

        for(int i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"1부터 {n}까지의 짝수의 합: {sum}");
    }
}