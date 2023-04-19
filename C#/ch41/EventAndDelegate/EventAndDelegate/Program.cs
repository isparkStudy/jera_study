namespace EventAndDelegateDemo
{
    // 이벤트 구독자(Subscriber)
    class EventAndDelegate
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.warning += Car_warning;     // 이벤트 메서드 등록, += tap tap
            car.warning -= Car_warning;     // 이벤트 메서드 삭제
            car.warning += () =>            // 이벤트 처리기 람다식으로 생성
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("연료부족!!!");
                System.Console.ResetColor();
            };
            car.Go();
            //car.OnFuelEmptyReached();
            car.Go();
        }

        // 이벤트 처리기(핸들러)
        private static void Car_warning() => System.Console.WriteLine("연료 부족");
    } 
}