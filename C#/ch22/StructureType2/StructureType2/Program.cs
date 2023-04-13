using System;

class StructureType2
{
    static void Main(string[] args)
    {
        // Time 구조체: DateTime, TimeSpan(날짜에 대한 차이를 구하는 구조체)
        DateTime now = DateTime.Now;
        Console.WriteLine(now);

        TimeSpan ts = (DateTime.Now - (new DateTime(2023, 1, 1)));
        Console.WriteLine(ts.TotalDays);
        Console.WriteLine(Math.Ceiling((DateTime.Now - (new DateTime(2023, 1, 1))).TotalDays));

        // Char 구조체
        Console.WriteLine(Char.ToUpper('a'));
        Console.WriteLine(Char.IsWhiteSpace(' '));
        Console.WriteLine(Char.IsWhiteSpace('b'));
        Console.WriteLine(Char.IsDigit('5'));
        Console.WriteLine(Char.IsDigit('b'));

        //Guid 구조체: 랜덤으로 유니크한 값을 반환. 한번 나온값은 절대 나오지 않는다.
        Console.WriteLine(Guid.NewGuid());
        

    }
}