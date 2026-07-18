public class Pattern21
{

    public static void Run(){

        int n=7; 
        int k=4;

        for(int i=1; i<=n; i++)
        {
            if(i==1 || i == n)
            {
                int j=1;
                while (j <= k)
                {
                    Console.Write("*");
                    j++;
                }

                Console.WriteLine();
            }

            else if(i%2==0)Console.WriteLine();

            else if((i%2==1)&&!(i==1 || i == n))
            {
                Console.Write("*");
                int j=1;
                while (j <= k-2)
                {
                    Console.Write(" ");
                    j++;
                }
                Console.Write("*");
                Console.WriteLine();
                
            }
        }
    }
    
}