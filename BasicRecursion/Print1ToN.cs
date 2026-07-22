public class Print1ToN
{

    public static void Print(int n, int current = 1)
    {
        if(current > n)return;
        
        Console.WriteLine(current);

        Print(n, current+1);
    }

    public static void Run()
    {
        int n=10;
        Print(n);
    }
}