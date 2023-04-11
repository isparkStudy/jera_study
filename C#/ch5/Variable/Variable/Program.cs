using System;

// 변수(Variable) : 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇
class Variable
{
    static void Main(string[] args)
    {
        int number;                         // 정수형 번수 선언하기
        number = 1234;                      // 변수에 값 할당하기
        Console.WriteLine("{0}", number);   // 변수의 값을 화면에 출력(사용)
        Console.WriteLine(1234);            // 정수 리터럴 
        Console.WriteLine(3.14F);           // 실수 리터럴
        Console.WriteLine('a');             // 문자 리터럴
        Console.WriteLine("HELLO");         // 문자열 리터럴
        Console.WriteLine("----------------------------------------------");

        // 변수 선언과 동시에 초기화
        int number1 = 7;                    
        Console.WriteLine("{0}", number1);
        Console.WriteLine("----------------------------------------------");

        // 콤마(,) 기호로 여러 개의 변수 선언
        int no1, no2, no3;                  
        no1 = 1;
        no2 = 2;
        no3 = 3;
        Console.WriteLine("{0}, {1}, {2}", no1, no2, no3);
        Console.WriteLine("----------------------------------------------");

        // 여러개의 변수를 선언하고 같은 값으로 초기화
        int a, b, c;
        a = b = c = 10;
        Console.WriteLine("{0},{1},{2}", a, b, c);
        Console.WriteLine("----------------------------------------------");

        // 상수 : 변하지 않는 변수, 읽기 전용 변수. 변수 선언 수 앞에 const 사용
        const int MAX = 100;
        const double PI = 3.141592;
        Console.WriteLine("최대값 {0}", MAX);
        Console.WriteLine("PI {0}", PI);


    }
}
