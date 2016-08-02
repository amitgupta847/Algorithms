using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class QuickFind
    {
        public int[] theIDs;

        public QuickFind(int[] numbers)
        {
            theIDs = numbers;
        }


        //Quick find = O(1)
        public bool IsConnected(int p, int q)
        {
            if (p >= 0 && p < theIDs.Length
                 && q >= 0 && q < theIDs.Length)
            {
                return theIDs[p] == theIDs[q];
            }
            else
            {
                return false;
            }
        }


        //for n commands to do union of n objects, it will take O(n2), 
        //as it need to replace id for all objects belonging to the p's connected component.
        public void Union(int p, int q)
        {
            if (p >= 0 && p < theIDs.Length
                   && q >= 0 && q < theIDs.Length)
            {
                int pId = theIDs[p];
                int qiD = theIDs[q];

                for (int i = 0; i < theIDs.Length; i++)
                {
                    if (theIDs[i] == pId)
                    {
                        theIDs[i] = qiD;
                    }
                }
            }
            else
            {
              //  return false;
            }

        }
    }
}
