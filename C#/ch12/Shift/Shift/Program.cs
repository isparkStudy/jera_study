using System;


class ProShiftgram
{
    static void Main()
    {
        Console.WriteLine("C# 시프트 연산자");

        byte x = 0b0000_0011;
        
        // Left Shift 연산자
        Console.WriteLine($"{nameof(x), 10}: {Convert.ToString(x,2).PadLeft(8, '0')} -> {x, 2}");
        Console.WriteLine($"x = x << 1: {Convert.ToString(x << 1, 2).PadLeft(8, '0')} -> {x << 1, 2} = {x} * (2)");
        Console.WriteLine($"x = x << 2: {Convert.ToString(x << 2, 2).PadLeft(8, '0')} -> {x << 2, 2} = {x} * (2 * 2)");
        Console.WriteLine($"x = x << 3: {Convert.ToString(x << 3, 2).PadLeft(8, '0')} -> {x << 3, 2} = {x} * (2 * 2 * 2)");

        Console.WriteLine("--------------------------------------------------");
        
        // Right Shift 연산자
        x = 0b0011000;
        Console.WriteLine($"{nameof(x),10}: {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x,2}");
        Console.WriteLine($"x = x >> 1: {Convert.ToString(x >> 1, 2).PadLeft(8, '0')} -> {x >> 1,2} = {x} / (2)");
        Console.WriteLine($"x = x >> 2: {Convert.ToString(x >> 2, 2).PadLeft(8, '0')} -> {x >> 2,2} = {x} / (2 * 2)");
        Console.WriteLine($"x = x >> 3: {Convert.ToString(x >> 3, 2).PadLeft(8, '0')} -> {x >> 3,2} = {x} / (2 * 2 * 2)");

    }

}
