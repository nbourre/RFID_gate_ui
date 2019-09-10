using System.Windows;
using System.Windows.Controls;

namespace RFID_gate_ui.Views
{
    /// <summary>
    /// Logique d'interaction pour MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
            this.DataContext = this;
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
