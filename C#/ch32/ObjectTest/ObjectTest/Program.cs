using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClassCode
{
    static void Main(string[] args)
    {
        // classCode1과 classCode2는 서로 다른 객체이다.
        ClassCode classCode1 = new ClassCode();
        Console.WriteLine(classCode1.GetHashCode());

        ClassCode classCode2 = new ClassCode();
        Console.WriteLine(classCode2.GetHashCode());
    }

}
