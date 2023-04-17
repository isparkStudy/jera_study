public class Car
{
    private string name;
    public Car() : this("기본자동차")    // 생성자 포워딩
    {

    }
    
    public Car(string name)
    {
        this.name = name;               // this.필드 = 매개변수
    }
    
    public void Go() =>  System.Console.WriteLine($"{name} 자동차가 달리다.");

}

class Program
{
    static void Main(string[] args)
    {
        (new Car()).Go();

        System.Console.WriteLine();

        Car car2 = new Car("좋은자동차");
        car2.Go();
    }
}
