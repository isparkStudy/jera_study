using System;

class Messenger
{
    public void PrintMessage(string message, string prefix = "", string suffix = "")
    {
        Console.WriteLine($"{prefix}{message}{suffix}");
    }
}

class MethodOverloadNamed
{
    static void Main(string[] args)
    {
        Messenger msg = new Messenger();
        msg.PrintMessage("My");
        msg.PrintMessage(prefix: "Oh ", message: "My");
        msg.PrintMessage(prefix: "Oh ", message: "My ", suffix: "God");
    }
}