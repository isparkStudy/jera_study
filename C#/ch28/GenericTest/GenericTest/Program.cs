using System;
using System.Collections.Generic;

class GenericTest
{
    static void Main(string[] args)
    {
        // List<T>
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);

        for (int i = 0; i < numbers.Count; i++) 
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        List<string> colors = new List<string>();
        colors.Add("red");
        colors.Add("green");
        colors.Insert(0, "blue");

        for (int i = 0; i < colors.Count; i++)
        {
            Console.Write($"{colors[i]} ");
        }
        Console.WriteLine();

        // Dictionary<T>
        Dictionary<int, String> todos = new Dictionary<int, string>();
        todos.Add(1, "C#");         // 키와 값으로 입력
        todos.Add(2, "ASP.NET");
        todos.Add(3, "...");

        foreach (var item in todos)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}