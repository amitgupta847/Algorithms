using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class SumOfSubSet
    {
        public int M = 6;
        //public int[] W = new int[] { 7,11,13,24};
        //public int[] W = new int[] { 2, 5, 7, 9, 10 };


        public int[] W = new int[] { 1, 2, 2, 2, 4, 5, 6 };


        public SumOfSubSet()
        {
            back = new int[W.Length];
        }

        int[] back;

        //if W is not sorted then multiple solutions will not appear.
        public void DoSumOfSubSet(int s, int k, int r)
        {
            back[k] = 1;

            if (s + W[k] == M)
            {
                PrintPossibleSoultion(back, k);
            }
            else if ((s + W[k] + W[k + 1]) <= M)
            {
                DoSumOfSubSet(s + W[k], k + 1, r - W[k]);
            }

            if ((s + r - W[k] >= M) && (s + W[k + 1]) <= M)
            {
                back[k] = 0;
                DoSumOfSubSet(s, k + 1, r - W[k]);
            }
        }


        private void PrintPossibleSoultion(int[] backa, int m)
        {
            string data = string.Empty;
            string exactNumber = string.Empty;
            for (int k = 0; k <= m; k++)
            {
                data = data + "," + backa[k];

                if (backa[k] == 1)
                {
                    exactNumber = exactNumber + "," + W[k];
                }
            }
            //Console.WriteLine(data);
            //Console.WriteLine(exactNumber);
            //Debug.WriteLine(data);
            //Debug.WriteLine(exactNumber);
        }
    }
}
