public class GCDofTwoNumbers()
{
    public static void Run()
    {
        
        Console.WriteLine("Please enter the numbers");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        while (n1 > 1)
        {
            int r = n2%n1;
            if(r == 1)
            {
                Console.Write(r);
                return;
            }else if(r == 0)
            {
                Console.Write(n1);
                return;
            }
            n1=r;
        }
    }
}