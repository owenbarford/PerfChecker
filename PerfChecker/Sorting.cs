using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace test
{
    public static class sorting
    {
        public delegate void Results(string result);
        public static event Results OnResults;
        
        #region bubble sort
        private static void BubbleSort(int[] listToSort, CancellationToken cancel)
        {
            int i, j;
            int listLength = listToSort.Length;
            for (j = listLength - 1; j > 0; j--)
            {
                //Console.WriteLine($"j = {j}");
                for (i = 0; i < j; i++)
                {
                    if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                    //Console.WriteLine($"{i}: {listToSort[i]} > {i+1}:{listToSort[i + 1]}");
                    if (listToSort[i] > listToSort[i + 1])
                        Exchange(listToSort, i, i + 1, cancel);
                }
            }
        }
        #endregion

        #region selection sort
        private static int IntArrayMin(int[] data, int start, CancellationToken cancel)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
            {
                if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                //Console.WriteLine($"pos{pos} : {data[pos]} < minPos{minPos} : {data[minPos]}");
                if (data[pos] < data[minPos])
                    minPos = pos;
            }
            return minPos;
        }

        private static void IntArraySelectionSort(int[] data, CancellationToken cancel)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                //Console.WriteLine($"i = {i} : N = {N}");
                int k = IntArrayMin(data, i, cancel);
                //Console.WriteLine($"i :{i} != k{k}");
                if (i != k)
                    Exchange(data, i, k, cancel);
            }
        }
        #endregion

        #region insertion sort
        private static void IntArrayInsertionSort(int[] data, CancellationToken cancel)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                //Console.WriteLine($"j = {j} : N = {N}");
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {                    
                    //Console.WriteLine($"i:{i} > 0 & {i}:{data[i]} < {i-1}:{data[i - 1]}");
                    Exchange(data, i, i - 1, cancel);
                }
            }
        }
        #endregion

        #region shell sort
        private static void IntArrayShellSort(int[] data, int[] intervals, CancellationToken cancel)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                //Console.WriteLine($"k = {k}");
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                    //Console.WriteLine($"m = {m} : interval {interval}");
                    for (j = m + interval; j < N; j += interval)
                    {
                        //Console.WriteLine($"j = {j} : {j} < {N} ");
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {                            
                            //Console.WriteLine($"i{i} : j{j} : {i} >= {interval} & {i}:{data[i]} < {i-interval}: {data[i - interval]} ");
                            Exchange(data, i, i - interval, cancel);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="intervals">the size of the array will determine the interval points,
        /// larger the array the more intervals needed</param>
        private static void IntArrayShellSortNaive(int[] data,int[] intervals, CancellationToken cancel)
        {
            // int[] intervals = { 1, 2, 4, 8 };            
            IntArrayShellSort(data, intervals, cancel);
        }
        #endregion

        #region Quick sort
        private static void IntArrayQuickSort(int[] data, int l, int r, CancellationToken cancel)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            //Console.WriteLine($"pivot item x = {x}");
            while (true)
            {
                while (data[i] < x)
                {
                    //Console.WriteLine($"{i} :{data[i]} < {x}");                    
                    i++;
                }
                while (x < data[j])
                {
                    //Console.WriteLine($"{x} < {j}:{data[j]}");                    
                    j--;
                }
                if (i <= j)
                {
                    //Console.WriteLine($"{i} <= j{j}");                    
                    Exchange(data, i, j, cancel);
                    i++;
                    j--;
                    //Console.WriteLine($"{i} : j{j}");
                }
                if (i > j)
                    break;
            }
            if (l < j)
            {
                //Console.WriteLine($"{l} < j{j}");                
                IntArrayQuickSort(data, l, j, cancel);
            }
            if (i < r)
            {
                //Console.WriteLine($"{i} < r{r}");                
                IntArrayQuickSort(data, i, r, cancel);
            }
        }

        private static void IntArrayQuickSort(int[] data, CancellationToken cancel)
        {
            IntArrayQuickSort(data, 0, data.Length - 1, cancel);
        }
        #endregion

        #region general
        private static void Exchange(int[] listToSort, int i, int v, CancellationToken cancel)
        {
            if(cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
            int temporary;
            //Console.WriteLine($" swap = {listToSort[i]} with {listToSort[v]}");
            OnResults($" swap = {listToSort[i]} with {listToSort[v]}" + Environment.NewLine);
            temporary = listToSort[i];
            listToSort[i] = listToSort[v];
            listToSort[v] = temporary;
        }
        public enum SortTypes
        {
            BubbleSort,
            SelectionSort,
            InsertionSort,
            ShellSort,
            QuickSort
        }
        public static string StartSort(SortTypes sortType, int arraySize, CancellationToken cancel)
        {
            string timeTaken = "";
            int Min = 0;
            int Max = 1000;

            // this declares an integer array with 500 elements
            // and initializes all of them to their default value
            // which is zero
            int[] test2 = new int[arraySize];

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }

            // int[] listToSort = { 6, 88, 10, 11, 3, 21, 5 };
            int[] listToSort = test2;
            int[] intervals = { 2, 5 };
            string arrayContent = "";

            for (int i = 0; i < listToSort.Length; i++)
            {
                {
                    //Debug.WriteLine(i);
                    //Thread.Sleep(10);
                    if (cancel.IsCancellationRequested) throw new OperationCanceledException(cancel);
                    arrayContent += $"{i} : {listToSort[i]}" + Environment.NewLine;
                    //if (i < listToSort.Length-1) arrayContent += " , ";
                }                
            }
            OnResults(arrayContent);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            switch (sortType)
            {
                case SortTypes.BubbleSort:
                    BubbleSort(listToSort, cancel);
                    break;
                case SortTypes.SelectionSort:
                    IntArraySelectionSort(listToSort, cancel);
                    break;
                case SortTypes.InsertionSort:
                    IntArrayInsertionSort(listToSort, cancel);
                    break;
                case SortTypes.ShellSort:
                    IntArrayShellSortNaive(listToSort, intervals, cancel);
                    break;
                case SortTypes.QuickSort:
                    IntArrayQuickSort(listToSort, cancel);
                    break;
            }
            watch.Stop();
            timeTaken = watch.Elapsed.ToString();
            arrayContent = "";
            OnResults(Environment.NewLine + $"time elapsed {watch.Elapsed} for sort type " + sortType.ToString() + Environment.NewLine);
            for (int i = 0; i < listToSort.Length; i++)
            {
                {
                    arrayContent += $"{i} : {listToSort[i]}" + Environment.NewLine;
                    //if (i < listToSort.Length - 1) arrayContent+=;
                }
            }
            OnResults(Environment.NewLine + "Result for sort type " + sortType.ToString() + ": " + Environment.NewLine + Environment.NewLine + arrayContent + Environment.NewLine);            

            return timeTaken;
        }
        #endregion
    }
}
