using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.DisjointSets
{

  public class SetsUnionByRank<T>
  {
    private Graph<T> _graph;

    public SetsUnionByRank(Graph<T> graph)
    {
      _graph = graph;
      MakeSet();
    }

    private SetNode<T>[] _set;

    private void MakeSet()
    {
      int numberOfVertices = _graph.Vertices.Count;

      _set = new SetNode<T>[numberOfVertices];

      int index = 0;
      foreach (var vertex in _graph.Vertices)
      {
        _set[index] = new SetNode<T>(vertex);
        index++;
      }
    }

    /// <summary>
    /// Return Component owner/Leader.
    /// </summary>
    /// <param name="vertex"></param>
    /// <returns></returns>
    public SetNode<T> Find(GraphNode<T> vertex)
    {
      //we assumed that key is starting from 0 :

      SetNode<T> setNode = _set[vertex.Key];

      while (setNode != setNode.Parent)
      {
        setNode = setNode.Parent;
      }

      return setNode;
    }

    public void Union(GraphNode<T> x, GraphNode<T> y)
    {
      SetNode<T> rootX = Find(x);
      SetNode<T> rootY = Find(y);

      if (rootX == rootY)
        return;

      if (rootX.Rank > rootY.Rank)
        rootY.Parent = rootX;
      else
      {
        rootX.Parent = rootY;

        if (rootX.Rank == rootY.Rank)
          rootY.Rank++;
      }
    }
  }


  public class SetNode<T>
  {
    public SetNode<T> Parent { get; set; }

    public int Rank { get; set; }

    public GraphNode<T> Vertex { get; set; }

    public SetNode(GraphNode<T> vertex)
    {
      Parent = this;
      Rank = 0;
      Vertex = vertex;
    }

    public override string ToString()
    {
      return $"Parent vertex {Parent.Vertex.Name}, Rank is {Rank}";
    }
  }
}
