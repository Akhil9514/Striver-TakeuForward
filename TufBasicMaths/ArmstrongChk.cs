public class ArmstrongChk
{

    public static void Run()
    {

        Console.WriteLine("Please enter a number");
        string num = Console.ReadLine();

        int len = num.Length;

        int n = int.Parse(num);
        int sum = 0;

        while (n > 0)
        {
            
            int r = n%10;
            sum = (int)Math.Pow(r, len) + sum;
            n=n/10;

        }
        if(sum == int.Parse(num))Console.Write("Armstrong Num");
        else Console.Write("Not an Armstrong Num");
        
        // Console.WriteLine(n / 10);
        // Console.WriteLine(n % 10);
    }
    
}