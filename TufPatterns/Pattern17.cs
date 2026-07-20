public class Pattern17
{
    public static void Run()
    {
        int n=4;

        for(int i=1; i<=n; i++)
        {
            for(int j=1; j<=n-i; j++)
            {
                Console.Write(" ");
            }

            for(int j=1; j<=i; j++)
            {
                Console.Write((char)(64+j));
            }

            for(int j=i; j>1; j--)
            {
                Console.Write((char)(64+j));
            }

            Console.WriteLine();
        }
    }
}