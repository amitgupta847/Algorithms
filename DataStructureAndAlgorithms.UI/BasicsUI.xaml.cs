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
    public partial class BasicsUI : Window
    {
        public BasicsUI()
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
            Button btn = sender as Button;
            Analysis analysis = new Analysis(); ;

            switch (btn.Name)
            {
                case "btnFibRec":

                    FibonocciRecursvise();
                    break;

                case "btnFibNonRec":

                    FibonocciNonRecursive();
                    break;
            }

            //lstOutput.ItemsSource = objectsToSort;
            // lstOutput.DisplayMemberPath = "VisibleName";

        }


        private void FibonocciRecursvise()
        {
            Analysis analysis = new Analysis(); ;
          
            analysis.Start();
            Fibonacci fib = new Fibonacci(Convert.ToInt32(txtFibNumberRec.Text.Trim()));
            double num = fib.RecursiveSolution();

            analysis.Stop();

            txtAnalysisFibocciRecursive.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;

            txtResultFibocciRecursive.Text = "Result is " + num;
        }

        private void FibonocciNonRecursive()
        {
            Analysis analysis = new Analysis(); ;
           
            analysis.Start();

            Fibonacci fib = new Fibonacci(Convert.ToInt32(txtFibNumberNonRec.Text.Trim()));
            double num = fib.NonRecursive();
            
            analysis.Stop();

            txtAnalysisFibocciNonRecursive.Text = "Time Spent (In MiliSeconds) = " + analysis.ElapsedTime;
            txtResultFibocciNonRecursive.Text = "Result is " + num;
        }

        //Greatest common divisor.
        private void GCD()
        {

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
