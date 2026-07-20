public class PallindromeChk
{
    public static void Run()
    {
        Console.WriteLine("Please enter a number");
        string num = Console.ReadLine();

        int n=num.Length;

        for(int i=0; i<n/2; i++)
        {
            if(num[i]!=num[n-1-i]){ Console.Write("Not Pallindrome"); return;}
        }

        Console.Write("Pallindrome");


    }
}