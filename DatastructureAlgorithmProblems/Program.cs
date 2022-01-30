// See https://aka.ms/new-console-template for more information
using DatastructureAlgorithmProblems;

Console.WriteLine("algorithm problems");
#region binary search for serching string
string textAddress = File.ReadAllText(@"C:\Users\vgj24\source\repos\DatastructureAlgorithmProblems\TextFile1.txt");
List<string> word =new List<string>(textAddress.Split());
word.Sort();
BinarySearchString.BinarySearchword(word);
Console.WriteLine("\n\n");
#endregion
#region insertion sort
int[] arr1 = { 1, 4, 45, 6, 3 };
Console.WriteLine("\n Given array");
InsertionSort.printArray(arr1);
InsertionSort InsSort = new InsertionSort(arr1);
Console.WriteLine("\n array After sorting : insertion sort");
InsertionSort.printArray(arr1);
Console.WriteLine("\n\n");
#endregion
#region merge sort
MergeSort ob = new MergeSort();
int[] arr = { 12, 11, 13, 5, 6, 7 };
Console.WriteLine("\nGiven Array");
MergeSort.printArray(arr);
ob.sort(arr, 0, arr.Length - 1);
Console.WriteLine("\nSorted array using Merge sort");
MergeSort.printArray(arr);
Console.WriteLine("\n\n");
#endregion

#region Bubble Sort
BubbleSort obj = new BubbleSort();
int[] arr2 = { 1, 3, 5, 33, 2, 88, 10 };
Console.WriteLine("\n Given Array ");
obj.PrintArray(arr2);
obj.Bubblesort(arr2);
Console.WriteLine("\n array after usnf bubble sort");
obj.PrintArray(arr2);
Console.WriteLine("\n\n");
#endregion
Console.ReadKey();