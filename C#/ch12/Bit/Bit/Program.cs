using System;

// & 연산자: 비트 AND 연산자(둘 다 1일때만 1)
// | 연산자: 비트 OR 연산자(하나라도 1이면 1)
// ^ 연산자: 비트 XOR 연산자(서로 다르면 1)
// ~ 연산자: 비트 NOT 연산자(1 <-> 0, 비트 반전)
class Program
{
    static void Main(string[] args)
    {
        byte x = 0b1010;
        byte y = 0b1100;

        Console.WriteLine(x & y);
        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
        Console.WriteLine($"& {Convert.ToString(y, 2)} -> {y}");
        Console.WriteLine("-------------");
        Console.WriteLine($"  {Convert.ToString(x & y, 2)} -> {x & y, 2}");

        Console.WriteLine();

        Console.WriteLine(x | y);
        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
        Console.WriteLine($"| {Convert.ToString(y, 2)} -> {y}");
        Console.WriteLine("-------------");
        Console.WriteLine($"  {Convert.ToString(x | y, 2)} -> {x | y,2}");

        Console.WriteLine();

        Console.WriteLine(x ^ y);
        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");
        Console.WriteLine($"^ {Convert.ToString(y, 2)} -> {y}");
        Console.WriteLine("-------------");
        Console.WriteLine($"  {Convert.ToString(x ^ y, 2)} -> {x ^ y,2}");

        Console.WriteLine();

        Console.WriteLine($"~ {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");
        Console.WriteLine("-------------");
        Console.WriteLine($"  {Convert.ToString((byte)~x, 2).PadLeft(8, '0')} -> {~x, 3}");

    }
}
