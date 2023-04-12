using System;

class Break
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 100; i++)
        {
            if(i == 5)
            {
                break;
            }
            Console.Write($"{(i+1)}번 반복 \t");
        }
        Console.WriteLine();

        int j = 0;
        while (true)            // while에 true 조건 설정 시 무한루프
        {
            if (j == 5)
            {
                break;
            }
            Console.Write($"{(j + 1)}번 반복 \t");
            j++;
        }
        Console.WriteLine();
    }
}