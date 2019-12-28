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
  public class BellManFord<T>
  {
    public static Dictionary<GraphNode<T>, long> BellManFordShortestPath(Graph<T> graph, GraphNode<T> from, GraphNode<T> to = null)
    {
      Dictionary<GraphNode<T>, GraphNode<T>> parent = new Dictionary<GraphNode<T>, GraphNode<T>>();
      Dictionary<GraphNode<T>, long> distanceMap = new Dictionary<GraphNode<T>, long>();

      foreach (GraphNode<T> vertex in graph.Vertices)
      {
        distanceMap[vertex] = int.MaxValue;   //set all to max
      }

      distanceMap[from] = 0;

      for (int i = 1; i <= graph.Vertices.Count - 1; i++)
      {
        foreach (Edge<T> edge in graph.Edges)
        {
          GraphNode<T> u = edge.From;
          GraphNode<T> v = edge.To;
          long distance = distanceMap[u] + edge.Weight;
          if (distanceMap[v] > distance)
          {
            distanceMap[v] = distance;
            parent[v] = u;
          }
        }
      }

      //It detects the -ve cyle (-ve cycle is one whihc have sum of its edges equal to a -ve value)
      foreach (Edge<T> edge in graph.Edges)
      {
        GraphNode<T> u = edge.From;
        GraphNode<T> v = edge.To;
        long distance = distanceMap[u] + edge.Weight;
        if (distanceMap[v] > distance)
        {
          throw new InvalidOperationException("-ve Cycle is there");
        }
      }

      return distanceMap;
    }

  }
}
