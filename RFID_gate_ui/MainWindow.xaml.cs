using RFID_gate_ui.Views;
using System.Windows;

namespace RFID_gate_ui
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _mainViewModel;
        EmployeeView _employeeView;
        RoomView _roomView;

        public MainWindow()
        {
            InitializeComponent();

            _employeeView = new EmployeeView();
            _roomView = new RoomView();
            

            _mainViewModel = new MainViewModel(_employeeView);

            DataContext = _mainViewModel;

        }

        private void NotYetImplemented_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'a pas été encore implémentée.");
        }

        private void Quit_click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void EmployeeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            _mainViewModel.ContentWindow = _employeeView;
        }

        private void RoomMenuItem_Click(object sender, RoutedEventArgs e)
        {
            _mainViewModel.ContentWindow = _roomView;
        }
    }
}
