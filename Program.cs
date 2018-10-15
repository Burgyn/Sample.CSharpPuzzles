using System;

namespace Sample.CSharpRiddles
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null, y = 0;

            Console.WriteLine($"x > y is {x > y}");
            Console.WriteLine($"!(x <= y) is {!(x <= y)}");
        }

        public static bool Something(out int a, out int b)
        {
            a = 45;
            b = 90;

            return a == b;
        }
    }
}