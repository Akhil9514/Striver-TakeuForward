public class Pattern8
{
    public static void Run()
    {
        for (int i=1; i<=5; i++)
        {
            for (int j=1; j<5-i; j++)
            {
                Console.Write(" ");
            }
        }
    }
    
}