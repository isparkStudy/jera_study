using System;

// 구조체(Structure Types): 하나 이상의 변수 또는 배열을 묶어서 관리
struct Point
{
    public int x;       // public(공용)
    public int y;
    private int z;      // private(전용)
}

class StructureTypes
{
    static void Main(string[] args)
    {
        Point point;
        point.x = 100;
        point.y = 200;
        Console.WriteLine($"X: {point.x}, Y: {point.y}");
    }
}