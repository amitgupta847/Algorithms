using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataStructureAndAlgorithms.BusinessServices
{
  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  public class Edge<T> : IComparable<Edge<T>>
  {
    private Edge() { }

    public Edge(GraphNode<T> from, GraphNode<T> to, int weight = 0)
    {
      if (from == null)
      {
        throw new ArgumentNullException("from", "from can't be null");
      }

      if (to == null)
      {
        throw new ArgumentNullException("to", "to can't be null");
      }

      From = from;
      To = to;
      Weight = weight;
    }

    public GraphNode<T> From { get; private set; }

    public GraphNode<T> To { get; private set; }

    public int Weight { get; set; }

    public override string ToString()
    {
      return string.Format("From: {0}, To: {1},  Cost: {2}", From.Data.ToString(), To.Data.ToString(), Weight);
    }

    public int CompareTo(Edge<T> other)
    {
      return this.Weight.CompareTo(other.Weight);
    }
  }
}
