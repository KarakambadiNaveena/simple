using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace august30_1
{
    public class program2
    {
        static void Insert(int[] arr)
        {

            int i, j, temp;
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void PrintSortedArray(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 13, 32, 28, 10, 35, 25 };
            Insert(arr);
            PrintSortedArray(arr);
            Console.Read();
        }
    }
}
    

