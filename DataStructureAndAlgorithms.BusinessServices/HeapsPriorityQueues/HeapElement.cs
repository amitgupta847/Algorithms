using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public class HeapElement<T>
    {
        public HeapElement() { }

        public HeapElement(int key, T data)
        {
            Key = key;
            Data = data;
        }

        public int Key { get; set; }

        public T Data { get; set; }
    }
}
