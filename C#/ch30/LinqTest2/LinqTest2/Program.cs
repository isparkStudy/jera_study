using System;
using System.Collections.Generic;
using System.Linq;


class LinqTest2
{
    static void Main(string[] args)
    {
        List<string> techs = new List<string>();
        techs.Add("C#");
        techs.Add("ASP.NET");
        techs.Add("Blazor");

        var ts = techs.OrderByDescending(t => t);
        foreach (var t in ts)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();

        var numbers = Enumerable.Range(1, 100);         // 1~100까지 생성
        //var nums = numbers.Where(n => n % 2 == 0);
        var nums = numbers.OrderByDescending(n => n).Where(n => n % 2 == 0);

        foreach (var num in nums)
        {
            Console.Write(num);
        }

    }
}