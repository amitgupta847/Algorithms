using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.Graphs
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class Dijkstra<T>
  {
    public static Dictionary<GraphNode<T>, int> DijkstraShortestPath(Graph<T> graph, GraphNode<T> from, GraphNode<T> to = null)
    {
      Dictionary<GraphNode<T>, GraphNode<T>> parent = new Dictionary<GraphNode<T>, GraphNode<T>>();
      Dictionary<GraphNode<T>, int> distanceMap = new Dictionary<GraphNode<T>, int>();

      foreach (GraphNode<T> vertex in graph.Vertices)
      {
        distanceMap[vertex] = int.MaxValue;   //set all to max
      }

      distanceMap[from] = 0;

      List<KeyValuePair<int, GraphNode<T>>> elements = distanceMap.Select(ele => new KeyValuePair<int, GraphNode<T>>(ele.Value, ele.Key)).ToList();

      //Initial distance as key
      MinQueueUsingArray<int, GraphNode<T>> queue = MinQueueUsingArray<int, GraphNode<T>>.Build(elements, new ComparerForInt());

      while (queue.IsEmpty == false)
      {
        GraphNode<T> u = queue.ExtractMinimum();

        if (u.Equals(to))   // to final destination..
        {
          break;
        }

        List<Edge<T>> edges = graph.GetEdges(u);
        foreach (Edge<T> edge in edges)
        {
          GraphNode<T> v = edge.To;
          int distance = distanceMap[u] + edge.Weight;
          if (distanceMap[v] > distance)
          {
            distanceMap[v] = distance;

            parent[v] = u;

            queue.DecreaseKey(v, distance);
          }
        }
      }

      return distanceMap;
    }
  }
}
