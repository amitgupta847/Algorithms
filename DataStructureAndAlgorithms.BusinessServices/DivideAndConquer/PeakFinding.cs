using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.DivideAndConquer
{
    public class PeakFinding
    {

        public static int FindPeak(int[] arrya)
        {
            int number = OneDimPeakFind(arrya, 0, arrya.Length - 1);
            return number;
        }

        private static int OneDimPeakFind(int[] array, int start, int end)
        {
            int mid = start + (end - start) / 2;

            if (mid <= 0 || (array[mid] >= array[mid - 1]
                && array[mid] >= array[mid + 1]))
            {
                return array[mid];
            }
            else if (array[mid] < array[mid - 1])
            {
                end = mid - 1;
                return OneDimPeakFind(array, start, end);
            }
            else
            {
                start = mid + 1;
                return OneDimPeakFind(array, start, end);
            }
        }

    }
}
