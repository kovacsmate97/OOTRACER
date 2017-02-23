using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class D : B
    {
        public void S7()
        {
            Console.WriteLine("D::S7");
            S3();
        }

        public void S8()
        {
            Console.WriteLine("D::S7");
            V2();
        }
    }
}