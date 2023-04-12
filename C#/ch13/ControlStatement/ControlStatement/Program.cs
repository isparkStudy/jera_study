using System;

class ControlStatement
{
    static void Main()
    {
        int score = 59;
        if (score >= 60)
        {
            Console.WriteLine("합격");
        }
        else
        {
            Console.WriteLine("불합격");
        }

        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if(score >= 80)
        {
            Console.WriteLine("B");
        }
        else if(score > 70)
        {
            Console.WriteLine("C");
        }
        else if(score >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
