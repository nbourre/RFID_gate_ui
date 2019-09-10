using RFID_gate_ui.VM;
using System.Windows;

namespace RFID_gate_ui
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();

            app.Show();
        }
    }
}
