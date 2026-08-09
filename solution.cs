using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int razao = (B != 0) ? (A/B) : 0;

        Console.WriteLine(razao);
    }
}