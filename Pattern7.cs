public class Pattern7
{
    public static void Run()
    {
        for(int i=1; i<=5; i++)
        {
            // Space
            for(int j=1; j<=5-i; j++)
            {
                Console.Write(" ");
            }

            // Star under the square
            for(int j=1; j<=i; j++)
            {
                Console.Write("*");
            }

            //Star after the square
            for(int j=1; j<=i-1; j++)
            {
                Console.Write("*");
            }

             Console.WriteLine();
        }
       
    }
}