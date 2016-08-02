using DataStructureAndAlgorithms.BusinessServices;
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
    public partial class GreedyUI : Window
    {
        public GreedyUI()
        {
            InitializeComponent();
            graphMainGrid.DataContext = this;
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
           
        }

        private void LoadData()
        {
           //theCitiesGraph = DataGenerator.GetNegativeCycleCityGraph();//.GetCityGraph();
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
           
            MinimumFuelRefill mini = new MinimumFuelRefill();

            switch (btn.Name)
            {
                    
                case "btnMinimumRefills":

                    var v = mini.GetPumps();
                    // txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnMinimumRefillsEfficient":

                    var v2 = mini.AnotherWayToGetMinimumRefill();
                    // txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                    

                case "btnDijsktra":


                    //  analysis = Sorting.RadixSort(objectsToSort);
                    // txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

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
               
            }
        }

    }
}
