using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.DivideAndConquer
{
    public class CountingInversion
    {
        public static long CoutingInverstionCount(int[] arrayofNumbers)
        {
            long count = 0;

            arrayofNumbers = CommonOperations.LoadFile(CommonOperations.FileFor.IntegerArray).ToArray();
            count = MergeSort(arrayofNumbers, 0, arrayofNumbers.Length - 1);

            return count;
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
                    long cnt = arr1.Length - l;//- (k-p);
                    count = count + cnt;

                }
            }
            return count;

        }

    }
}
