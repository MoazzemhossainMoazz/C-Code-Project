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

namespace ShowSortingValue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddClick(object sender, RoutedEventArgs e)
        {
            List<int> numbers = new List<int>();
            string input = tbInput.Text;
            string[] result = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                numbers.Add(int.Parse(s));
            }
            string showInput = string.Join(" ", numbers);
            tBshowOutPut.Text = showInput;
            
        }
    }
}
