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
using wpfApp1.Core.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentWorker sw = new StudentWorker();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = sw;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sw.SetStudentName();
            sw.OnPropertyChanged(nameof(sw.StudentName));
            
        }
    }
}
