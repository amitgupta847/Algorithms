using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureAndAlgorithms.BusinessServices.LinkedList;
using DataStructureAndAlgorithms.BusinessServices;

namespace Algo_UnitTests
{
    [TestClass]
    public class LinkedList_Tests
    {
        [TestMethod]
        public void LinkedList_Reverse()
        {
            City a = new City("A");
            City b = new City("B");
            City c = new City("C");
            City d = new City("D");
            // City a = new City("A");
            
            LinkedListNode<City> startNode = new LinkedListNode<City>(a);
            startNode.Next = new LinkedListNode<City>(b);
            startNode.Next.Next = new LinkedListNode<City>(c);
            startNode.Next.Next.Next = new LinkedListNode<City>(d);
          
            LinkedList<City> llist = new LinkedList<City>();
            LinkedListNode<City> header = llist.ReverseLinkedList(startNode);
            
        }
    }
}

