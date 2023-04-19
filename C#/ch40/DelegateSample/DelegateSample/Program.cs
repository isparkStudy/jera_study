using System;

// 대리자(Delegate): 함수 포인터, 메서드 대신 호출, 대리 운전
class DelegateSample
{
    static void GoForward() => Console.WriteLine("직진");
    static void GoLeft() => Console.WriteLine("좌회전");
    static void GoFast() => Console.WriteLine("과속");
    //static void GoRight() => Console.WriteLine("우회전");
    delegate void CarDriver();  // 대라자 형식 생성

    static void Main(string[] args)
    {
        //GoForward();  // 메서드 직접 호출
        //CarDriver goHome = new CarDriver(GoForward);  // 메서드 대리 호출
        CarDriver goHome = GoForward;
        goHome += GoLeft;
        goHome += GoFast;   // GoFast 메서드 대리 호출
        goHome -= GoFast;   // GoFast 메서드 대리 호출 취소
        goHome += delegate () { Console.WriteLine("우회전"); };    // 무명(익명) 메서드 생성
        //goHome += delegate () { Console.WriteLine("후진"); };
        goHome += () => Console.WriteLine("후진");    // 람다식 표현
        goHome();   // goHome.Invoke();
        Console.WriteLine();

        // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성: Func<T>, Action<T>, Predicate<T>, ...
        Action driver = GoForward;
        driver += GoLeft;
        driver += delegate () { Console.WriteLine("우회전"); };
        driver += () => Console.WriteLine("후진");
        driver += () => Console.WriteLine("정지");
        driver();   // 트리거(방아쇠)를 사용해서 호출
        Console.WriteLine();

        Action go = () => Console.WriteLine("운전");
        go();

        RunLamda(() => Console.WriteLine("매개 변수로 람다식(함수이름, 무명메서드) 전달"));
    }
    static void RunLamda(Action action) => action();

}