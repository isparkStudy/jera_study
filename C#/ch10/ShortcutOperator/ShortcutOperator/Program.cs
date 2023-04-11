using System;

class ShortcutOperator
{
    static void Main()
    {
        int x = 3;
        int y = 3;

        x = x + 2;      // 기본형
        y += 2;         // 축약형

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine("------------------------------");
        int a = 3;
        int b = 5;
        
        b += a; // 누적: b변수에 a변수의 값을 누적
        Console.WriteLine(b);
        Console.WriteLine("------------------------------");

        b -= a; // 가감: b에서 a를 뺀 후 다시 b에 할당
        Console.WriteLine(b);
    }
}