using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
  [Serializable]
  public class GraphNode<T> : Node<T>
  {
    public GraphNode() { }

    public GraphNode(T data) : base(data)
    {
      Name = data.ToString();
    }

    public string Name { get; private set; }
    public bool IsVisited { get; set; }

    public int PreVisitCount { get; set; }
    public int PostVisitCount { get; set; }
    public int CompCount { get; set; }

    public void Reset()
    {
      IsVisited = false;
      PreVisitCount = 0;
      PostVisitCount = 0;
      CompCount = 0;
    }

    public string Description
    {
      get { return this.ToString(); }
    }

    public override string ToString()
    {
      return string.Format("Node = {0}: {1}, Visited = {2}, PreVisit = {3}, PostVisit = {4}, Component ={5} ",
                           Key,
                           Data.ToString(),
                           IsVisited,
                           PreVisitCount,
                           PostVisitCount,
                           CompCount);
    }
  }
}
