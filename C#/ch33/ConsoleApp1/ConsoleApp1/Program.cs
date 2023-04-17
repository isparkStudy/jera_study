namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            // NameSpace로 구분하면 동일한 이름의 Class를 만들 수 있다.
            Foo.Car car1 = new Foo.Car(); car1.Go();
            Bar.Car car2 = new Bar.Car(); car2.Go();
        }
    }
}