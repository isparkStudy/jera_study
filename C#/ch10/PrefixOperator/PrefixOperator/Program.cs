using System;

class PrefixOperator
{
    static void Main()
    {
        int i = 3;
        int j = ++i;            // 전위(Prefix) 증감 연산자: 우선순위가 높음
        Console.WriteLine(j);
        Console.WriteLine("------------------------------------------");

        int x = 3;
        int y = x++;            // 후위(Postfix) 증감 연산자: 우선순위가 낮음
        Console.WriteLine(y);
        Console.WriteLine(x);
        Console.WriteLine("------------------------------------------");

    }
}
