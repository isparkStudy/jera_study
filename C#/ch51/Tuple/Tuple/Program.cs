using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플: 괄호 기호의 간단한 구문을 사용하여 하나 이상의 속성을 가지는 개체를 만드는 형식
namespace Tuple
{
    class Program
    {
        static (int, int) Tally1()      // 튜플 리턴 형식: (int, int)
        {
            var r = (12, 3);        // 튜플 리터럴에 2개의 값 담기
            return r;       // 튜플 리터럴 반환
        }

        static (int Sum, int Count) Tally2()        // 튜플 리턴에 이름 값 지정
        {
            var r = (45, 6);
            return r;
        }

        static (int Sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s}, {r.c}");
            return r;
        }

        static void Main()
        {
            var r = (12, 34, 56);       // 3개의 int 형식 데이터가 r 변수에 담김. 기본: Item1, Item2 형태
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);

            Console.WriteLine();

            var uhd = (Width: 3840, Height: 2160);      // 이름 지정
            Console.WriteLine(uhd.Width);
            Console.WriteLine(uhd.Height);
            Console.WriteLine();

            (ushort Width, ushort Height) hd = (1366, 768);     // 이름과 형식 지정
            Console.WriteLine($"{hd.Width}, {hd.Height}, {hd.Width.GetType()}");
            Console.WriteLine();

            var t1 = Tally1();
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine();

            var t2 = Tally2();
            Console.WriteLine(t2.Count);
            Console.WriteLine(t2.Sum);
            Console.WriteLine();

            var boy = (Name: "철수", IsStudent: true, OrderPrice: 1_000);
            Console.WriteLine($"{boy.Name}(초등학생: {boy.IsStudent}) - 주문: {boy.OrderPrice:C0}");
            Console.WriteLine();

            var t = Tally();
            Console.WriteLine(t.Sum);
            Console.WriteLine(t.Count);
            Console.WriteLine();

            // 튜플 분해 또는 튜플 해체 작업
            var (sum, count) = Tally();
            Console.WriteLine(sum);
            Console.WriteLine(count);

        }
    }
}
