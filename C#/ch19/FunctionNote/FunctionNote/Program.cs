using System;

// 함수(메서드): 반복해서 사용하도록 만들어진 하나 이상의 문을 포함하는 코드 블록
class FunctionNote
{
    // 함수 선언
    static int Sum(int first, int second)
    {
        int sum = first + second;
        return sum;
        //Console.WriteLine($"합계: {sum}");
    }

    // 함수 호출
    static void Main(string[] args)
    {
        /*
        int first = Convert.ToInt32(args[0]);
        int second = Convert.ToInt32(args[1]);
        */
        int result = Sum(3, 5);
        Console.WriteLine(result);
    }
}