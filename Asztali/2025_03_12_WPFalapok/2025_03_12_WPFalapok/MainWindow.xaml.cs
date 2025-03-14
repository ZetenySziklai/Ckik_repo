using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2025_03_12_WPFalapok
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

        private void kutya(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kis ablak");
            
            label1.Background = Brushes.Green;
           
        }
        private void kutya2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nagy ablak");
            
            label1.Background = Brushes.Green;

        }


    }
}