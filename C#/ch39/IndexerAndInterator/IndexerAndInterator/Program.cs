using System;
using System.Collections;

namespace IndexerAndInteratorDemo
{
    class Car
    {
        // 필드
        private string[] names;

        // 생성자
        public Car(int length)
        {
            names = new string[length];
        }

        // 인덱서
        public string  this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        // 반복기(이터레이터)
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
    class IndexerAndInterator
    {
        static void Main(string[] args)
        {
            // 클래스의 인스턴스 생성
            Car cars = new Car(3);
            
            // 정수형식의 인덱서로 문자열 값 저장
            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";
            
            // foreach 문을 사용하여 배열의 값을 출력
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            
        }
    } 
}