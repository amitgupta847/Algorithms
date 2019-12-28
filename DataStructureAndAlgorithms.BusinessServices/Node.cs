using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    [Serializable]
    public class Node<T>
    {
        public int Key { get; set; }

        public T Data { get; set; }

        public Node() { }

        public Node(T data)
        {
            Data = data;
            Key = 0;
        }
        
    }
}
