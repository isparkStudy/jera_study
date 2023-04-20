using System;

// Dynamic: 런타임에 데이터형식이 정되는 모든 형식을 담을 수 있는 특수한 유형의 형식. JavaScript의 var와 동일한 기능
namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x;
            x = 1_234;
            Console.WriteLine($"{x} - {x.GetType()}");

            x = "Dynamic Type!";
            Console.WriteLine($"{x} - {x.GetType()}");
        }
    }
}
