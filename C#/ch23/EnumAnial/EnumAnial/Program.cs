using System;

// 열거형: 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의
class EnumAnial
{
    enum Animal { Mouse, Cow, Tiger }
    
    static void Main(string[] args)
    {
        Animal animal = Animal.Tiger;
        Console.WriteLine(animal);
        Console.WriteLine((int)animal);                 // 인덱스(Tiger의 주소) 출력
        Console.WriteLine(nameof(Animal.Mouse));        // 문자열로 출력

        if (animal == Animal.Tiger)
        {
            Console.WriteLine("호랑이");
        }

    }
}