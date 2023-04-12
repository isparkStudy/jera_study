using System;

// 선택문(switch 문): switch와 case 그리고 default 키워드를 사용하여 다양한 조건 처리
class Switch
{
    static void Main()
    {
        Console.WriteLine("정수를 입력하세요");
        int answer = Convert.ToInt32(Console.ReadLine());

        switch (answer)
        {
            case 1:
                Console.WriteLine("1을 선택했습니다.");
                break;
            case 2:
                Console.WriteLine("2를 선택했습니다.");
                break;
            case 3:
                Console.WriteLine("3을 선택했습니다.");
                break;
            default:
                Console.WriteLine("그냥 찍으셨군요.");
                break;
        }
    }

}


