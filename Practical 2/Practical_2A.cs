using System;

public class MethodOverloading
{
    void Function(int n1, int n2)
    {
        Console.WriteLine("Addition of 2 nos: " + (n1 + n2));
    }

    void Function(int n1, int n2, int n3)
    {
        Console.WriteLine("Addition of 3 nos: " + (n1 + n2 + n3));
    }

    public static void Main(string[] args)
    {
        MethodOverloading obj = new MethodOverloading();

        obj.Function(43, 28);
        obj.Function(21, 82, 83);
    }
}