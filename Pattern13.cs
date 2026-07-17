public class Pattern13
{
    public static void Run()
    {
        int n=5;
        int count = 1;

        for(int i=1; i<=n; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write(count);
                count++;
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}