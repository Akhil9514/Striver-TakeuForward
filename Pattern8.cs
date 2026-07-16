public class Pattern8
{
    public static void Run()
    {
        for (int i=5; i>=1; i--)
        {
            for (int j=1; j<=5-i; j++)
            {
                Console.Write(" ");
            }

            for (int j=i; j>=1; j--)
            {
                Console.Write("*");
            }

            for (int j=i-1; j>=1; j--)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
    
}