public class Largest
{
    public static void Run()
    {
        int[] arr = {7,3,5,20,20,0};
        int largest = arr[0];

        for (int i=1; i<arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }

        Console.WriteLine($"The largest element is {largest}");
    }
}