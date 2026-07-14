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

public class C : B
{
    public void function3()
    {
        Console.WriteLine("This is method of class C.");
    }
}

class MultilevelInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==== Multilevel Inheritance ====");

        C obj1 = new C();

        obj1.function1();
        obj1.function2();
        obj1.function3();
        Console.WriteLine("Himani T016");
    }
}