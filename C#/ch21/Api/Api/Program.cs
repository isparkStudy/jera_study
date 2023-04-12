using System;

class Api
{
    static void Main(string[] args)
    {
        // 1. System.Math Class
        // Static member
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.Max(5,3));
        Console.WriteLine(Math.Abs(-10));

        // 2. System.Random Class
        // Instance Member
        Random dice = new Random();
        Console.WriteLine(dice.Next(1,7));
    }
}
