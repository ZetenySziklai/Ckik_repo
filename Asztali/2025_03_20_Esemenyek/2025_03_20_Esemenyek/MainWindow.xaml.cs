using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace _2025_03_20_Esemenyek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent(); 
            DataContext = new MyViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            MessageBox.Show((string)b.Content);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            ButtonBase b = e.Source as ButtonBase;
            if (e.Source!=null &&b.GetType() == typeof(Button))
                MessageBox.Show(""+b.Content);
            
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sdialog  = new SaveFileDialog();
            if(sdialog.ShowDialog() == true)
            {
                
                StreamWriter r = new StreamWriter("Fajl.txt");
                r.Write(RichTextBox.DataContextProperty);
                MessageBox.Show(sdialog.FileName);
            }

        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}