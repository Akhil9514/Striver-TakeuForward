
public class StringPallindromeChk
{

    public static bool Chk(string s, int left, int right )
    {
        if(left>right)return true;

        if(s[left] != s[right]) return false;

        return Chk(s, left+1, right-1);
        
    }
    public static void Run()
    {
        Console.WriteLine("Please enter your string");
        string s = Console.ReadLine();

        Console.Write(Chk(s, 0, s.Length-1));

    }
}