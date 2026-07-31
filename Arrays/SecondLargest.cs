public class SecondLargest
{
    public static void Run()
    {
        int[] arr = {5,32,11,53,64};
        int largestNumIndex = 0;
        int largestNum = arr[largestNumIndex];

        for (int i=1; i<arr.Length; i++)
        {
            if (arr[i] > largestNum)
            {
                largestNum = arr[i];
                largestNumIndex = i;
            }
        }

        int secondLargest = arr[0];
        for (int i=0; i<arr.Length; i++)
        {

            if(i == largestNumIndex)
            {
                continue;
            }

            if(secondLargest < arr[i])
            {
                secondLargest = arr[i];
            }

        }

        Console.WriteLine($"Second Largest Element is {secondLargest}");
        
    }
}