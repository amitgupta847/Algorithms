using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    [Serializable]
    public class City:IComparable<City>
    {
        public City() { }

        public City(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(City other)
        {
            if (other == null)
                return -1;

            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
