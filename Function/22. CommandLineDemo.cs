using System;

namespace Function
{
    class CommandLineDemo
    {
        static void Main(string[] args)
        {
            int first = int.Parse(args[0]);
            int second = Convert.ToInt32(args[1]);
            Console.WriteLine(first + second);
        }
    }
}