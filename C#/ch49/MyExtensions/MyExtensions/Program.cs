using System;

// 확장 메서드 만들기
namespace MyExtensions
{
    static class StringExtension
    {
        public static string Five(this string msg) => msg.Substring(0, 5);
        public static string Ten(this string msg) => msg.Substring(0, 10);
        public static string AddElipsis(this string msg) => msg + "...";
        public static string AddElipsis(this string msg, string elipsis) => $"{msg}{elipsis}";
    }
    
    class MyExtensionsDemo
    {
        static void Main(string[] args)
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요.";
            Console.WriteLine(message.Five());
            Console.WriteLine(message.Ten().Five().AddElipsis());        // 메서드체이닝
            Console.WriteLine(message.Ten().Five().AddElipsis("___"));
        }
    }
}
