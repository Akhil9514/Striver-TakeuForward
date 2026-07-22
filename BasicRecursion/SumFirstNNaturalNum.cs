public class SumFirstNNaturalNum
{
    static int PrintSum(int n, int current = 1, int sum = 0)
    {
        if(current > n)return sum;

        sum = sum+current;

        return PrintSum(n, current + 1, sum);
    }

    public static void Run()
    {
        Console.WriteLine("Please enter the value of N");
        int n = int.Parse(Console.ReadLine());

        Console.Write(PrintSum(n));
        
    }
}