public class CountAllDigitsOfNumber
{

    public static void Run()
    {
        int n=234554;
        int count=0;


        while (n > 0)
        {
            n=n/10;
            count++;
        }

        Console.WriteLine(count);
    }



}