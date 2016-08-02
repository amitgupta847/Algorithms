using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class MinimumFuelRefill
    {
        public List<int> Pumps { get; set; }

        public int Destination { get; set; }

        public int TankSize { get; set; }

        public MinimumFuelRefill()
        {
            Pumps = new List<int> { 200, 375, 550, 751 };
            Destination = 950;
            TankSize = 400;
            Pumps.Add(950);
        }

        public List<int> GetPumps()
        {
            return GetPumps123();
        }

        private List<int> GetPumps123()
        {
            List<int> refills = new List<int>();
            int pumpsCntr = 0;

            int leftOverDistToCover = Destination;


            while (pumpsCntr < Pumps.Count && leftOverDistToCover > 0)
            {
                int tank = TankSize;

                while (tank > 0 && leftOverDistToCover > 0)
                {
                    //current distance covered
                    int distanceCover = (pumpsCntr == 0) ? Pumps[pumpsCntr] : (Pumps[pumpsCntr] - Pumps[pumpsCntr - 1]);

                    leftOverDistToCover = leftOverDistToCover - distanceCover;

                    tank = tank - distanceCover;

                    if (tank < 0)
                    {
                        throw new Exception("Not possible to move next");
                    }

                    //can we go till next pump
                    if (leftOverDistToCover > 0 &&
                        tank >= (Pumps[pumpsCntr + 1] - Pumps[pumpsCntr]))
                    {
                        pumpsCntr = pumpsCntr + 1;
                    }
                    else
                    {   //need reffil
                        break;
                    }
                }

                if (leftOverDistToCover > 0)
                {
                    refills.Add(Pumps[pumpsCntr]);
                }
                pumpsCntr++;
            }

            if (leftOverDistToCover > 0)
            {
                throw new Exception("Not possible to reach");
            }

            return refills;
        }



        public int AnotherWayToGetMinimumRefill()
        {
            //include start and last destination as petrol pumps, so
            int[] pumps = { 0, 200, 375, 550, 750, 950 };

            int numRefills = 0;
            int currentRefill = 0;

            while (currentRefill < pumps.Length - 1)   // destination to exclude
            {
                int lastRefill = currentRefill;

                while (currentRefill < pumps.Length - 1 &&
                       pumps[currentRefill + 1] - pumps[lastRefill] <= TankSize)
                {
                    currentRefill = currentRefill + 1;
                }

                if (currentRefill == lastRefill)
                    return 0;  // not possible

                if (currentRefill < pumps.Length-1)
                {
                    numRefills = numRefills + 1;
                }
            }

            return numRefills;
        }

    }
}
