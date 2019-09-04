using System.Windows;

namespace RFID_gate_ui
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NotYetImplemented_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'a pas été encore implémentée.");
        }

        private void Quit_click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
