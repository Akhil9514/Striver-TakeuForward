
public class ReversalOfArray
{

    public static int[] Reverse(int[] arr, int left, int right )
    {
        if(left>right)return arr;

        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;

        return Reverse(arr, left+1, right-1);
        
    }
    public static void Run()
    {
        int[] arr = {1,2,3,4};
        int[] ans =Reverse(arr, 0, 3);

        for(int i=0; i<ans.Length; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}