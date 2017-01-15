using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.Graphs.New
{
    public class DirectedGraph<T> where T : IComparable<T>
    {
        //Amit: the reason i choosen SortedList instead of Dictionary, bec i wanted to 
        //access vertex with index. and dictionary does not support that.
        //no doubt there is cost to use sorted list over dictionary list

        //private SortedList<Vertex<T>, LinkedList<Edge<T>>> theAdjacencyList;
        private List<T> theVertices;
        private Dictionary<T, LinkedList<Edge<T>>> theAdjacencyList;
        //private SortedList<T, LinkedList<Edge<T>>> theAdjacencyList;

        public DirectedGraph()
        {
            theVertices = new List<T>();
            theAdjacencyList = new Dictionary<T, LinkedList<Edge<T>>>();
        }

        public DirectedGraph(IList<T> collection) : this()
        {
            AddVertices(collection);
        }

        public LinkedList<Edge<T>> this[int vertexIndex]
        {
            get
            {
                if (vertexIndex >= theVertices.Count)
                {
                    return null;
                }
                else
                {
                    LinkedList<Edge<T>> edges = theAdjacencyList[theVertices[vertexIndex]];
                    return edges;
                }
            }
        }


        public IList<T> Vertices
        {
            get
            {
                return theVertices;
            }
        }

        public IEnumerable<Edge<T>> Edges
        {
            get
            {
                foreach (var vertex in theAdjacencyList)
                    foreach (var edge in vertex.Value)
                        yield return edge;
            }
        }

        public IEnumerable<Edge<T>> OutGoingEdges(T source)
        {
            foreach (var edge in theAdjacencyList[source])
                yield return edge;
        }

        public void AddVertices(IList<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection", "collection can't be null");

            foreach (var data in collection)
            {
                AddVertex(data);
            }
        }

        public bool AddVertex(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException("vertex", "vertex can't be null");

            if (HasVertex(vertex) == false)
            {
                theVertices.Add(vertex);
                theAdjacencyList[vertex] = new LinkedList<New.Edge<T>>();
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool HasVertex(T vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException("vertex", "vertex can't be null");

            return theAdjacencyList.ContainsKey(vertex);
        }

        //private Edge<T> TryGetEdge(Vertex<T> source, Vertex<T> destination)
        //{
        //    Edge<T> edge = null;

        //    if (theAdjacencyList.ContainsKey(source) &&
        //             theAdjacencyList.ContainsKey(destination))
        //    {
        //        LinkedList<Edge<T>> edges = theAdjacencyList[source];
        //        edge = edges.FirstOrDefault(ed => ed.Desination.Equals(destination));
        //    }

        //    return edge;
        //}

        public void AddEdge(T source, T destination, long weight = 1)
        {
            //Edge<T> existingEdge = TryGetEdge(source, destination);
            // if (existingEdge == null || existingEdge.Weight != weight)
            //{
            Edge<T> edge = new New.Edge<T>(source, destination, weight);
            if (theAdjacencyList[source].Contains(edge) == false)
                theAdjacencyList[source].AddLast(edge);
            // }
        }

        public bool HasEdge(T source, T dest)
        {
            return theAdjacencyList.ContainsKey(source) &&
                   theAdjacencyList.ContainsKey(dest) &&
                   DoesEdgeExist(source, dest);
        }

        private bool DoesEdgeExist(T source, T dest)
        {
            LinkedList<Edge<T>> edges = theAdjacencyList[source];
            Edge<T> edge = edges.FirstOrDefault(ed => ed.Destination.Equals(dest));

            return edge != null;
        }

        private Dictionary<T, bool> theVisitedMap = new Dictionary<T, bool>();

        public void DFS_Traversing(Action<T> callback)
        {
            theVisitedMap.Clear();

            foreach (var v in Vertices)
            {
                theVisitedMap.Add(v, false);
            }

            foreach (var v in Vertices)
            {
                if (theVisitedMap[v] == false)
                {
                    Explore(v, callback);
                }
            }
        }

        public bool DFS_IsPath(T source, T destination)
        {
            theVisitedMap.Clear();

            foreach (var v in Vertices)
            {
                theVisitedMap.Add(v, false);
            }

            bool result = ExploreForPathCheck(source, destination, false);
            return result;
        }

        private void Explore(T vertex, Action<T> callBack)
        {
            //PreProcess
            theVisitedMap[vertex] = true;

            callBack(vertex);

            foreach (var edge in theAdjacencyList[vertex])
            {
                if (theVisitedMap[edge.Destination] == false)
                {
                    Explore(edge.Destination, callBack);
                }
            }
            //PostProcess
        }

        private bool ExploreForPathCheck(T vertex, T destination, bool isPathFound)
        {
            //PreProcess
            theVisitedMap[vertex] = true;

            foreach (var edge in theAdjacencyList[vertex])
            {
                if (theVisitedMap[edge.Destination] == false && !isPathFound)
                {
                    if (edge.Destination.Equals(destination))
                        return true;

                    isPathFound = ExploreForPathCheck(edge.Destination, destination, isPathFound);
                }
            }

            //PostProcess
            return isPathFound;
        }

        private Dictionary<T, T> thePrevMap;
        private Dictionary<T, int> theDistMap;

        /// <summary>
        /// find outs nodes reachable from a node "S".
        /// The difference between BFS and DFS is that, DFS aggressively choses its source every time in for loop 
        /// unitl it visits all the vertices where as BFS only visit vertices which are reachable from initial given
        /// source vertex.
        /// </summary>
        /// <param name="callBack"></param>
        public void BFS(T startVertex, Action<T> callBack)
        {
            thePrevMap = new Dictionary<T, T>();
            theDistMap = new Dictionary<T, int>();

            foreach (var v in Vertices)
            {
                thePrevMap.Add(v, default(T));
                theDistMap.Add(v, int.MaxValue);
            }

            theDistMap[startVertex] = 0;
            thePrevMap[startVertex] = default(T);

            Queue<T> thequeue = new Queue<T>();
            thequeue.Enqueue(startVertex);

            while (thequeue.Count > 0)
            {
                T u = thequeue.Dequeue();

                callBack(u);

                foreach (var edge in theAdjacencyList[u])
                {
                    T v = edge.Destination;

                    if (theDistMap[v] > theDistMap[u] + 1)
                    {
                        theDistMap[v] = theDistMap[u] + 1;
                        thePrevMap[v] = u;

                        thequeue.Enqueue(edge.Destination);
                    }
                }
            }
        }


        #region "SCC"

        //Return strongly connected component details
        public Dictionary<T, T> SCC()
        {
            List<T> vertexInFinishingOrder = new List<T>();
            DirectedGraph<T> gTransponse = new DirectedGraph<T>();

            //Initialize
            foreach (var v in Vertices)
            {
                vertexInFinishingOrder.Add(default(T));
                gTransponse.AddVertex(v);
            }

            //Transpose : reverse edges to transpose.
            foreach (var edge in Edges)
            {
                gTransponse.AddEdge(edge.Destination, edge.Source);
            }

            //1st DFS: to generate finishing time for each vertex
            SCC_DFS_Traversing(this, vertexInFinishingOrder);

            //2nd DFS: on transporsed graph with decreasing finishing time order.
            var result = SCC_DFS_Traversing_Decreasing(gTransponse, vertexInFinishingOrder);

            return result;
        }

        private void SCC_DFS_Traversing(DirectedGraph<T> graph, List<T> vertexInFinishingOrder)
        {
            theVisitedMap.Clear();

            foreach (var v in graph.Vertices)
            {
                theVisitedMap.Add(v, false);
            }

            int finishingTime = 0;

            foreach (var v in graph.Vertices)
            {
                if (theVisitedMap[v] == false)
                {
                    finishingTime = SCCExplore(graph, v, vertexInFinishingOrder, finishingTime);
                }
            }
        }

        private Dictionary<T, T> SCC_DFS_Traversing_Decreasing(DirectedGraph<T> graph, List<T> vertexInFinishingOrder)
        {
            theVisitedMap.Clear();

            Dictionary<T, T> sccMap = new Dictionary<T, T>();

            foreach (var v in graph.Vertices)
            {
                theVisitedMap.Add(v, false);
                sccMap[v] = default(T);
            }

            //in decreasing order of finishing time
            for (int i = vertexInFinishingOrder.Count - 1; i >= 0; i--)
            {
                T vertex = vertexInFinishingOrder[i];

                if (theVisitedMap[vertex] == false)
                {
                    SCCExplore(graph, vertex, sccMap: sccMap, sccLeader: vertex);
                }
            }

            return sccMap;
        }

        private int SCCExplore(DirectedGraph<T> graph, T vertex, 
                               List<T> vertexInFinishingOrder = null, int finishingTime = -1,
                               Dictionary<T, T> sccMap = null, T sccLeader = default(T))
        {
            //PreProcess
            theVisitedMap[vertex] = true;

            //setting the parent for each strongly connected component
            if (sccMap != null)
            {
                sccMap[vertex] = sccLeader;
            }

            foreach (var edge in graph.OutGoingEdges(vertex))
            {
                if (theVisitedMap[edge.Destination] == false)
                {
                    finishingTime = SCCExplore(graph, edge.Destination, vertexInFinishingOrder, finishingTime,
                                               sccMap, sccLeader);
                }
            }

            //PostProcess
            if (finishingTime >= 0) //not to process if finishing time is not required .. the case in 2nd dfs
            {
                vertexInFinishingOrder[finishingTime] = vertex;
                finishingTime = finishingTime + 1;
            }
            return finishingTime;
        }

        #endregion "SCC"

    }
}
