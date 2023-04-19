#define RELESE

using System;
using System.Diagnostics;
using System.Reflection;

// 특성 -> 튜닝
// 리플렉션 -> 자동차 전시회

namespace AttributeDemo
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("럭셔리!!");
    }
    //[LuxuryAttribute]
    [Luxury]
    class Car
    {
        [Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요.")]
        public void Manual() => Console.WriteLine("수동 운전");

        public void Auto() => Console.WriteLine("자동 운전");

        [Conditional("DEBUG")]      // 조건에 따라 실행
        public void Test() => Console.WriteLine("테스트 운전");

        [Conditional("RELESE")]     // 조건에 따라 실행
        public void Test2() => Console.WriteLine("테스트 운전");
    }

    class AttributeDemo
    {
        static void Main()
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Test();
            car.Test2();
            car.Manual();
            car.Auto();
            Console.WriteLine();

            // 리플렉션
            var carType = (new Car());
            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType, null);
        }
    }
}
