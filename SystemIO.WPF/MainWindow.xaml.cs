using System.Windows;
using System.Collections.Generic;
using SystemIO.Common;
using SystemIO.Common.Data;
using SystemIO.Common.Helpers;
using SystemIO.Common.Models;
using System.Data;

namespace SystemIO.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuListStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentDataGrid.Items.Clear();
            StudentRepository repo = new StudentRepository(Settings.FilePath);
            students = repo.List();
            
            StudentDataGrid.ItemsSource = students;
        }

        private void MenuAddStudent_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student
            {
                FirstName = "New Student",
                LastName = "Last Name",
                Major = "New Major",
                GPA = 3.0M
            });
        }

        private void MenuDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            students.Remove((Student)StudentDataGrid.CurrentItem);

        }

        private void MenuUpdateGPA_Click(object sender, RoutedEventArgs e)
        {
            var stud = (Student)StudentDataGrid.CurrentItem;
            stud.GPA = 3.5M;
        }

        private void StudentDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var dummy = false;
        }
    }
}
