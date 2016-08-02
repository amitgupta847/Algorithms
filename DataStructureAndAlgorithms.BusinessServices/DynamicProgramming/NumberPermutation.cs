using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class NumberPerm
    {
        public int[] theVectorToCreate;

        public List<int[]> PossibleSolution = new List<int[]>();

        public void PermNumber(int[] array)
        {
            theVectorToCreate = new int[array.Length];

            PermuateNumber(0, array.Length);

            PrintSolutions();
        }

        private void PrintSolutions()
        {
            //Console.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolution.Count));
            //Debug.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolution.Count));

            foreach (int[] arr in PossibleSolution)
            {
                string solution = string.Empty;
                foreach (int item in arr)
                {
                    solution = solution + "," + item;
                }
                Console.WriteLine(solution);
                //Debug.WriteLine(solution);
            }
        }

        private void PermuateNumber(int start, int total)
        {
            if (theVectorToCreate == null)
            {
                theVectorToCreate = new int[total];
            }

            for (int numberToAssign = 0; numberToAssign < total; numberToAssign++)
            {
                if (CanAssign(start, numberToAssign))
                {
                    theVectorToCreate[start] = numberToAssign;

                    if (start == total - 1)
                    {
                        int[] solution = new int[theVectorToCreate.Length];
                        theVectorToCreate.CopyTo(solution, 0);
                        PossibleSolution.Add(solution);
                    }
                    else
                    {
                        PermuateNumber(start + 1, total);
                    }
                }
            }
        }

        private bool CanAssign(int current, int numberToAssign)
        {
            for (int i = 0; i < current; i++)
            {
                if (theVectorToCreate[i] == numberToAssign)
                {
                    return false;
                }
            }

            return true;
        }

        public void PermuateString(string s)
        {
            char[] arr = s.ToArray<char>();

            PermuateNumber(0, arr.Length);

            PrintStringSolutions(arr);
        }

        private void PrintStringSolutions(char[] arr)
        {
            //Console.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolution.Count));
            //Debug.WriteLine(string.Format("Total possible solutions are {0}", PossibleSolution.Count));

            foreach (int[] solArray in PossibleSolution)
            {
                string solution = string.Empty;
                foreach (int item in solArray)
                {
                    solution = solution + "," + arr[item];
                }

                Console.WriteLine(solution);
                // Debug.WriteLine(solution);
            }
        }
    }

}
