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
    public partial class TreesUI : Window
    {
        public TreesUI()
        {
            InitializeComponent();
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


            //lstOutput.ItemsSource = objectsToSort;
            // lstOutput.DisplayMemberPath = "VisibleName";

        }


   


    }
}
