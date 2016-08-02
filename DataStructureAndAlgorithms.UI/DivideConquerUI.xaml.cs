using DataStructureAndAlgorithms.BusinessServices;
using DataStructureAndAlgorithms.BusinessServices.DivideAndConquer;
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
    public partial class DivideConquerUI : Window
    {
        public DivideConquerUI()
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

                case "btnCountingInversion":

                    int[] arr = new int[] { 1, 3, 5, 2, 4, 6 };
                    var v = CountingInversion.CoutingInverstionCount(arr);
                    // txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnMinimumRefillsEfficient":

                    var v2 = mini.AnotherWayToGetMinimumRefill();
                    // txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;



                case "btnOneDiminPeakFind":
                    try
                    {
                        int[] arr2 = new int[] { 15, 13, 12, 11, 10, 25, 2 };
                        //{ 12, 12, 12, 11, 10, 15, 14 };
                        PeakFinding.FindPeak(arr2);
                    }
                    catch (Exception ex)
                    {

                    }
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
