using System;
class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            Console.WriteLine(c);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
            Console.WriteLine("Himani T016");
        }
    }
}