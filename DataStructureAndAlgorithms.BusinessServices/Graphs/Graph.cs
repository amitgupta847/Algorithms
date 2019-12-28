using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{

  // This can represent both directed and undirected graph.
  // For directed graph - add only one edge between U & V.
  // For un-directed graph - add two edges, one for u and v and another one for v and u.
  [Serializable]
  public class Graph<T>
  {
    bool _isDirected = true;
    public Graph(bool isDirected = true)
    {
      _isDirected = isDirected;
      Vertices = new List<GraphNode<T>>();
      theEdgesMap = new Dictionary<GraphNode<T>, List<Edge<T>>>();
    }

    public Graph(List<GraphNode<T>> vertices)
    {
      Vertices = vertices;
      theEdgesMap = new Dictionary<GraphNode<T>, List<Edge<T>>>();
    }

    //All vertices
    public List<GraphNode<T>> Vertices { get; private set; }

    //Edges for each vertex.
    private Dictionary<GraphNode<T>, List<Edge<T>>> theEdgesMap;

    public List<Edge<T>> Edges
    {
      get
      {
        List<Edge<T>> edges = new List<Edge<T>>();

        foreach (var keyValue in theEdgesMap)
        {
          edges.AddRange(keyValue.Value);
        }

        return edges;
      }
    }

    public List<Edge<T>> SortedEdgesByWeight()
    {
      List<Edge<T>> edges = new List<Edge<T>>(Edges);

      edges.Sort();

      return edges;
    }

    private int _keyIndex = 0;

    public void AddVertex(GraphNode<T> node)
    {
      if (node == null)
      {
        throw new ArgumentNullException("node", "node can't be null");
      }

      node.Key = _keyIndex;

      Vertices.Add(node);

      _keyIndex++;
    }

    public void AddEdge(Edge<T> edge)
    {
      if (edge == null)
      {
        throw new ArgumentNullException("edge", "edge can't be null");
      }

      List<Edge<T>> edges = GetEdges(edge.From);

      //TODO: validate if same edge is already added
      edges.Add(edge);
    }

    public List<Edge<T>> GetEdges(GraphNode<T> node)
    {
      List<Edge<T>> edges;
      if (theEdgesMap.TryGetValue(node, out edges) == false)
      {
        edges = new List<Edge<T>>();
        theEdgesMap[node] = edges;
      }
      return edges;
    }

    public void DeleteEdge(Edge<T> edge)
    {
      List<Edge<T>> edges;

      if (theEdgesMap.TryGetValue(edge.From, out edges))
      {
        edges.Remove(edge);
      }
    }

    public void DFS(Action<GraphNode<T>> callback)
    {
      theCompCounter = theVisitCounter = 1;

      foreach (GraphNode<T> node in Vertices)
      {
        node.Reset();
      }

      foreach (GraphNode<T> node in Vertices)
      {
        if (node.IsVisited == false)
        {
          Explore(node, callback);
          theCompCounter++;
        }
      }
    }

    public void Explore(GraphNode<T> node, Action<GraphNode<T>> callback)
    {
      node.IsVisited = true;

      //Process or visit
      if (callback != null)
      {
        callback(node);
      }

      PreVisit(node);

      List<Edge<T>> edges = GetEdges(node);

      foreach (Edge<T> edge in edges)
      {
        if (edge.To.IsVisited == false)
        {
          Explore(edge.To, callback);
        }
      }

      PostVisit(node);
    }

    private int theVisitCounter = 1;
    private int theCompCounter = 1;

    private void PreVisit(GraphNode<T> node)
    {
      node.PreVisitCount = theVisitCounter++;
      node.CompCount = theCompCounter;
    }

    private void PostVisit(GraphNode<T> node)
    {
      node.PostVisitCount = theVisitCounter++;
    }

    

  }


  public class ComparerForInt : IComparer<int>
  {
    public int Compare(int x, int y)
    {
      return x - y;
    }
  }
}
