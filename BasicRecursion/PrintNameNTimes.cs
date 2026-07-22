public class PrintNameNTimes
{
    public static void Print(int current, int n)
    {
        if(current > n)return;

        Console.WriteLine("Aarav");

        Print(current+1, n);

    }

    public static void Run()
    {
        int n=5;
        Print(1, n);
    }
}