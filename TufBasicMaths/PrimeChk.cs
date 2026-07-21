public class PrimeChk
{
    public static void Run()
    {
        Console.WriteLine("Please enter a number");
        int n = int.Parse(Console.ReadLine());
        
        for (int i=2; i<=Math.Sqrt(n); i++)
        {
            if (n%i==0){Console.WriteLine("Composite Num");return;};   
        }

        Console.WriteLine("Prime Num");

    }
}