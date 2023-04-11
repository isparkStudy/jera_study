using System;

// 연산자(Operator): 데이터와 변수를 가지고 더하기(+), 빼기(-)와 같은 연산 작업을 수행
// 식(Expression)
// 문(Statement)
class Operator
{
    static void Main()
    {
        var num = 1000;
        var number = num + 1234;
        Console.WriteLine(number);
        Console.WriteLine("---------------------------------------");

        var value = 0;
        value = 8;
        Console.WriteLine(value);
        value = +value;
        Console.WriteLine(value);
        value = -value;
        Console.WriteLine(value);
        Console.WriteLine("---------------------------------------");

        var i = 10;
        var j = 20;
        var k = i + j;
        Console.WriteLine(k);
        Console.WriteLine("---------------------------------------");
    }
}