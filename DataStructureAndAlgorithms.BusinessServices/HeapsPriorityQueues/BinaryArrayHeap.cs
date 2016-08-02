using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{

    public class BinaryArrayHeap<T>
    {
        private int theHeapSize; //number of elements stored on heap

        private List<HeapElement<T>> theObjectsToSort;

        public BinaryArrayHeap()
        {
            theObjectsToSort = new List<HeapElement<T>>();
            theHeapSize = 0;
        }

        public BinaryArrayHeap(List<HeapElement<T>> list)
        {
            CommonOperations.Validate<HeapElement<T>>(list);

            theObjectsToSort = list;
            theHeapSize = theObjectsToSort.Count;

            BuildMaxHeap();
        }

        public List<T> Heap
        {
            get { return theObjectsToSort.ConvertAll(x => (T)x.Data).ToList(); }
        }

        public void Insert(T data, int key)
        {
            if (theHeapSize == theObjectsToSort.Count)
            {
                theObjectsToSort.Add(new HeapElement<T>(int.MinValue, data));
            }
            else
            {
                theObjectsToSort[theHeapSize] = new HeapElement<T>(int.MinValue, data);
            }

            IncreaseKey(theHeapSize, key);

            theHeapSize = theHeapSize + 1;
        }

        public void IncreaseKey(int pos, int key)
        {
            if (pos < 0 || pos >= theObjectsToSort.Count)
            {
                throw new ArgumentException("pos is out of range.", "pos");
            }

            if (key < theObjectsToSort[pos].Key)
            {
                throw new ArgumentException("New key is smaller than current key", "key");
            }

            theObjectsToSort[pos].Key = key;

            while (pos > 0 && theObjectsToSort[Parent(pos)].Key < theObjectsToSort[pos].Key)
            {
                CommonOperations.Swap<HeapElement<T>>(theObjectsToSort, Parent(pos), pos);
                pos = Parent(pos);
            }
        }

        public List<T> HeapSort(out Analysis sorting)
        {
            CommonOperations.Validate<HeapElement<T>>(theObjectsToSort.ToArray());

            sorting = new Analysis(true);

            if (!isHeapBuilted)
            {
                BuildMaxHeap();
                isHeapBuilted = true;
            }

            for (int i = theObjectsToSort.Count - 1; i >= 1; i--)
            {
                CommonOperations.Swap(theObjectsToSort, 0, i);
                theHeapSize--;
                Max_Heapify(0);
            }

            sorting.Stop();

            return theObjectsToSort.ConvertAll(x => (T)x.Data).ToList();
        }

        bool isHeapBuilted = false;

        //Note: Build heap is not required if you call insert/Add for each element.
        public void BuildMaxHeap()
        {
            isHeapBuilted = true;

            for (int i = (theObjectsToSort.Count - 1) / 2; i >= 0; i--)
            {
                Max_Heapify(i);
            }
        }

        private void Max_Heapify(int i)
        {
            int left = Left(i);
            int right = Right(i);
            int largest = 0;

            if (left < theHeapSize && theObjectsToSort[left].Key > theObjectsToSort[i].Key)
            {
                largest = left;
            }
            else
            {
                largest = i;
            }

            if (right < theHeapSize && theObjectsToSort[right].Key > theObjectsToSort[largest].Key)
            {
                largest = right;
            }

            if (largest != i)
            {
                CommonOperations.Swap(theObjectsToSort, largest, i);
                Max_Heapify(largest);
            }
        }

        public T Maximum()
        {
            return theObjectsToSort != null && theObjectsToSort.Count > 0 ? theObjectsToSort[0].Data : default(T);
        }

        public T ExtractMax()
        {
            if (theHeapSize == 0)
                throw new InvalidOperationException("Heap is empty");

            T max = theObjectsToSort[0].Data;

            theObjectsToSort[0] = theObjectsToSort[theHeapSize - 1];
            theHeapSize = theHeapSize - 1;
            Max_Heapify(0);

            return max;

        }

        private int Parent(int i)
        {
            return (i - 1) / 2;
        }

        private int Left(int i)
        {
            return (2 * i) + 1;
        }

        private int Right(int i)
        {
            return (2 * i) + 2;
        }

    }
}
