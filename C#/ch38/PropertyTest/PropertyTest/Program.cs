using System;

class Car
{
    public string Name { get; set; } = "My Car";

    /*
     * 기본적인 get, set 사용법
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    */

    /*
     * 자바 식 get, set 구문
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
    */
}

class PropertyTest
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Name = "Your Car";
        Console.WriteLine($"{nameof(car.Name)}: {car.Name}");

        Car car1 = new Car() { Name = "Your Car" };       // Object Initializer
        Console.WriteLine(car1.Name);
        //car.SetName("My Car");
        //Console.WriteLine(car.GetName());

        Console.WriteLine((new Car()).Name);
        Console.WriteLine();

        var person = new { Name = "Red", Age = 21 };        // 익명(무명) 형식
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
        Console.WriteLine();

        Car car3 = new Car { Name = null };
        Console.WriteLine(car3.Name);
        Console.WriteLine(car3?.Name ?? "대포차");
    }
    
}