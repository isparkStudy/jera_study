using System;

class DataFormat
{
    static void Main()
    {
        // char 키워드: 문자 데이터 형식 변수를 선언. '' 사용
        // char는 구조체
        char grade = 'A';
        char kor = '가';
        char es = '\n';
        Console.WriteLine(grade);
        Console.WriteLine(kor);
        Console.WriteLine(es);
        Console.WriteLine("------------------------------------------------------------------");

        // String 키워드 : 문자열 데이터 형식 변수를 선언. "" 사용
        // String은 클래스
        string hi = "Hello World";
        Console.WriteLine(hi);
        Console.WriteLine("------------------------------------------------------------------");

        string multiLines = @"
            안녕하세요.
            반갑습니다.
        ";
        Console.WriteLine(multiLines);
        Console.WriteLine("------------------------------------------------------------------");

        // StringInterpolation
        // 문자열 보간법(보간된 문자열) $""
        Console.WriteLine($"{1234} is { "number" }");
        string message = "String Interpolation";
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("------------------------------------------------------------------");

        // String.Format() 메서드: 문자열 연결 관련 주요 기능 제공
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
        Console.WriteLine(msg);
        Console.WriteLine("------------------------------------------------------------------");

        // 논리 자료형: 참(true) 또는 거짓(false) 값 저장.
        // bool은 구조체
        // Boolean은 클래스
        bool bln = true;
        bool isFalse = false;
        Boolean b = true;
        Console.WriteLine(bln);
        Console.WriteLine(isFalse);
        Console.WriteLine(b);

    }
}