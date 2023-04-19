using System;

namespace InterfaceNote
{
    public interface ICarStandard
    {
        void Left();
    }

    public abstract class KS
    {
        public abstract void Back();
        public void Fly() => Console.WriteLine("날다");
    }

    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }

    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    public sealed class Car : MyCar, ICarStandard      // 상속은 1:1만 가능. 다중 상속은 인터페이스만 가능.
    {
        public void Left() => Console.WriteLine("좌회전");
        public void Run() => Console.WriteLine("직진");
    }

    //class SpyCar : Car { }

    public class InterfaceNote
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            car.Right();
            car.Back();
            car.Left();
            car.Fly();
            //SpyCar spy = new SpyCar();
            //spy.Run();
        }
    }
}
