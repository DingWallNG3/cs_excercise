using System;

class As
{
    static void Main(string[] args)
    {
        object x = 1234;
        var s = x as string;
        Console.WriteLine(s == null ? "null" : s);
    }
}