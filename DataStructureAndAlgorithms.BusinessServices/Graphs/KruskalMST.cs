using DataStructureAndAlgorithms.BusinessServices.DisjointSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.Graphs
{
  public class KruskalMST<T>
  {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public Graph<T> MST(Graph<T> input)
    {
      Graph<T> finalMst = new Graph<T>(input.Vertices);

      List<Edge<T>> edges = input.SortedEdgesByWeight(); 

      SetsUnionByRank<T> sets = new SetsUnionByRank<T>(input);

      foreach (var edge in edges)
      {
        var rootOfU = sets.Find(edge.From);
        var rootOfV = sets.Find(edge.To);

        if (rootOfU != rootOfV)
        {
          //add edge to set
          finalMst.AddEdge(edge);

          sets.Union(edge.From, edge.To);
        }
      }

      return finalMst;
    }

    public static void TestKruskal()
    {
      Graph<char> graph = DataGenerator.Get5VertexAnd7EdgesUndirectedGraphGraph();
      KruskalMST<char> mst = new KruskalMST<char>();
      var output = mst.MST(graph);

      if (output.Edges.Count == 4)  
      { 
        //and cost total should be 11.
      //passed
      }

    }

   

  }
}
