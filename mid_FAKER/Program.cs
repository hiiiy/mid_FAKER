using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random r = new Random();

            for(int i=0; i < a.Length; i++) 
                a[i] = r.Next(100);

            Array.Sort(a);

            printIntArray(a);
        }

        private static void printIntArray(int[] a)
        {
            foreach(int i in a)
                Console.WriteLine(i); 
        }
    }
}