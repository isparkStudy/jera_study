using System;

class StringClass
{
    static void Main()
    {
        string message = "hello world";

        // 문자열 관련 함수
        Console.WriteLine(message.ToUpper());
        Console.WriteLine(message.ToLower());
        Console.WriteLine(message.Replace("hello", "안녕하세요.").Replace("world","세계."));
        Console.WriteLine();

        String s1 = "안녕하세요.";                           // String 클래스
        string s2 = "반갑습니다.";                           // string 키워드
        char[] ch = s2.ToCharArray();                       // ToCharArray() 메서드로 문자열을 문자 배열로 변환

        for (int i = 0; i < ch.Length; i++)
        {
            Console.WriteLine(ch[i]);
        }

        Console.WriteLine($"{s1} {s2}");
        Console.WriteLine($"{s1.Length}, {s2.Length}");     // 문자열 길이: String.Length 속성
        Console.WriteLine();

        // 문자열 연결: 더하기 연산자, String.Concat() 메서드
        string st1 = "안녕" + "하세요.";
        string st2 = String.Concat("반갑", "습니다.");
        Console.WriteLine($"{st1} {st2}");
        Console.WriteLine();

        // 문자열 묶는 3가지 표현 방법 정리
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";
        
        displayName = lastName + firstName;                               // 더하기(+) 연산자
        Console.WriteLine(displayName);

        displayName = string.Format("이름: {0}{1}", lastName, firstName); // string.Format 메서드 사용
        Console.WriteLine(displayName);

        displayName = $"이름: {lastName}{firstName}";                     // 문자열 보간법 사용
        Console.WriteLine(displayName);
        Console.WriteLine();

        // 문자열 비교하는 2가지 방법 정리
        string userName = "Red";
        string userNameInput = "red";

        if (userName.ToLower() == userNameInput.ToLower())                                         // == 연산자 사용
        {
            Console.WriteLine("같습니다.");
        }

        if (string.Equals(userName, userNameInput, StringComparison.InvariantCultureIgnoreCase))    // string.Equals() 메서드 사용
        {
            Console.WriteLine("같습니다.");
        }
        Console.WriteLine();

        // 문자열 값 비교: 대소문자
        string n1 = "Gilbut";
        string n2 = "gilbut";

        if (n1 == n2)
        {
            Console.WriteLine("같다.");
        }
        else
        {
            Console.WriteLine("다르다");
        }
        if (n1.Equals(n2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("같다.");
        }
    }
}
