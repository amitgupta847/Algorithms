using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
     [Serializable]
    public class ObjectToSort
    {
        public ObjectToSort() { }

        public ObjectToSort(int key, string name)
        {
            Key = key;
            Name = name;
        }

        public int Key { get; set; }
        public string Name { get; set; }   // To determine the stability

        public string VisibleName
        {
            get { return (Key + " " + Name); }
        }

        public override string ToString()
        {
            return string.Format("Key is {0}, Name is {1}", Key, Name);

        }
    }
}
