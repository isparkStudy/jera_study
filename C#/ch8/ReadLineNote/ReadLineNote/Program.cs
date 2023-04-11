using System;

class MyClass
{
    static void Main(string[] args)
    {
        /*
        //Console.ReadLine();     // 이 시점에서 대기하는 효과
        Console.Write("이름: ______\b\b\b\b\b\b");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}님, 안녕하세요.");
        */
        int x = Console.Read();     // 문자 하나를 입력
        Console.WriteLine(x); ;     // 아스키코드(ASCII)로 반환 출력
        Console.WriteLine(Convert.ToChar(x));   // 실제 문자 반환하여 출력

        int i = 1234;
        i.GetType();

        double d = 3.14;
        d.GetType();

        object o = new object();
        o.GetType();

    }

}