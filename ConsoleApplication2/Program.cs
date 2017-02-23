using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            //S1,S2,S5,V2,S6,S7
            // c.S1(); //A::S1 A::V1 A::S3
            // c.S2(); //A::S2 A::S1 A::V1 A::S3
            // c.S5(); //B::S5 B::S3
            // 
            c.S5();
            Console.ReadKey();
        }
    }
}
