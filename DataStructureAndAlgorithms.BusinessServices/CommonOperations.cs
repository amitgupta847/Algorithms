using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class CommonOperations
    {
        public static void Swap<T>(T[] array, int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void Swap<T>(List<T> array, int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void Validate<T>(T[] list)
        {
            if (list == null || list.Length == 0)
            {
                throw new ArgumentException("list to sort, can't be null or empty", "list");
            }
        }

        public static void Validate<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("list to sort, can't be null or empty", "list");
            }
        }

        public static List<int> LoadFile(FileFor purpose)
        {
            List<int> numbers = new List<int>();
            string line;

            string fileName = string.Empty;

            switch (purpose)
            {
                case FileFor.IntegerArray:
                    fileName = "IntegerArray.txt";
                    break;

                default:
                    fileName = "IntegerArray.txt";
                    break;

            }

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("D:\\Amit\\FilesForAlgoImplementation\\" + fileName);
            while ((line = file.ReadLine()) != null)
            {
                int number;

                int.TryParse(line, out number);
                numbers.Add(number);
            }

            file.Close();


            return numbers;
        }

        public enum FileFor
        {
            IntegerArray,
        }
    }
}
