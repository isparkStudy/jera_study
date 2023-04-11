using System;

class SignedInteger
{
    static void Main(String[] args)
    {
        sbyte sb = 127;
        short st = 32767;
        int i = Int32.MaxValue;
        long l = Int64.MaxValue;
        Console.WriteLine("{0},{1},{2},{3}", sb, st, i, l);
        Console.WriteLine();

        // 부호없는 정수 데이터 형식: byte, ushort, uint, ulong
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(ushort.MaxValue);
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(byte.MinValue);
        Console.WriteLine();

        // double 키워드: 실수형 데이터 형식(64비트 부동 소수점 숫자)
        double PI = 3.141592;
        double pi = 3.14D;
        Console.WriteLine(PI);
        Console.WriteLine(pi);
        Console.WriteLine(System.Double.MaxValue);
        Console.WriteLine();

        // float 키워드: 실수형 데이터 형식(32비트 부동 소수점 숫자)
        // float f = 3.14;      // 실수의 기본형이 double 이므로 float형 표현 시 f를 붙여줘야함.
        float f = 3.14f;
        Console.WriteLine(f);
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(float.MinValue);
        Console.WriteLine();

        // decimal 키워드 : 실수형 데이터 형식(128비트 10진수)
        //decimal money = 12.34;     // 실수의 기본형이 double 이므로 decimal형 표현 시 m을 붙여줘야함.
        decimal money = 12.34m;
        Console.WriteLine(money);
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(decimal.MinValue);
        Console.WriteLine();

        // null 표현 방식
        //int x = null;
        int? x = null;
        double? y = null;


    }
}