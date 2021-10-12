using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int ARRAY_SIZE = 100;

            int[] arraySingleThread = new int[ARRAY_SIZE];

            // TODO : Use the "Random" class in a for loop to initialize an array
            Random rnd = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                arraySingleThread[i] = rnd.Next(0, ARRAY_SIZE);
            }

            Console.Write("Unsorted Array\n");
            PrintArray(arraySingleThread);
            sub_divide(arraySingleThread, 10);
            arraySingleThread = MergeSort(arraySingleThread);
            Console.Write("\nSorted Array\n");
            PrintArray(arraySingleThread);

           //  PrintArray(arraySingleThread);

           /*  bool is_it_sorted = IsSorted(arraySingleThread);
             if (is_it_sorted)
                 Console.Write("\nYes, the array is sorted :)\n");
             else
                 Console.Write("\nNo, the array is not sorted :(\n");

             Console.Write("\n");*/



            // copy array by value.. You can also use array.copy()
            //NEED!!!!! int[] arrayMultiThread = arraySingleThread.Slice(0,arraySingleThread.Length);

            /*TODO : Use the  "Stopwatch" class to measure the duration of time that
               it takes to sort an array using one-thread merge sort and
               multi-thead merge sort
            */


            //TODO :start the stopwatch
            //MergeSort(arraySingleThread);
            //TODO :Stop the stopwatch
             Stopwatch stopWatch = new Stopwatch();
             stopWatch.Start();
             arraySingleThread = MergeSort(arraySingleThread);
             stopWatch.Stop();
             // Get the elapsed time as a TimeSpan value.
             TimeSpan ts = stopWatch.Elapsed;
             // Format and display the TimeSpan value.
             string elapsedTime = String.Format("\n{0:00}:{1:00}:{2:00}.{3:00}",
                 ts.Hours, ts.Minutes, ts.Seconds,
                 ts.Milliseconds / 10);
             Console.WriteLine("\nRunTime " + elapsedTime);



            //TODO: Multi Threading Merge Sort







            /*********************** Methods **********************
             *****************************************************/
            /*
            implement Merge method. This method takes two sorted array and
            and constructs a sorted array in the size of combined arrays
            */

            static int[] Merge(int[] LA, int[] RA, int[] A)
            {

                // TODO :implement
                int total_length = RA.Length+LA.Length;
                int[] sorted_array = new int[total_length];
                int left=0;
                int right=0;
                int sorted = 0;

                while(left<LA.Length || right<RA.Length)
                {
                    if(left<LA.Length && right < RA.Length)
                    {
                        if(LA[left]<=RA[right])
                        {
                            sorted_array[sorted] = LA[left];
                            left = left + 1;
                            sorted = sorted + 1;

                        }
                        else
                        {
                            sorted_array[sorted] = RA[right];
                            right = right + 1;
                            sorted = sorted + 1;
                        }
                    }   
                    else if(left<LA.Length)
                    {
                        sorted_array[sorted] = LA[left];
                        left = left + 1;
                        sorted = sorted + 1;

                    }
                    else if(right<RA.Length)
                    {
                        sorted_array[sorted] = RA[right];
                        right = right + 1;
                        sorted = sorted + 1;

                    }
                }
                return sorted_array;
            }


             /*
             implement MergeSort method: takes an integer array by reference
             and makes some recursive calls to intself and then sorts the array
             */
            static int[] MergeSort(int[] A)
            {

                // TODO :implement
                int[] left_side;
                int[] right_side;
                int[] sorted_array = new int[A.Length];

                if (A.Length <= 1)
                    return A;

                int middle = A.Length / 2;

                left_side = new int[middle];

                if (A.Length % 2 == 0)
                    right_side = new int[middle];
                else
                    right_side = new int[middle+1];

                for (int i = 0; i < middle; i++)
                {
                    left_side[i] = A[i];
                }

                int start = 0;


                for (int i = middle; i < A.Length; i++)
                {
                    right_side[start] = A[i];
                    start=start+1;
                }


                left_side = MergeSort(left_side);
                right_side = MergeSort(right_side);

                return sorted_array = Merge(left_side, right_side, A);


            }


            // a helper function to print your array
            static void PrintArray(int[] myArray)
            {
                Console.Write("[");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("{0} ", myArray[i]);

                }
                Console.Write("]");
                Console.WriteLine();

            }

            // a helper function to confirm your array is sorted
            // returns boolean True if the array is sorted
            static bool IsSorted(int[] a)
            {
                int j = a.Length - 1;
                if (j < 1) return true;
                int ai = a[0], i = 1;
                while (i <= j && ai <= (ai = a[i])) i++;
                return i > j;
            }

            static void sub_divide(int[] A, int sub)
            {
                int SUB_ARRAY_SIZE = A.Length / sub;

                int[] array1 = new int[SUB_ARRAY_SIZE];
                int[] array2 = new int[SUB_ARRAY_SIZE];
                int[] array3 = new int[SUB_ARRAY_SIZE];
                int[] array4 = new int[SUB_ARRAY_SIZE];
                int[] array5 = new int[SUB_ARRAY_SIZE];
                int[] array6 = new int[SUB_ARRAY_SIZE];
                int[] array7 = new int[SUB_ARRAY_SIZE];
                int[] array8 = new int[SUB_ARRAY_SIZE];
                int[] array9 = new int[SUB_ARRAY_SIZE];
                int[] array10 = new int[SUB_ARRAY_SIZE];


                for (int i = 0; i < SUB_ARRAY_SIZE; i++)
                {
                    array1[i] = A[i];
                }

                int x = 0;
                for (int i = SUB_ARRAY_SIZE; i < SUB_ARRAY_SIZE * 2; i++)
                {
                    array2[x] = A[i];
                    x++;
                }
                int y = 0;
                for (int i = SUB_ARRAY_SIZE * 2; i < SUB_ARRAY_SIZE * 3; i++)
                {
                    array3[y] = A[i];
                    y++;
                }
                int z = 0;
                for (int i = SUB_ARRAY_SIZE * 3; i < SUB_ARRAY_SIZE * 4; i++)
                {
                    array4[z] = A[i];
                    z++;
                }
                int w = 0;
                for (int i = SUB_ARRAY_SIZE * 4; i < SUB_ARRAY_SIZE * 5; i++)
                {
                    array5[w] = A[i];
                    w++;
                }
                int a = 0;
                for (int i = SUB_ARRAY_SIZE * 5; i < SUB_ARRAY_SIZE * 6; i++)
                {
                    array6[a] = A[i];
                    a++;
                }
                int s = 0;
                for (int i = SUB_ARRAY_SIZE * 6; i < SUB_ARRAY_SIZE * 7; i++)
                {
                    array7[s] = A[i];
                    s++;
                }
                int d = 0;
                for (int i = SUB_ARRAY_SIZE * 7; i < SUB_ARRAY_SIZE * 8; i++)
                {
                    array8[d] = A[i];
                    d++;
                }
                int f = 0;
                for (int i = SUB_ARRAY_SIZE * 8; i < SUB_ARRAY_SIZE * 9; i++)
                {
                    array9[f] = A[i];
                    f++;
                }
                int g = 0;
                for (int i = SUB_ARRAY_SIZE * 9; i < SUB_ARRAY_SIZE * 10; i++)
                {
                    array10[g] = A[i];
                    g++;
                }

                Console.Write("\nUnsorted Array 1\t"); PrintArray(array1); array1 = MergeSort(array1); Console.Write("Sorted Array 1\t\t"); PrintArray(array1);
                Console.Write("\nUnsorted Array 2\t"); PrintArray(array2); array2 = MergeSort(array2); Console.Write("Sorted Array 2\t\t"); PrintArray(array2);
                Console.Write("\nUnsorted Array 3\t"); PrintArray(array3); array3 = MergeSort(array3); Console.Write("Sorted Array 3\t\t"); PrintArray(array3);
                Console.Write("\nUnsorted Array 4\t"); PrintArray(array4); array4 = MergeSort(array4); Console.Write("Sorted Array 4\t\t"); PrintArray(array4);
                Console.Write("\nUnsorted Array 5\t"); PrintArray(array5); array5 = MergeSort(array5); Console.Write("Sorted Array 5\t\t"); PrintArray(array5);
                Console.Write("\nUnsorted Array 6\t"); PrintArray(array6); array6 = MergeSort(array6); Console.Write("Sorted Array 6\t\t"); PrintArray(array6);
                Console.Write("\nUnsorted Array 7\t"); PrintArray(array7); array7 = MergeSort(array7); Console.Write("Sorted Array 7\t\t"); PrintArray(array7);
                Console.Write("\nUnsorted Array 8\t"); PrintArray(array8); array8 = MergeSort(array8); Console.Write("Sorted Array 8\t\t"); PrintArray(array8);
                Console.Write("\nUnsorted Array 9\t"); PrintArray(array9); array9 = MergeSort(array9); Console.Write("Sorted Array 9\t\t"); PrintArray(array9);
                Console.Write("\nUnsorted Array 10\t"); PrintArray(array10); array10 = MergeSort(array10); Console.Write("Sorted Array 10\t\t"); PrintArray(array10);
            }


               
        }


    }
}
