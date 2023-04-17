using System;

class Car
{
    public void Map(params string[] title)
    {
        foreach (var t in title)
        {
            Console.WriteLine(t);
        }
    }
}