public class Fibonacci
{

    public static int fibbo(int n)
    {
         if (n == 0) return 0;
         else if(n==1) return 1;

         return fibbo(n-1) + fibbo(n-2);
    }

    public static void Run()
    {
        Console.WriteLine("Please enter the value of N");
        int n = int.Parse(Console.ReadLine());

        Console.Write(fibbo(n));
    }
}