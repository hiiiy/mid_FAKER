using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n! 계산: n을 입력: ");
            int n=int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 0; i <= n; i++)
            {
                fact*= n;
                Console.WriteLine("{0}!={1}\t", n, fact);
            }
        }
    }
}