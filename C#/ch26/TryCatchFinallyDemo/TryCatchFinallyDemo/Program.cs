using System;

class TryCatchFinallyDemo
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 0;
        int r;

        try
        {
            r = x / y;
            Console.WriteLine($"{x} / {y} = {r}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"예외 발생: {e.Message}");
        }finally
        {
            Console.WriteLine("프로그램 종료합니다.");
        }
    }
}