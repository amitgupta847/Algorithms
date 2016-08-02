using DataStructureAndAlgorithms.BusinessServices;
using DataStructureAndAlgorithms.BusinessServices.DynamicProgramming;
using DataStructureAndAlgorithms.BusinessServices.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataStructureAndAlgorithms.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DynamicProgUI : Window
    {
        public DynamicProgUI()
        {
            theResultedGraph = new Graph<City>();
            InitializeComponent();
            GetData();
            graphMainGrid.DataContext = this;

        }

        Graph<City> theCitiesGraph;
        Graph<City> theResultedGraph;// the graph after performing any operation on original graph;

        public Graph<City> CityGraph
        {
            get { return theCitiesGraph; }
        }

        public Graph<City> ResultedGraph
        {
            get { return theResultedGraph; }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortClick(object sender, RoutedEventArgs e)
        {
            //ObjectToSort[] objectsToSort = new ObjectToSort[theObjectsToSort.Length];

            //theObjectsToSort.CopyTo(objectsToSort, 0);



        }

        private void LoadDataRefresh(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            LoadData();
        }

        private void LoadData()
        {
            theCitiesGraph = DataGenerator.GetNegativeCycleCityGraph();//.GetCityGraph();
            // lstInput.ItemsSource = null;
            // lstInput.DataContext = theCitiesGraph.Vertices;
            //lstInput.DisplayMemberPath = "VisibleName";
        }

        private void rdoBtnSelectionType_Checked(object sender, RoutedEventArgs e)
        {
            if (txtNumberOfElements == null)
            {
                return;
            }

        }


        private void OperationClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Analysis analysis = null;
            theResultedGraph.Vertices.Clear();

            switch (btn.Name)
            {
                case "btnKnapsack":

                    Knapsack ks = new Knapsack();
                    ks.SelectItems();

                    break;

                case "btnDijsktra":

                    

                    break;
            }

            lstOutput.Items.Refresh();

            //.UpdateLayout();
            //lstOutput.ItemsSource = objectsToSort;
            //lstOutput.DisplayMemberPath = "VisibleName";
        }


        public void OnTraversed(GraphNode<City> nodeReceived)
        {
            if (nodeReceived != null)
            {
                theResultedGraph.Vertices.Add(nodeReceived);
            }
        }

    }
}
