using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class SumOfSubsetLikeQueens
    {

        public int M { get; private set; }

        public int[] Input { get; private set; }

        public List<int[]> PossibleSolutions = new List<int[]>();

        public SumOfSubsetLikeQueens(int m, int[] input)
        {
            M = m;
            Input = input;
        }

        public void SumOfSubset()
        {

            var r = Input.Sum();
            SumOfSubSetP(0, r, 0, Input.Length);
            PrintSolutions();
        }

        private void PrintSolutions()
        {
           // Console.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolutions.Count));
            Debug.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolutions.Count));

            foreach (int[] arr in PossibleSolutions)
            {
                string solution = string.Empty;
                foreach (int item in arr)
                {
                    solution = solution + "," + item;
                }
                Console.WriteLine(solution);
                Debug.WriteLine(solution);
            }
        }

        private int[] theVector;

        //s is so far done sum, Initially its 0
        //r is remainder, Initially it is sum of full array
        //k is current number, we are dealing with
        //n is total given number
        private void SumOfSubSetP(int s, int r, int k, int n)
        {
            if (theVector == null)
            {
                theVector = new int[n];
                for (int i = 0; i < n; i++)
                {
                    theVector[i] = -1;
                }
            }

            for (int i = k; i < n; i++)
            {
                if (Proceed(s, r, k, i, n))
                {
                    theVector[k] = i;
                    if (s + Input[i] == M)
                    {
                        int[] sol = new int[k + 1];
                        for (int l = 0; l <= k; l++)
                        {
                            if (theVector[l] != -1)
                            {
                                sol[l] = Input[theVector[l]];
                            }
                        }
                        PossibleSolutions.Add(sol);
                    }
                    else
                    {
                        if (s + (r - Input[i]) >= M)
                        {
                            SumOfSubSetP(s + Input[i], r - Input[i], k + 1, n);
                        }
                    }
                }
            }

        }

        private bool Proceed(int s, int r, int k, int numberToAssign, int n)
        {
            for (int st = 0; st < k; st++)
            {
                if (numberToAssign <= theVector[st])
                {
                    return false;
                }
            }

            if (s + Input[numberToAssign] > M)
            {
                return false;
            }

            return true;
        }
    }
}
