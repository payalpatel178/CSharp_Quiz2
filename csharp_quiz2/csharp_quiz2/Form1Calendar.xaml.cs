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
    /// Interaction logic for Form1Calendar.xaml
    /// </summary>
    public partial class Form1Calendar : Window
    {
        public Form1Calendar()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string selectedDate = calendar.SelectedDate.ToString();

            //Using constructor
            Form2 form2 = new Form2(selectedDate);
            form2.Show();
        }
    }
}
