using System;
using System.Collections;
using System.Collections.Generic;       // Collection

class CollectionUse
{
    static void Main(string[] args)
    {
        string[] colors = { "red", "green", "blue" };
        Console.WriteLine(colors[0]);
        Console.WriteLine(colors[1]);
        Console.WriteLine(colors[2]);
        // Console.WriteLine(colors[100]);
        Console.WriteLine();

        Array.Sort(colors);             // 배열 내 데이터 Sorting
        foreach(var color in colors)
        {
            Console.WriteLine(color);
        }
        Console.WriteLine();

        Stack stack = new Stack();      // LIFO
        stack.Push(100);
        stack.Push(200);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine();

        Queue queue = new Queue();      // FIFO

        queue.Enqueue(100);
        queue.Enqueue(200);
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine();

        ArrayList list = new ArrayList();
        list.Add(100);
        list.Add(100);
        list.RemoveAt(1);
        list.Add(200);
        list.Insert(0, 50);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i].ToString());
        }
        Console.WriteLine();

        Hashtable hashtable = new Hashtable();
        hashtable[0] = "JerajinSolution";
        hashtable["NickName"] = "red";
        Console.WriteLine(hashtable[0]);
        Console.WriteLine(hashtable["NickName"]);
    }
}