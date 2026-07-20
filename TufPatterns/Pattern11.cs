using System.Globalization;

public class Pattern11
{

    public static void Run()
    {
        int n = 5;
        int start;

        for(int i=1; i<=n; i++)
        {
            if(i%2==0) start = 0;
            else start = 1;

            for(int j=1; j<=i; j++)
            {
                Console.Write(start);
                start = 1-start;   
            }

            Console.WriteLine();
        }
    }

}