using System;

interface IA
{
    public void functionA();
}

interface IB
{
    public void functionB();
}
class C : IA, IB
{
    public void functionA()
    {
        Console.WriteLine("This is method of Interface A.");
    }

    public void functionB()
    {
        Console.WriteLine("This is method of Interface B.");
    }
}

class MultipleInheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Multiple Inheritance Using Interface =====");

        C obj = new C();
        obj.functionA();
        obj.functionB();
        Console.WriteLine("Himani T016");
    }
}