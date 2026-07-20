public class Pattern15
{
    public static void Run()
    {
        int n = 5;

        for(int i=n; i>=1; i--)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write((char)(64+j));
            }

            Console.WriteLine();
        }
    }
}