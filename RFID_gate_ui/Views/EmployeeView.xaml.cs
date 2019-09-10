using RFID_gate_ui.VM;
using System.Windows.Controls;

namespace RFID_gate_ui.Views
{
    /// <summary>
    /// Logique d'interaction pour EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        public EmployeeView()
        {
            InitializeComponent();
            this.DataContext = new EmployeeViewModel();
        }
    }
}
