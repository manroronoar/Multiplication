using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            Console.Write("Input: N = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();  //อ่านค่าที่รับมา

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + num * i);
            }

        }
    
    }
}
