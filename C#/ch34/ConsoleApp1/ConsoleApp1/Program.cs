using System;


public class Say
{
    private string message = "반갑습니다.";              // 필드
    public void Hi()
    {
        System.Console.WriteLine(this.message);
    }
}


public class Car
{
    private string color = "Red";
    public string GetColor()
    {
        return this.color;
    }
}


public class Person
{
    private string name = "박인수";
    private const int m_age = 31;
    private readonly string _NickName = "꽉수";

    public void ShowProfile()
    {
        Console.WriteLine($"{name} - {_NickName}");
    }


}


class Program
{
    private static string message = "안녕하세요.";       // 필드, 전역변수
    public static void Hi() => System.Console.WriteLine(message);

    public static void Main(string[] args)
    {
        int number = 1_234;                             // 변수, 지역변수
        System.Console.WriteLine(number);
        System.Console.WriteLine(message);
        Hi();
        System.Console.WriteLine();

        Say say = new Say();
        say.Hi();
        System.Console.WriteLine();

        Car car = new Car();
        System.Console.WriteLine(car.GetColor());
        Console.WriteLine();

        Person my = new Person();
        my.ShowProfile();
    }
}
