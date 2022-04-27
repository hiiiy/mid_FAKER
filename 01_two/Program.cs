using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            if(x%2==1)
                Console.WriteLine("홀수입니다");
            else
                Console.WriteLine("짝수입니다");
        }
    }
}