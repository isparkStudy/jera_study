using System;

class EnumerationTest
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;             // 콘솔에 출력되는 텍스트 색을 변경
        Console.WriteLine("Red");
        Console.ResetColor();                                   // 콘솔에 출력되는 텍스트 색을 초기화

        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.White;          // 콘솔에 출력되는 텍스트의 배경색을 변경
        Console.WriteLine($"{nameof(ConsoleColor.Green)} & {nameof(ConsoleColor.White)}");
        Console.ResetColor();

        }
    }

}
