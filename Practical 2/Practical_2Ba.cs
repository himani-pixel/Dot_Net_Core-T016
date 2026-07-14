using System;

public class A
{
    public void function1()
    {
        Console.WriteLine("This is method of class A.");
    }
}

public class B : A
{
    public void function2()
    {
        Console.WriteLine("This is method of class B.");
    }
}

class SingleInheritance
{
    public static void Main(string[] args)
    {
        B obj = new B();

        Console.WriteLine("=======Single Inheritance=======");
        obj.function1();
        obj.function2();
        Console.WriteLine("Himani T016");
    }
}