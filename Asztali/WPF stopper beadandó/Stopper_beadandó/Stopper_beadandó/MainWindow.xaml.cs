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
using System.Windows.Threading;



namespace Stopper_beadandó
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private TimeSpan _elapsedTime;
        private TimeSpan _lapTimer;
        private bool _isRunning;
        private string Laptime;
        private int _lapIndex;
        public MainWindow()
        {
            InitializeComponent();
            // Initialize the timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(0.01); // Update every second
            _timer.Tick += Timer_Tick;

            // Initial state of the stopwatch
            _elapsedTime = TimeSpan.Zero;
            _lapTimer = TimeSpan.Zero;
            _isRunning = false;
             
    }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _lapTimer = _lapTimer.Add(TimeSpan.FromSeconds(1));
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1)); // Increm ent time by 1 second
            TimeLabel.Content = _elapsedTime.ToString(@"hh\:mm\:ss"); // Update the label
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            cancel.IsEnabled = true;
            if (_isRunning)
            {
                
                _timer.Stop();
                start.Content = "Start";
                start.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#038c0e"));
                start.Foreground = Brushes.Green;

                cancel.Content = "Cancel";
            }
            else
            {
                _lapIndex = 0;
                _timer.Start();
                start.Content = "Stop";
                start.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8c0303"));
                start.Foreground = Brushes.Red;
                
                cancel.Content = "Lap";

            }

            _isRunning = !_isRunning;

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {

            if (_isRunning)
            {
                _lapIndex++;
                Laptime = _lapTimer.ToString( @"hh\:mm\:ss");
                LapTime.Items.Add(_lapIndex + ". kör" +"                            "+Laptime);

                _lapTimer = TimeSpan.Zero;
            }
            else 
            {
                cancel.Content = "Cancel";
                _elapsedTime = TimeSpan.Zero;
                TimeLabel.Content = _elapsedTime.ToString(@"hh\:mm\:ss");
                LapTime.Items.Clear();

            }
            
        }

        
    }
}