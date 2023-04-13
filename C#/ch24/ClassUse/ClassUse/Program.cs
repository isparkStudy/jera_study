using System;

class Square
{
    public int Width;
    public int Height;
    public static string Creator;       // static은 생성자없이 바로 사용가능.
}

class ClassUse
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Width = 100;
        square.Height = 100;
        Square.Creator = "RedPlus";
        Console.WriteLine($"{square.Width}, {square.Height}, {Square.Creator}");
        Console.WriteLine($"{Environment.OSVersion}, {Environment.UserName}");

        Random random = new Random();
        Console.WriteLine(random.Next(1, 6));       // 1~6사이의 값이 랜덤하게 출력
    }
}