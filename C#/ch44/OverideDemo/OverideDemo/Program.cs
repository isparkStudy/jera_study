using System;

namespace OverideDemo
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
        public virtual void Work() => Console.WriteLine("부모_프로그래머.");   // virtual: 자식 클래스에서 메소드를 재정의해서 사용 가능
    }

    class Child : Parent
    {
        // 부모 메서드 재정의
        //public void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다.");
        public override void Walk() => base.Walk(); // 관대한 부모의 의견을 따른다.
        public override void Work() => Console.WriteLine("자식_프로게이머");
    }

    class OverideDemo
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Say();    // 자식이 예의 없는 경우: X -> X
            child.Run();    // 자식이 예의 있는 경우: X -> new
            child.Walk();   // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
            child.Work();   // 부모도 관대하고 자식도 예의가 있는 경우: virtual -> override
        }
    }
}
