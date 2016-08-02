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
using System.Windows.Shapes;

namespace DataStructureAndAlgorithms.UI
{
    /// <summary>
    /// Interaction logic for MainWindowAlgo.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeWindows();
        }

        private Dictionary<string, Window> theWindowsMap = new Dictionary<string, Window>();

        private void InitializeWindows()
        {
            theWindowsMap["btnBasics"] = new BasicsUI();
            theWindowsMap["btnSorting"] = new SortingUI();
            theWindowsMap["btnSearching"] = new BasicsUI();

            theWindowsMap["btnHeaps"] = new HeapsPQUI();
            theWindowsMap["btnGraph"] = new GraphUI();
            theWindowsMap["btnTrees"] = new TreesUI();
            theWindowsMap["btnDynamic"] = new DynamicProgUI();
            theWindowsMap["btnGreedy"] = new GreedyUI();
            theWindowsMap["btnDCProblems"] = new DivideConquerUI();

        }

        private void btnOptionClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            theWindowsMap[btn.Name].Show();
        }
    }
}
