public class Pattern19
{
    public static void Run()
    {
        int n = 5;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            if(i!=1)Console.WriteLine();
            
        }
        
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n-i; j++)
            {
                Console.Write("*");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= n-i; j++)
            {
                Console.Write("*");
            }


            Console.WriteLine();
        }

    }
}