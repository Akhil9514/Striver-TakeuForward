using System.Globalization;

public class ReverseOfNum
{
    public static void Run()
    {
        Console.WriteLine("Please input a number to reverse the digits");
        int n = int.Parse(Console.ReadLine());
        int ans = 0;

        while (n > 0)
        {
            int r = n%10;
            ans = r + (ans*10);
            n = n/10;
        }

        Console.WriteLine(ans);
    }
}