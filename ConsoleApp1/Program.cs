using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /*ValueTuple<int, int>*/
        (int a, int b) Methoda(int a, int b)
        {
            int c = a + b;
            int bg = a * b;
            return (c, bg);
        }
    }
}
