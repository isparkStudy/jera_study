using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속: 부모 클래스에 정의된 기능을 다시 사용, 확장 및 수정하여 자식클래스로 만들기

namespace InheritanceDemo
{
    public enum CarType { EV, ICEV }

    public abstract class CarBase
    {
        public abstract void Left();        // 추상 클래스의 추상 메서드. 메서드 본문 없이 시크니처만 제공하면 됨. => 표준(강제) => 인터페이스
        public void Back() => Console.WriteLine("후진하다.");
        protected string LeftMessage { get; private set; } = "좌회전하다.";      // 자식에게만 멤버 노출. protected
    }

    public class Car : CarBase
    {
        public CarType Style { get; private set; }      // 공통
        public override void Left() => Console.WriteLine(base.LeftMessage);     // 실제 코드 구현, 재정의
        public void Go() => Console.WriteLine("달리다.");
        public Car(CarType carType)
        {
            Style = carType;
        }
    }

    public class Benz : Car     // Car 클래스를 상속 받음. Child : Parent
    {
        
        public Benz() : this(CarType.ICEV) { }
        public Benz(CarType carType) : base(carType) { }       // base는 부모
    }

    public class Tesla : Car
    {
        public Tesla() : this(CarType.EV) { }
        public Tesla(CarType carType) : base(carType) { }
    }

    // 봉인(최종) 클래스
    // sealed 붙여준다.
    public sealed class Future : Car
    {
        public Future() : this(CarType.EV) { }
        public Future(CarType carType) : base(carType) { }
        public new void Go()        // 부모 메서드 재정의. 자식 메소드 앞에 new 붙여준다.
        {
            base.Go(); Console.WriteLine("날다.");
        }
    }

    //public class OtherFuture : Future { }

    class InheritanceNote
    {
        static void Main(string[] args)
        {
            Benz benz = new Benz();
            benz.Go();
            Console.WriteLine($"{benz.Style}");
            benz.Back();
            benz.Left();
            
            Console.WriteLine();

            Tesla tesla = new Tesla();
            tesla.Go();
            Console.WriteLine($"{tesla.Style}");
            tesla.Back();
            tesla.Left();

            Console.WriteLine();

            Future future = new Future();
            future.Go();


        }
    }
}
