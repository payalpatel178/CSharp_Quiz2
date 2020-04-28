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

namespace csharp_quiz2
{
    /// <summary>
    /// Interaction logic for TreeViewExample.xaml
    /// </summary>
    public partial class TreeViewExample : Window
    {
        int count = 0;
        int countEven = 0;
        int countOdd = 0;
        public TreeViewExample()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 != 0)
            {
                countOdd++;
                tvOdd.Header = countOdd;
                btnClick.Background = Brushes.Red;
            }
            else
            {
                countEven++;
                tvEven.Header = countEven;
                btnClick.Background = Brushes.Blue;
            }
        }
    }
}
