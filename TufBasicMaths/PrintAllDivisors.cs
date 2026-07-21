public class PrintAllDivisors
{
    public static void Run()
    {
        Console.WriteLine("Please enter a number");
        int n = int.Parse(Console.ReadLine());

        List<int> ans = new List<int>();
        for (int i=1; i<=n; i++)
        {
            if (n%i==0){ans.Add(i);};   
        }

        Console.WriteLine("All divisors of " + n + " are: ");
        foreach (int i in ans)
        {
            Console.Write(i + " ");
        }
    }
}