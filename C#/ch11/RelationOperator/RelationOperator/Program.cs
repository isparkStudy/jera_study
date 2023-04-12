using System;

// 관계형(비교) 연산자
// >, <, >=, <=, ==(같은지), !=
class RelationOperator
{
    static void Main()
    {
        int firstNum = 10;
        int secondNum = 5;
        bool r = false;

        Console.WriteLine(firstNum > secondNum);
        Console.WriteLine("------------------------------------------------");

        r = (firstNum <= secondNum);
        Console.WriteLine(r);
        Console.WriteLine("------------------------------------------------");

        r = (firstNum == secondNum);                    // C Family : ==, VB Family : =
        Console.WriteLine(r);
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("------------------------------------------------");

        r = (firstNum != secondNum);                    // C Family : !=, VB Family : <>
        Console.WriteLine(r);

    }
}