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
    public partial class HeapsPQUI : Window
    {
        public HeapsPQUI()
        {
            InitializeComponent();
            GetData();

            // this.gridMain.DataContext = this;
        }

        int MIN_RECORD = 100;

        List<ObjectToSort> theObjectsToSort;
        DataOtions theOption = DataOtions.Unsorted;

        private void SortClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            List<HeapElement<ObjectToSort>> lstToSOrt = theObjectsToSort.Select(el => new HeapElement<ObjectToSort>(el.Key, el)).ToList();

            BinaryArrayHeap<ObjectToSort> heap = new BinaryArrayHeap<ObjectToSort>(lstToSOrt);

            switch (btn.Name)
            {
                case "btnBuildHeap":
                    //Analysis analysis = null;
                    //List<HeapElement<ObjectToSort>> toSort = heap.BuildMaxHeap(out analysis);
                    //txtTotalTimeBuildHeap.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    lstHeap.ItemsSource = heap.Heap;
                    lstHeap.DisplayMemberPath = "VisibleName";
                    break;

                case "btnHeapSort":

                    Analysis analysis2 = null;

                    lstOutput.ItemsSource = heap.HeapSort(out analysis2); ;
                    lstOutput.DisplayMemberPath = "VisibleName";
                    txtTotalTimeHeapSort.Text = "Time Spent (In MiliSeconds) = " + analysis2.ElapsedTime;
                    break;
            }
        }

        private void LoadDataRefresh(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            int numberOfElement;
            if (txtNumberOfElements != null && int.TryParse(txtNumberOfElements.Text, out numberOfElement))
            {
                LoadData(numberOfElement, theOption);
            }
            else
            {
                LoadData(MIN_RECORD, theOption);
            }
        }

        private void LoadData(int numberOfElements, DataOtions options)
        {
            theObjectsToSort = DataGenerator.Generator(numberOfElements, options).ToList();
            lstInput.ItemsSource = null;
            lstInput.ItemsSource = theObjectsToSort;
            lstInput.DisplayMemberPath = "VisibleName";

            lstOutput.ItemsSource = null;
            lstHeap.ItemsSource = null;
        }

        private void rdoBtnSelectionType_Checked(object sender, RoutedEventArgs e)
        {
            if (txtNumberOfElements == null)
            {
                return;
            }
            RadioButton btn = sender as RadioButton;

            switch (btn.Name)
            {
                case "rdoBtnUnsorted":
                    theOption = DataOtions.Unsorted;
                    GetData();
                    break;

                case "rdoBtnUnsortedWithDulicates":
                    theOption = DataOtions.UnsortedWithDuplicates;
                    GetData();
                    break;

                case "rdoBtnAlreaySortedAsc":
                    theOption = DataOtions.SortedAscendingOrder;
                    GetData();
                    break;

                case "rdoBtnAlreaySortedDesc":
                    theOption = DataOtions.SortedDesendingOrder;
                    GetData();
                    break;

            }
        }


    }
}
