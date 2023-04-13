using System;

// 예외 처리(Exception Handling): try-catch-finally와 throw를 사용하여 예외처리하기
class ExceptionDemo
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}