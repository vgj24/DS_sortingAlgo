using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureAlgorithmProblems
{
    internal class InsertionSort
    {
        public InsertionSort(int[] arr1)
        {
            int size=arr1.Length;
            for (int i=1; i<size; i++)
            {
                int k=arr1[i];
                int j=i-1;
                while(j>=0 && arr1[j]>k)
                {
                    arr1[j+1]=arr1[j];
                    j = j - 1;
                }
                arr1[j+1]=k;
            }
        }
        public static void printArray(int[] arr1)
        {
            //int item=0;
            foreach (int item in arr1)
            {
                Console.Write("   "+item);
            }
        }
    }
}
