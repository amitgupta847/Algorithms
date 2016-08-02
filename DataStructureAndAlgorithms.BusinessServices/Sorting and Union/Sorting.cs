using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.Sorting
{
    public class Sorting
    {

        public static Analysis InsertionSort(ObjectToSort[] list)
        {
            return InternalInsertionSort(list);
        }

        public static Analysis SelectionSort(ObjectToSort[] list)
        {
            return InternalSelectionSort(list);
        }

        public static Analysis BubbleSort(ObjectToSort[] list)
        {
            return InternalBubbleSort(list);
        }

        public static Analysis QuickSort(ObjectToSort[] list)
        {
            return InternalQuickSort(list);
        }

        public static Analysis MergeSort(ObjectToSort[] list)
        {
             InternalMergeSort();
             return new Analysis();
        }

        public static Analysis RadixSort(ObjectToSort[] list)
        {
            return InternalRadixSort(list);
        }

        public static Analysis BucketSort(ObjectToSort[] list)
        {
            return InternalSelectionSort(list);
        }

        private static Analysis InternalInsertionSort(ObjectToSort[] list)
        {
            CommonOperations.Validate<ObjectToSort>(list);

            Analysis analysis = new Analysis(true);

            for (int i = 1; i < list.Length; i++)
            {
                int j = i - 1;

                ObjectToSort item = list[i];

                while (j >= 0 && list[j].Key > item.Key)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = item;
            }
            analysis.Stop();

            return analysis;
        }

        private static Analysis InternalSelectionSort(ObjectToSort[] list)
        {
            CommonOperations.Validate<ObjectToSort>(list);

            Analysis analysis = new Analysis(true);

            for (int olpIndex = 0; olpIndex < list.Length - 1; olpIndex++)
            {
                int min = olpIndex;

                for (int inlpIndex = olpIndex + 1; inlpIndex < list.Length; inlpIndex++)
                {
                    if (list[min].Key > list[inlpIndex].Key)
                    {
                        min = inlpIndex;
                    }
                }
                CommonOperations.Swap(list, olpIndex, min);
            }

            analysis.Stop();
            return analysis;
        }

        private static Analysis InternalBubbleSort(ObjectToSort[] list)
        {
            CommonOperations.Validate<ObjectToSort>(list);

            Analysis analysis = new Analysis(true);

            for (int pass = 1; pass < list.Length - 1; pass++)
            {
                int tracker = 0;

                while (tracker < list.Length - pass)
                {
                    if (list[tracker].Key > list[tracker + 1].Key)
                    {
                        CommonOperations.Swap(list, tracker, tracker + 1);
                    }

                    tracker++;
                }
            }

            analysis.Stop();
            return analysis;
        }

        private static Analysis InternalQuickSort(ObjectToSort[] list)
        {
            CommonOperations.Validate<ObjectToSort>(list);

            Analysis analysis = new Analysis(true);

            Quicksort(list, 0, list.Length - 1);

            analysis.Stop();

            return analysis;
        }

        private static void Quicksort(ObjectToSort[] list, int start, int end)
        {
            if (start < end)
            {
                int q = Partition(list, start, end);
                Quicksort(list, start, q - 1);
                Quicksort(list, q + 1, end);
            }
        }

        private static int Partition(ObjectToSort[] list, int p, int r)
        {
            int tracker = 0;

            int pivot = list[r].Key;
            tracker = p - 1;
            for (int i = p; i <= r - 1; i++)
            {
                if (list[i].Key < pivot)
                {
                    tracker++;
                    CommonOperations.Swap(list, i, tracker);
                }
            }

            tracker = tracker + 1;
            CommonOperations.Swap(list, tracker, r);

            return tracker;
        }

        private static Analysis InternalRadixSort(ObjectToSort[] list)
        {
            CommonOperations.Validate<ObjectToSort>(list);

            Analysis analysis = new Analysis(true);

            bool isFinished = false;
            int digitPosition = 0;

            List<Queue<ObjectToSort>> buckets = new List<Queue<ObjectToSort>>();
            InitializeBuckets(buckets);

            while (!isFinished)
            {
                isFinished = true;

                foreach (ObjectToSort obj in list)
                {
                    int bucketNumber = GetBucketNumber(obj.Key, digitPosition);
                    if (bucketNumber > 0)
                    {
                        isFinished = false;
                        //Independent on number of digits to be known before start. therefore:
                        //this implementaion takes digit + 1 outer loops
                        //at last step it moves all the elements to bucket 0 and take from it finally.
                    }

                    buckets[bucketNumber].Enqueue(obj);
                }

                int i = 0;
                foreach (Queue<ObjectToSort> bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        list[i] = bucket.Dequeue();
                        i++;
                    }
                }

                digitPosition++;
            }
            analysis.Stop();

            return analysis;
        }

        private static int GetBucketNumber(int value, int digitPosition)
        {
            int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
            return bucketNumber;
        }

        private static void InitializeBuckets(List<Queue<ObjectToSort>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                Queue<ObjectToSort> q = new Queue<ObjectToSort>();
                buckets.Add(q);
            }
        }

        private static void InternalMergeSort()
        {
            long count = 0;

            int[] arrayofNumbers = CommonOperations.LoadFile(CommonOperations.FileFor.IntegerArray).ToArray();
            count = MergeSort(arrayofNumbers, 0, arrayofNumbers.Length - 1);
        }

        private static long MergeSort(int[] array, int p, int r)
        {
            int q = 0;
            if (p < r)
            {
                q = p + (r - p) / 2;

                long x = MergeSort(array, p, q);
                long y = MergeSort(array, q + 1, r);
                long z = Merge(array, p, q, r);
                return x + y + z;
            }
            return 0;
        }

        private static long Merge(int[] array, int p, int q, int r)
        {
            int index1 = q - p + 1;
            int index2 = r - q;

            int[] arr1 = new int[index1];
            int[] arr2 = new int[index2];

            for (int i = 0; i < index1; i++)
            {
                arr1[i] = array[i + p];
            }

            for (int j = 0; j < index2; j++)
            {
                arr2[j] = array[j + q + 1];
            }

            int l = 0, m = 0;
            long count = 0;
            for (int k = p; k <= r; k++)
            {
                if (l >= arr1.Length)
                {
                    array[k] = arr2[m];
                    m++;
                    continue;
                }

                if (m >= arr2.Length)
                {
                    array[k] = arr1[l];
                    l++;
                    continue;
                }

                if (l < arr1.Length && arr1[l] <= arr2[m])
                {
                    array[k] = arr1[l];
                    l++;
                }
                else if (m < arr2.Length)
                {
                    array[k] = arr2[m];
                    m++;
                    long cnt = arr1.Length - l;//- (k-p);    ///count logic is for counting inversion
                    count = count + cnt;
                }
            }
            return count;
        }

    }
}
