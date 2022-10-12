using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace august30_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 42, 4, 13, 58, 14, 70, 25, 80};
            bubbleSort(arr);
            Console.Read();
        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("------------Sorted--------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }
}
        
    

