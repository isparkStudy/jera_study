using System;
using System.Collections.Generic;
using System.Linq;

// LINQ: C# 언어에 직접 쿼리(Query) 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
class LinqTest
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"numbers 배열의 합: {sum}");

        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Average());
        Console.WriteLine(numbers.Count());
        Console.WriteLine();

        // 람다식
        var nums = numbers.Where(n => n % 2 == 0);                      // 2의 배수
        
        foreach(var num in nums)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        var ns = numbers.Where(n => n % 2 == 0 || n % 3 == 0).Sum();    // 2의 배수 또는 3의 배수인 정수의 합
        Console.WriteLine(ns);



    }
}