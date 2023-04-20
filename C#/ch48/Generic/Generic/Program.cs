using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    // 제네릭 클래스: T에 지정한 형식으로 클래스와 멤버의 성질이 결정
    // 클래스 형대로 제네릭 클래스 만들기
    public class Cup<T>
    {
        public T Content { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
    }

    // 모델 클래스: Category, CategoryModel, CategoryDto, ...
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // 형식 매개 변수 2개 사용
    public class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }
        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동" },
                new Person { Name = "백두산" },
                new Person { Name = "임꺽정"}
            };
            
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
            
            Console.WriteLine();

            // 컬렉션 이니셜라이저를 사용하여 카테고리 리스트 만들기
            var categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = "좋은 책" },
                new Category() {CategoryId = 2, CategoryName = "좋은 강의"},
                new Category() {CategoryId = 3, CategoryName = "좋은 컴퓨터"}
            };

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }

            Console.WriteLine();

            var text = new Cup<string>();
            text.Content = "String";
            Console.WriteLine(text.Content);

            Console.WriteLine();

            var number = new Cup<int>();
            number.Content = 1_234;
            Console.WriteLine(number.Content);

            Console.WriteLine();

            var people2 = new Cup<Person2>();
            people2.Content = new Person2 { Name = "Park", Age = 31 };
            Console.WriteLine($"{people2.Content.Name} - {people2.Content.Age}");

            Console.WriteLine();

            // string, bool 2개 형식 받기
            var my = new Pair<string, bool>("나는 멋져!", true);
            Console.WriteLine($"{my.First}: {my.Second}");

            // int, doubble 2개 형식 받기
            var num = new Pair<int, double>(31, 179.8);
            Console.WriteLine($"나이: {num.First}, 키: {num.Second}");
        }
    }
}
