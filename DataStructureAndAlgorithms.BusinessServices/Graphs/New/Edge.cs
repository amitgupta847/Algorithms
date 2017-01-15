using DataStructureAndAlgorithms.BusinessServices.Graphs.New;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.Graphs.New
{
    public class Edge<T> : IComparable<Edge<T>> where T : IComparable<T>
    {
        //public Vertex<T> Source { get; set; }
        public T Source { get; set; }

        //public Vertex<T> Desination { get; set; }
        public T Destination { get; set; }

        public Int64 Weight { get; set; }


        public Edge(T source, T dest, long weight)
        {
            Source = source;
            Destination = dest;
            Weight = weight;
        }

        public int CompareTo(Edge<T> other)
        {
            if (other == null)
                return -1;

            bool isEqual = this.Source.Equals(other.Source) &&
                          this.Destination.Equals(other.Destination);

            if (!isEqual)
                return -1;
            else
                return Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return string.Format("Source: {0}, Destination: {1}, Weight: {2},", Source, Destination, Weight);
        }
    }
}
