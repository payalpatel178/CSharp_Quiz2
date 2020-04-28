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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace csharp_quiz2
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        List<Student> lstStudents = new List<Student>();

        public StudentForm()
        {
            InitializeComponent();
            
            lstStudents.Add(new Student(1, "Alice"));
            lstStudents.Add(new Student(2, "Bob"));
            lstStudents.Add(new Student(3, "Paul"));
            lstStudents.Add(new Student(4, "John"));
            lstStudents.Add(new Student(5, "Rahul"));
            lbStudents.ItemsSource = students;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text != "")
            {
                for(int i = 1; i < 6; i++)
                {
                    if (txtBox.Text.Equals(i))
                    {
                        students.Add(lstStudents[i]);   
                    }
            }
            }
            else
            {
                MessageBox.Show("Enter student Id in Text Box");
            }
           
        }
    }
    public class Student : INotifyPropertyChanged
{
        public int id;
        public string name;

        public Student()
        {
            
        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


    public string Name
    {
        get { return this.name; }
        set
        {
            if (this.name != value)
            {
                this.name = value;
                this.NotifyPropertyChanged("Name");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
}
