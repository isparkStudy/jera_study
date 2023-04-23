using System;
using System.Diagnostics;


namespace Dinner.Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // [1] 밥 만들기
            Rice rice = (new Cooking()).MakeRice();
        }
    }
}
