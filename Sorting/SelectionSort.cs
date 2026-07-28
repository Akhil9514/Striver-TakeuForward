public class SelectionSort
{
    public static void Run()
    {
        int[] arr = {7,4,1,5,3};
        int largestIndex;

        for (int i=0; i<arr.Length-1; i++)
        {
            largestIndex = i;

            for (int j=i+1; j<arr.Length; j++)
            {

                if (arr[j] >= arr[largestIndex])
                {
                    largestIndex = j;
                }

            }

            int temp = arr[i];
            arr[i] = arr[largestIndex];
            arr[largestIndex] = temp;


        }

        foreach(var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}