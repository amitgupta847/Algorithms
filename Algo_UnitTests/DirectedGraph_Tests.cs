using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureAndAlgorithms.BusinessServices.Graphs.New;
using newData = DataStructureAndAlgorithms.BusinessServices.Graphs.New;
using System.Collections.Generic;
using DataStructureAndAlgorithms.BusinessServices;

namespace Algo_UnitTests
{
    [TestClass]
    public class DirectedGraphTests
    {
        private IList<City> theCities;
        private DirectedGraph<City> theCityGraph;
        [TestInitialize]
        public void Initialize()
        {
            theCities = new List<City> {
                new City("Pathankot"),
                new City("Jammu"),
                new City("Gurdaspur"),
                new City("Amritsar"),
            };

            theCityGraph = new DirectedGraph<City>(theCities);
            IEnumerable<City> vertex = theCityGraph.Vertices;

            //Pathankot to Jammu == 100
            theCityGraph.AddEdge(theCities[0], theCities[1], 100);
            //Pathankot to Gurdaspur == 50
            theCityGraph.AddEdge(theCities[0], theCities[2], 50);
            //Pathankot to Amritsar == 110
            theCityGraph.AddEdge(theCities[0], theCities[3], 110);
            //Gurdaspur to Amritsar == 90
            theCityGraph.AddEdge(theCities[2], theCities[3], 90);
            //Amritsar to Jammu = 150
            theCityGraph.AddEdge(theCities[3], theCities[1], 150);

        }



        [TestMethod]
        public void TestMethod()
        {
        }




        [TestMethod]
        public void GraphEdgeTest()
        {

            List<newData.Edge<City>> localEdges = new List<newData.Edge<City>>();
            foreach (var edge in theCityGraph.Edges)
            {
                localEdges.Add(edge);
            }
        }

        [TestMethod]
        public void VertexNeighbourCheck()
        {
            LinkedList<newData.Edge<City>> var = theCityGraph[0];

            var outgoingEdges = theCityGraph.OutGoingEdges(theCities[0]);

            List<newData.Edge<City>> edges = new List<newData.Edge<City>>();
            foreach (var edge in outgoingEdges)
            {
                edges.Add(edge);
            }
        }

        [TestMethod]
        public void DFSTest()
        {
            theVisitOrderMap.Clear();
            theCityGraph.DFS_Traversing(Visit);

            Assert.IsTrue(theVisitOrderMap.Count == theCities.Count);
        }

        private List<City> theVisitOrderMap = new List<City>();


        [TestMethod]
        public void BFSTest()
        {
            theVisitOrderMap.Clear();
            theCityGraph.BFS(theCities[0], Visit);

            Assert.IsTrue(theVisitOrderMap.Count == theCities.Count);
        }

        private void Visit(City city)
        {
            theVisitOrderMap.Add(city);

        }
        [TestMethod]
        public void Test_StronglyConnectedComponent()
        {
            List<City> cities = new List<City> {
                new City("a"), //0
                new City("b"),//1
                new City("c"),//2
                new City("d"),//3
                new City("e"),//4
                new City("f"),//5
                new City("g"),//6
                new City("h"),//7
            };

            DirectedGraph<City> sccTOFindGraph = new DirectedGraph<City>(cities);

            //a to b 
            sccTOFindGraph.AddEdge(cities[0], cities[1]);

            //b to c
            sccTOFindGraph.AddEdge(cities[1], cities[2]);
            //b to e
            sccTOFindGraph.AddEdge(cities[1], cities[4]);
            //b to f
            sccTOFindGraph.AddEdge(cities[1], cities[5]);

            //c to d
            sccTOFindGraph.AddEdge(cities[2], cities[3]);
            //c to g
            sccTOFindGraph.AddEdge(cities[2], cities[6]);

            //d to c
            sccTOFindGraph.AddEdge(cities[3], cities[2]);
            //d to h
            sccTOFindGraph.AddEdge(cities[3], cities[7]);

            //e to a
            sccTOFindGraph.AddEdge(cities[4], cities[0]);
            //e to f
            sccTOFindGraph.AddEdge(cities[4], cities[5]);

            //f to g
            sccTOFindGraph.AddEdge(cities[5], cities[6]);

            //g to f
            sccTOFindGraph.AddEdge(cities[6], cities[5]);
            //g to h
            sccTOFindGraph.AddEdge(cities[6], cities[7]);

            //h to h
            sccTOFindGraph.AddEdge(cities[7], cities[7]);

            List<City> vertices = new List<City>();
            foreach (var v in sccTOFindGraph.Vertices)
            {
                vertices.Add(v);
            }
            Assert.IsTrue(vertices.Count == cities.Count);

            List<newData.Edge<City>> edges = new List<newData.Edge<City>>();
            foreach (var edge in sccTOFindGraph.Edges)
            {
                edges.Add(edge);
            }
            Assert.IsTrue(edges.Count == 14);


            var result = sccTOFindGraph.SCC();

            Assert.IsTrue(result.Count > 0);
        }


        [TestMethod]
        public void Test_DFSPathCheck()
        {
            List<City> cities = new List<City> {
                new City("a"), //0
                new City("b"),//1
                new City("c"),//2
                new City("d"),//3
                new City("e"),//4
                new City("f"),//5
                new City("g"),//6
                new City("h"),//7
            };

            DirectedGraph<City> graph = new DirectedGraph<City>(cities);

            //a to b 
            graph.AddEdge(cities[0], cities[1]);

            //b to c
            graph.AddEdge(cities[1], cities[2]);
            //b to e
            graph.AddEdge(cities[1], cities[4]);
            //b to f
            graph.AddEdge(cities[1], cities[5]);

            //c to d
            graph.AddEdge(cities[2], cities[3]);
            //c to g
            graph.AddEdge(cities[2], cities[6]);

            //d to c
            graph.AddEdge(cities[3], cities[2]);
            //d to h
            graph.AddEdge(cities[3], cities[7]);

            //e to a
            graph.AddEdge(cities[4], cities[0]);
            //e to f
            graph.AddEdge(cities[4], cities[5]);

            //f to g
            graph.AddEdge(cities[5], cities[6]);

            //g to f
            graph.AddEdge(cities[6], cities[5]);
            //g to h
            graph.AddEdge(cities[6], cities[7]);

            //h to h
            graph.AddEdge(cities[7], cities[7]);

            var result = graph.DFS_IsPath(cities[3], cities[0]);

            Assert.IsTrue(result == false);
        }
    }
}
