using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class QuickUnion
    {
        public int[] theParents;

        public int[] theWeight;  // number of objects rooted at i;
        //numbers should be from 0 onwards, in a proper serial.
        public QuickUnion(int[] numbers)
        {
            theParents = numbers;

            theWeight = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                theWeight[i] = 1;
            }
        }

        public bool IsConnected(int p, int q)
        {
            if (p >= 0 && p < theParents.Length
                 && q >= 0 && q < theParents.Length)
            {
                return FindRoot(p) == FindRoot(q);
            }
            else
            {
                return false;
            }
        }

        private int FindRoot(int p)
        {
            int psRoot = p;
            while (psRoot != theParents[psRoot])
            {
                psRoot = theParents[psRoot];
            }

            return psRoot;
        }


        public void Union(int p, int q)
        {
            if (p >= 0 && p < theParents.Length
                   && q >= 0 && q < theParents.Length)
            {
                int rootOfP = FindRoot(p);
                int rootOfQ = FindRoot(q);

                if (rootOfP == rootOfQ)
                    return;


                if (theWeight[rootOfP] < theWeight[rootOfQ])
                {
                    theParents[rootOfP] = rootOfQ;
                    theWeight[rootOfQ] = theWeight[rootOfQ] + theWeight[rootOfP];

                }
                else
                {
                    theParents[rootOfQ] = rootOfP;
                    theWeight[rootOfP] = theWeight[rootOfP] + theWeight[rootOfQ];
                }
            }

        }
    }
}
