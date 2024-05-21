namespace Recursion;

public class Basics
{
    public static void Run()
    {
        Func2(5);
    }

    public static void Func(int n)
    {
        if (n == 0) return;
        Func(n - 1);
        System.Console.WriteLine(n);
    }

    public static void Func2(int n)
    {
        if (n == 0) return;
        Func2(n - 1);
        System.Console.WriteLine(n);
    }
}
