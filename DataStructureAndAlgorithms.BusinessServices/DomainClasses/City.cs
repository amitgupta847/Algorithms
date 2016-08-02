using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    [Serializable]
    public class City
    {
        public City() { }

        public City(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
