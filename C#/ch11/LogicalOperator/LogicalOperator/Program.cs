using System;

// 논리연산자
// && (AND) 연산자 : 둘 다 참일 때만 참.
// || (OR) 연산자 : 하나라도 참이면 참.
// ! (NOT) 연산자 : 참이면 거짓, 거짓은 참으로
class LogicalOperator
{
    static void Main()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3);
        Console.WriteLine(r);
        
        r = (i != 3) || (j == 3);
        Console.WriteLine(r);

        r = (i >= 5);
        Console.WriteLine("{0}", !r);



        
    }
}