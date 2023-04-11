using System;

// 연습문제: 증가, 감소 연산자 사용하기
class IncrementDecrementPractice
{
    static void Main(string[] args)
    {
        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 0;

        number1--;              // 1감소
        result1 = ++number1;    // 1증가

        ++number2;              // 1증가
        result2 = number2--;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}
