using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices
{
    public enum DataOtions
    {
        Unsorted,
        UnsortedWithDuplicates,
        SortedAscendingOrder,
        SortedDesendingOrder,
    }

    public class DataGenerator
    {
        public static ObjectToSort[] Generator(int numberOfObjects, DataOtions option = DataOtions.Unsorted)
        {
            ObjectToSort[] objToSort = new ObjectToSort[numberOfObjects];

            switch (option)
            {
                case DataOtions.Unsorted:
                    Random objrandom1 = new Random();
                    for (int i = 0; i < numberOfObjects; i++)
                    {
                        ObjectToSort obj = new ObjectToSort();

                        obj.Key = objrandom1.Next(1, numberOfObjects);//* (100 + (objrandom1.Next(1, numberOfObjects)));
                        obj.Name = "Object" + i;

                        objToSort[i] = obj;
                    }
                    break;

                case DataOtions.UnsortedWithDuplicates:
                    //Yet to do
                    Random objrandom = new Random();
                    for (int i = 0; i < numberOfObjects; i++)
                    {
                        ObjectToSort obj = new ObjectToSort();

                        obj.Key = objrandom.Next(1, numberOfObjects);//* (100 + (objrandom.Next(1, numberOfObjects)));
                        obj.Name = "Object" + i;

                        objToSort[i] = obj;
                    }
                    break;

                case DataOtions.SortedAscendingOrder:
                    for (int i = 0; i < numberOfObjects; i++)
                    {
                        ObjectToSort obj = new ObjectToSort();

                        obj.Key = i;
                        obj.Name = "Object" + i;

                        objToSort[i] = obj;
                    }
                    break;


                case DataOtions.SortedDesendingOrder:
                    for (int number = numberOfObjects, aarray = 0; aarray < numberOfObjects; aarray++, number--)
                    {
                        ObjectToSort obj = new ObjectToSort();

                        obj.Key = number;
                        obj.Name = "Object" + number;

                        objToSort[aarray] = obj;
                    }
                    break;

            }

            return CreateClone<ObjectToSort[]>(objToSort);
        }


        public static Graph<City> GetCityGraph()
        {
            Graph<City> graph = new Graph<City>();

            GraphNode<City> nodeA = new GraphNode<City>(1, new City("Jammu"));
            graph.AddVertex(nodeA);

            GraphNode<City> nodeB = new GraphNode<City>(2, new City("Pathankot"));
            graph.AddVertex(nodeB);

            GraphNode<City> nodeC = new GraphNode<City>(3, new City("Jalandhar"));
            graph.AddVertex(nodeC);

            GraphNode<City> nodeD = new GraphNode<City>(4, new City("Amritsar"));
            graph.AddVertex(nodeD);

            GraphNode<City> nodeE = new GraphNode<City>(5, new City("Ludhiana"));
            graph.AddVertex(nodeE);

            GraphNode<City> nodeF = new GraphNode<City>(6, new City("Chandigarh"));
            graph.AddVertex(nodeF);

            GraphNode<City> nodeG = new GraphNode<City>(7, new City("Delhi"));
            graph.AddVertex(nodeG);

            GraphNode<City> nodeH = new GraphNode<City>(8, new City("Pune"));
            graph.AddVertex(nodeH);

            GraphNode<City> nodeI = new GraphNode<City>(9, new City("Bangalore"));
            graph.AddVertex(nodeI);

            GraphNode<City> nodeY = new GraphNode<City>(10, new City("Nepal"));
            graph.AddVertex(nodeY);

            GraphNode<City> nodeZ = new GraphNode<City>(11, new City("Pakistan"));
            graph.AddVertex(nodeZ);
            //Add edges
            //FromA
            graph.AddEdge(new Edge<City>(nodeA, nodeB, 100));
            graph.AddEdge(new Edge<City>(nodeA, nodeD, 100));

            //B
            graph.AddEdge(new Edge<City>(nodeB, nodeA, 100));
            graph.AddEdge(new Edge<City>(nodeB, nodeC, 100));
            graph.AddEdge(new Edge<City>(nodeB, nodeD, 100));
            graph.AddEdge(new Edge<City>(nodeB, nodeF, 260));

            //C
            graph.AddEdge(new Edge<City>(nodeC, nodeB, 100));
            graph.AddEdge(new Edge<City>(nodeC, nodeE, 100));
            graph.AddEdge(new Edge<City>(nodeC, nodeF, 150));

            //D
            graph.AddEdge(new Edge<City>(nodeD, nodeA, 175));
            graph.AddEdge(new Edge<City>(nodeD, nodeB, 100));
            graph.AddEdge(new Edge<City>(nodeD, nodeE, 100));

            //E
            graph.AddEdge(new Edge<City>(nodeE, nodeC, 100));
            graph.AddEdge(new Edge<City>(nodeE, nodeD, 100));
            graph.AddEdge(new Edge<City>(nodeE, nodeF, 100));
            graph.AddEdge(new Edge<City>(nodeE, nodeG, 300));

            //F
            graph.AddEdge(new Edge<City>(nodeF, nodeB, 260));
            graph.AddEdge(new Edge<City>(nodeF, nodeC, 150));
            graph.AddEdge(new Edge<City>(nodeF, nodeE, 100));

            //G
            graph.AddEdge(new Edge<City>(nodeG, nodeE, 300));
            graph.AddEdge(new Edge<City>(nodeG, nodeH, 500));

            //H
            graph.AddEdge(new Edge<City>(nodeH, nodeG, 500));
            graph.AddEdge(new Edge<City>(nodeH, nodeI, 500));

            //I
            graph.AddEdge(new Edge<City>(nodeI, nodeH, 500));

            Graph<City> newClone = CreateClone<Graph<City>>(graph);
            return newClone;
        }


        public static Graph<City> GetNegativeCycleCityGraph()
        {
            Graph<City> graph = new Graph<City>();

            GraphNode<City> nodeA = new GraphNode<City>(1, new City("Jammu"));
            graph.AddVertex(nodeA);

            GraphNode<City> nodeB = new GraphNode<City>(2, new City("Pathankot"));
            graph.AddVertex(nodeB);

            GraphNode<City> nodeC = new GraphNode<City>(3, new City("Jalandhar"));
            graph.AddVertex(nodeC);

            GraphNode<City> nodeD = new GraphNode<City>(4, new City("Amritsar"));
            graph.AddVertex(nodeD);

            GraphNode<City> nodeE = new GraphNode<City>(5, new City("Ludhiana"));
            graph.AddVertex(nodeE);


            //Add edges
            //FromA
            graph.AddEdge(new Edge<City>(nodeA, nodeD, -100));

            //B
            graph.AddEdge(new Edge<City>(nodeB, nodeA, 100));
            graph.AddEdge(new Edge<City>(nodeB, nodeC, 100));

            //C
            graph.AddEdge(new Edge<City>(nodeC, nodeE, 500));

            //D
            graph.AddEdge(new Edge<City>(nodeD, nodeB, -100));
            graph.AddEdge(new Edge<City>(nodeD, nodeC, 300));

            Graph<City> newClone = CreateClone<Graph<City>>(graph);
            return newClone;
        }


        public static Graph<City> GetNegativeEdge_NoCycleCityGraph()
        {
            Graph<City> graph = new Graph<City>();

            GraphNode<City> nodeS = new GraphNode<City>(1, new City("S"));
            graph.AddVertex(nodeS);

            GraphNode<City> nodeA = new GraphNode<City>(2, new City("A"));
            graph.AddVertex(nodeA);

            GraphNode<City> nodeB = new GraphNode<City>(3, new City("B"));
            graph.AddVertex(nodeB);

            //Add edges
            //FromS
            graph.AddEdge(new Edge<City>(nodeS, nodeA, 5));
            graph.AddEdge(new Edge<City>(nodeS, nodeB, 4));

            //A
            graph.AddEdge(new Edge<City>(nodeA, nodeB, -2));
        
            Graph<City> newClone = CreateClone<Graph<City>>(graph);
            return newClone;
        }

        public static T CreateClone<T>(object source)
        {
            T clone;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                clone = (T)formatter.Deserialize(stream);
            }

            return clone;
        }


    }
}
