public class PrintNTo1
{

    public static void Print(int n, int current = 1)
    {
        if(current > n)return;
        
        Console.WriteLine(n);

        Print(n-1, current);
    }

    public static void Run()
    {
        int n=20;
        Print(n);
    }
}