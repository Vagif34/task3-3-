using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 23, 6, 5 };
            Array(arr);
            foreach(int item in arr)
            {
              Console.WriteLine(item);
            }
        }
        static  void Array(int[] arr)
        {

            int temp =0;
            int maximum = arr[0];
            int minimum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[minimum] < arr[i])
                    minimum = i;

                if (arr[maximum] > arr[i])
                    maximum = i;

            }
             temp = arr[minimum];
            arr[minimum] = arr[maximum];
             arr[maximum]=temp;

            

        }
        
    }
}
