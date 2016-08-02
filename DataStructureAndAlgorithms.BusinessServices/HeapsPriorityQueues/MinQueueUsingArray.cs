using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class MinQueueUsingArray<Tkey, Tvalue>
    {
        private List<KeyValuePair<Tkey, Tvalue>> theData;
        private int theQueuelength = 0;

        private IComparer<Tkey> theComparer;
        //Use the map to support the DecreaseKey operation to be performed in O(1) time.
        //else searching of element will take O(n) time.
        private Dictionary<Tvalue, int> theMap;


        public MinQueueUsingArray(IComparer<Tkey> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException("comparer", "comparer can't be null");
            }

            theComparer = comparer;
            theData = new List<KeyValuePair<Tkey, Tvalue>>();
            theMap = new Dictionary<Tvalue, int>();
        }

        public bool IsEmpty
        {
            get { return theQueuelength == 0; }
        }

        //Builder pattern usage
        public static MinQueueUsingArray<Tkey, Tvalue> Build(IEnumerable<KeyValuePair<Tkey, Tvalue>> elements, IComparer<Tkey> comparer)
        {
            MinQueueUsingArray<Tkey, Tvalue> minQueue = new MinQueueUsingArray<Tkey, Tvalue>(comparer);

            foreach (var element in elements)
            {
                minQueue.Insert(element.Key, element.Value);
            }

            return minQueue;
        }

        public void Insert(Tkey key, Tvalue data) // //Complexity O(1) just insert at last or at the current queue lenght position.
        {
            if (theQueuelength == theData.Count)
            {
                theData.Add(new KeyValuePair<Tkey, Tvalue>(key, data));
            }
            else
            {
                theData[theQueuelength] = new KeyValuePair<Tkey, Tvalue>(key, data);
            }

            theMap[data] = theQueuelength;

            theQueuelength = theQueuelength + 1;
        }

        public void DecreaseKey(Tvalue data, Tkey key) //Complexity O(1) if same reference of element is passed. (Not created the new one)
        {
            int dataPos;

            if (theMap.TryGetValue(data, out dataPos))
            {
                theData[dataPos] = new KeyValuePair<Tkey, Tvalue>(key, data);
            }
            else
            {
                throw new ArgumentException("data not found to update the key");
            }
        }

        public Tvalue ExtractMinimum()  //Complexity O(n) to find the minimum element in an array.
        {
            if (theQueuelength == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            KeyValuePair<Tkey, Tvalue> min = new KeyValuePair<Tkey, Tvalue>();

            min = theData[0];
            int minPos = 0;
            for (int i = 1; i < theQueuelength; i++)
            {
                if (theComparer.Compare(min.Key, theData[i].Key) > 0)
                {
                    min = theData[i];
                    minPos = i;
                }
            }

            //Tvalue lastNode=theData[theQueuelength - 1];
            //place last element of the list at the  vacated min position 
            theData[minPos] = theData[theQueuelength - 1];
            theMap[theData[theQueuelength - 1].Value] = minPos;
           
            theMap[min.Value] = -1; //update map

            theQueuelength--;
            return min.Value;
        }
    }
}
