public class Pattern4
{
    public static void Run()
    {
        for (int i = 1; i<=5; i++)
        {
            for (int j=1; j<=i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}