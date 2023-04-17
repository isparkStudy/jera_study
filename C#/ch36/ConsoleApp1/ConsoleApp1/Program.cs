namespace ConsoleApp1
{
    class Car
    {
        private string _name;
        public Car() : this("기본자동차") { }
        public Car(string name)
        {
            _name = name;
            System.Console.WriteLine($"[1] {this._name} 생성, 조립, 시동");
        }
        public void Go() => System.Console.WriteLine($"[2] {this._name} 달리다.");
        ~Car()              // ~클래스명 : 소멸자
        {
            System.Console.WriteLine($"[3] {this._name} 소멸");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); car1.Go();
            Car car2 = new Car("캠핑카"); car2.Go();
        }
    }
}
