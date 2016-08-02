using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    [Serializable]
    public class Graph<T>
    {
        public Graph()
        {
            Vertices = new List<GraphNode<T>>();
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

        public void AddVertex(GraphNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node", "node can't be null");
            }

            Vertices.Add(node);
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

        private List<Edge<T>> GetEdges(GraphNode<T> node)
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

        public Dictionary<GraphNode<T>, int> DijkstraShortestPath(GraphNode<T> from, GraphNode<T> to = null)
        {
            Dictionary<GraphNode<T>, GraphNode<T>> parent = new Dictionary<GraphNode<T>, GraphNode<T>>();
            Dictionary<GraphNode<T>, int> distanceMap = new Dictionary<GraphNode<T>, int>();

            foreach (GraphNode<T> vertex in Vertices)
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

                List<Edge<T>> edges = GetEdges(u);
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


        public Dictionary<GraphNode<T>, long> BellManFordShortestPath(GraphNode<T> from, GraphNode<T> to = null)
        {
            Dictionary<GraphNode<T>, GraphNode<T>> parent = new Dictionary<GraphNode<T>, GraphNode<T>>();
            Dictionary<GraphNode<T>, long> distanceMap = new Dictionary<GraphNode<T>, long>();

            foreach (GraphNode<T> vertex in Vertices)
            {
                distanceMap[vertex] = int.MaxValue;   //set all to max
            }

            distanceMap[from] = 0;

            for (int i = 1; i <= Vertices.Count - 1; i++)
            {
                foreach (Edge<T> edge in Edges)
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
            foreach (Edge<T> edge in Edges)
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


    public class ComparerForInt : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}
