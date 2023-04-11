using System;

// 사용자한테 얻은 정보를 변수에 저장하기
// Consloe.ReadLine()으로 콘솔(터미널)로부터 데이터 입력 받기

class ReadLineNote2
{
    static void Main()
    {
        /*
        Console.WriteLine("정수: ");
        string num = Console.ReadLine();    // ReadLine()은 입력된 값이 문자열 ex) 1234 -> "1234"
        int number = Convert.ToInt32(num);  // 입력된 문자열을 정수로 변환. ex) "1234" -> 1234
        Console.WriteLine(number + number);
        */

        int number = 10;    // 2진수 변환 -> 0000 1010
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.WriteLine("----------------------------------------------");

        int b1 = 0b0010;    // 2진수를 10진수로 표현.
        Console.WriteLine(b1);
        Console.WriteLine("----------------------------------------------");

        string name = "RedPlus";
        var name2 = "RedPlus";      // var 키워드: 암시적으로 형식화된 로컬변수
        Console.WriteLine(name + '\n' + name2);
        Console.WriteLine("----------------------------------------------");

        int i = default;
        double d = default;
        char c = default;
        string s = default;
        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(c);
        Console.WriteLine(s);
    }
}