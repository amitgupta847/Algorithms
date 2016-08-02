using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class NQueens
    {
        public int Nnumber { get; set; }

        public NQueens()
        {
            Nnumber = 8;
            queensPosition = new int[Nnumber];
            thePossibleSoultions = new List<int[]>();
        }

        private int[] queensPosition;

        private List<int[]> thePossibleSoultions;

        public List<int[]> GetQueensPostions()
        {
            thePossibleSoultions.Clear();
            
            PrintQueens(0, Nnumber);
            
            return thePossibleSoultions;
        }

        private void PrintQueens(int queenToPlace, int numOfQ)
        {
            for (int col = 0; col < numOfQ; col++)
            {
                if (Place(queenToPlace, col))
                {
                    queensPosition[queenToPlace] = col;

                    if (queenToPlace == numOfQ - 1)
                    {
                        PrintPossibleSoultion();
                    }
                    else
                    {
                        PrintQueens(queenToPlace + 1, numOfQ);
                    }
                }
            }

        }

        private bool Place(int queenToPlace, int column)
        {
            bool result = true;
            for (int i = 0; i < queenToPlace; i++)
            {
                if (queensPosition[i] == column ||
                    (Math.Abs(i - queenToPlace) == Math.Abs(queensPosition[i] - column)))
                {
                    result = false;
                }
            }

            return result;
        }

        private void PrintPossibleSoultion()
        {
            string data = string.Empty;

            for (int k = 0; k < queensPosition.Length; k++)
            {
                data = data + "," + queensPosition[k];
            }

            thePossibleSoultions.Add(queensPosition);
            //Console.WriteLine(data);
            // Debug.WriteLine(data);
        }

    }
}
