using System;

namespace fizzbuzzapril2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row=0; row<10; row++)
            {
                for(int column=0; column<row+1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
