public class HighestOccuringElementInArray
{

    public static void Run()
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        int[] arr = {1,2,3,2,3, 3, 3};
        int n = arr.Length;
        
        for (int i=0; i<n; i++)
        {
            if (frequency.ContainsKey(arr[i]))
            {
                frequency[arr[i]]++;
            }
            else
            {
                frequency[arr[i]] = 1;
            }
        }

        int largest = 0;
        int ans=0;
        foreach (var item in frequency)
        {
            if(item.Value > largest & ans != item.Key)
            {
                largest = item.Value;
                ans = item.Key;
            }
        }

        Console.Write(ans);

    }
    
}