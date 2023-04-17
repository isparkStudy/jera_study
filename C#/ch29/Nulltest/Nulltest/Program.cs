using System;
using System.Collections.Generic;

class Nulltest
{
    static void Main(string[] args)
    {
        int i = 0;                          // 정수형에는 null 불가
        int? j = null;                      // 정수형에 null 값을 넣어 줄 수 있음. 형식: int? = null, double? = null
        string empty = "";                  // 빈값(Empty)은 null과 다름
        string s = null;                    // 참조형(Reference)에는 null 할당 가능
        s = "안녕하세요";
        Console.WriteLine(i);
        Console.WriteLine(empty);
        Console.WriteLine(s);
        Console.WriteLine();

        // Nullable<T> 구조체를 사용하여 널 가능 형식 변수 만들기
        Nullable<bool> bln = null;          // Nullable 형식 : null(값이 없음을 의미)이 할당될 수 있는 형식
        Console.WriteLine(bln.HasValue);

        bln = true;
        Console.WriteLine(bln.HasValue);
        Console.WriteLine();

        // ?? 연산자 (널 병합 연산자)
        string nullValue = null;
        string message = "";

        nullValue = null;
        if (nullValue == null)
        {
            message = "[1] null이면 새로운 값으로 초기화합니다.";
        }
        Console.WriteLine(message);
        Console.WriteLine();

        nullValue = null;
        message = nullValue ?? "[2] null이면 새로운 값으로 초기화 합니다.";
        Console.WriteLine(message);
        Console.WriteLine();

        int? value = null;                  // null 가능 형식에 null로 초기화
        int defaultValue = value ?? -1;     // value가 null이면 -1 대입
        Console.WriteLine(defaultValue);
        Console.WriteLine();

        int? x = null;
        int y = x ?? 100;                   // x가 null이면 100으로 초기화
        int z = x ?? default;               // 정수형의 기본값인 0으로 초기화
        Console.WriteLine($"{x}, {y}, {z}");
        Console.WriteLine();

        // null 조건부 연산자(Null Coditional Operator): ?.
        double? d = 1.0;
        Console.WriteLine(d?.ToString());    // ?. : 컬렉션이 null이면 null 값을 출력, 그렇지 않으면 속성 값 출력
        Console.WriteLine(d?.ToString("#.00"));

        int? len;
        string msg;

        msg = null;
        len = msg?.Length;
        Console.WriteLine(len);
        Console.WriteLine();

        msg = "안녕";
        len = msg?.Length;
        Console.WriteLine(len);
        Console.WriteLine();

        List<string> list = null;
        int? numberOfList;
        numberOfList = list?.Count;
        Console.WriteLine(numberOfList);

        list = new List<string>();
        list.Add("안녕하세요.");
        list.Add("반갑습니다.");
        numberOfList = list?.Count;
        Console.WriteLine(numberOfList);


    }
}