public class CountFrequencyOfArrayElements
{

    public static void Run()
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        int[] arr = {1,2,3,1,3};
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

        foreach (var item in frequency)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

    }
    
}