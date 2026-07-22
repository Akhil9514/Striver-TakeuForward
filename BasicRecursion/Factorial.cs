public class Factorial
{
    static int PrintFac(int n, int current = 1, int mul = 1)
    {
        if(current > n)return mul;

        mul = mul*current;

        return PrintFac(n, current +1 , mul);
    }

    public static void Run()
    {
        Console.WriteLine("Please enter the value of N");
        int n = int.Parse(Console.ReadLine());

        Console.Write(PrintFac(n));
        
    }
}