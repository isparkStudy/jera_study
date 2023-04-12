using System;

// goto문: 지정한 레이블(책갈피)로 이동하는 구문. 개발 시 사용하지 않는게 관례.
class Goto
{
    static void Main(string[] args)
    {
        Console.WriteLine("시작");

        Start:
        Console.WriteLine("0, 1, 2 중 하나 입력: _\b");
        int chapter = Convert.ToInt32(Console.ReadLine());

        if(chapter == 1)
        {
            goto Chapter1;
        }
        else if(chapter == 2)
        {
            goto Chapter2;
        }
        else
        {
            goto End;
        }

        Chapter1:
        Console.WriteLine("1장 입니다.");
        Chapter2:
        Console.WriteLine("2장 입니다.");
        goto Start;                         // 처음으로 이동

        End:
        Console.WriteLine("종료");
    }
}