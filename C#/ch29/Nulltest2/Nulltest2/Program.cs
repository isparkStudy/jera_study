using System;
using System.Collections.Generic;

class Nulltest2
{
    static void Main(string[] args)
    {
        // null 병합 연산자와 null 조건부 연산자 함께 사용하기
        int num;
        List<string> list;

        // 컬렉션 리스트가 null이면 Count를 읽을 수 없에 0으로 초기화
        list = null;
        num = list?.Count ?? 0;     // null이면 0을 반환, 오른쪽 값 사용
        Console.WriteLine($"반환 값: {num}");
        Console.WriteLine();

        // 컬렉션 리스트가 null이 아니면 Count 속성의 값을 사용
        list = new List<string>();
        list.Add("또 만나요.");
        num = list?.Count ?? 0;
        Console.WriteLine($"반환 값: {num}");
    }
}