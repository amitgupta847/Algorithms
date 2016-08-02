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
    public partial class SortingUI : Window
    {
        public SortingUI()
        {
            InitializeComponent();
            GetData();
        }

        int MIN_RECORD = 100;
        ObjectToSort[] theObjectsToSort;
        DataOtions theOption = DataOtions.Unsorted;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortClick(object sender, RoutedEventArgs e)
        {
            ObjectToSort[] objectsToSort = new ObjectToSort[theObjectsToSort.Length];

            theObjectsToSort.CopyTo(objectsToSort, 0);

            Button btn = sender as Button;
            Analysis analysis = null;

            switch (btn.Name)
            {
                case "btnInsertion":

                    analysis = Sorting.InsertionSort(objectsToSort);
                    txtTotalTimeInsertionSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnSelection":

                    analysis = Sorting.SelectionSort(objectsToSort);
                    txtTotalTimeSelectionSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnBubbleSort":

                    analysis = Sorting.BubbleSort(objectsToSort);
                    txtTotalTimeBubbleSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnQuickSort":

                    analysis = Sorting.QuickSort(objectsToSort);
                    txtTotalTimeQuickSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnMergeSort":

                    analysis = Sorting.MergeSort(objectsToSort);
                    txtTotalTimeMergeSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnRadixSort":

                    analysis = Sorting.RadixSort(objectsToSort);
                    txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;

                case "btnQuickFind":
                    //Represent N distinct object from 0 to N-1.
                    QuickFind find = new QuickFind(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    find.Union(7, 0);
                    find.Union(3, 5);
                    find.Union(8, 0);
                    find.Union(4, 1);
                    find.Union(4, 6);
                    find.Union(9, 6);

                    bool result = find.IsConnected(1, 6);
                    //txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;


                case "btnQuickUnion":
                    //Represent N distinct object from 0 to N-1.
                    QuickUnion findqu = new QuickUnion(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    findqu.Union(8, 2);
                    findqu.Union(5, 6);
                    findqu.Union(7, 0);
                    findqu.Union(9, 4);
                    findqu.Union(8, 0);
                    findqu.Union(5, 9);

                    findqu.Union(3, 6);
                    findqu.Union(0, 5);
                    findqu.Union(3, 1);

                    bool result123 = findqu.IsConnected(1, 6);
                    //txtTotalTimeRadixSort.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

                    break;
            }

            lstOutput.ItemsSource = objectsToSort;
            lstOutput.DisplayMemberPath = "VisibleName";

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
            theObjectsToSort = DataGenerator.Generator(numberOfElements, options);
            lstInput.ItemsSource = null;
            lstInput.ItemsSource = theObjectsToSort;
            lstInput.DisplayMemberPath = "VisibleName";

            lstOutput.ItemsSource = null;
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
