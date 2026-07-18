public class Pattern18
{
    public static void Run()
    {
        int n=5;

        for(int i=1; i<=n; i++)
        {
            for(int j=(n-i); j<n; j++)
            {
                Console.Write((char)(65+j));
            }

            Console.WriteLine();
        }
    }
}