public class InsertionSort
{
    public static void InsertionSortAlgo(int[] arr)
    {
        int n = arr.Length;
        for (int i=1; i<n ; i++){
            int current = arr[i];
            int j = i-1;

            while(j>=0 && arr[j] > current)
            {
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1] = current;
        }

    }

    public static void Run()
    {
        int[] arr = {5,3,8,4,2};
        InsertionSortAlgo(arr);

        Console.WriteLine("Result");

        foreach(int num in arr)
        {
            Console.WriteLine(num);
        }
        
    }



}