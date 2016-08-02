using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.DynamicProgramming
{
    public class Item
    {
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(int wt, int val)
        {
            Weight = wt;
            Value = val;
        }
    }

    public class Knapsack
    {
        public int BagSize { get; set; }

        public List<Item> Items { get; set; }

        public List<Item> FinalSelection { get; private set; }

        public Knapsack()
        {
            Items = new List<Item>();
            Items.Add(new Item(1, 1));
            Items.Add(new Item(3, 4));
            Items.Add(new Item(4, 5));
            Items.Add(new Item(5, 7));

            BagSize = 7;

            FinalSelection = new List<Item>();
        }


        public void SelectItems()
        {

            Start(Items.Count, BagSize);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">Count of items</param>
        /// <param name="sum">Sum</param>
        private void Start(int items, int sum)
        {
            int[,] matrix = new int[items, sum + 1];

            InitilizeMatrix(matrix, items, 0);

            for (int i = 0; i < items; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    Item input = Items[i];

                    int previousRow = (i - 1 < 0) ? 0 : i - 1;

                    if (j < input.Weight)
                    {
                        matrix[i, j] = matrix[previousRow, j];
                    }
                    else
                    {
                        int val1 = input.Value + matrix[previousRow, j - input.Weight];
                        matrix[i, j] = Math.Max(val1, matrix[previousRow, j]);
                    }

                }
            }

            GetSolution(items, sum, matrix);

        }

        private void InitilizeMatrix(int[,] matrix, int rows, int col)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i, col] = 0;
            }
        }

        private void GetSolution(int items, int sum, int[,] matrix)
        {
            int i = items - 1;
            int j = sum;

            FinalSelection.Clear();

            while (j > 0 && i >= 0)
            {
                if (matrix[i, j] == matrix[i - 1, j])
                {
                    i = i - 1;
                }
                else
                {
                    FinalSelection.Add(Items[i]);
                    j = j - Items[i].Weight;
                    i = i - 1;
                }
            }
        }

    }
}
