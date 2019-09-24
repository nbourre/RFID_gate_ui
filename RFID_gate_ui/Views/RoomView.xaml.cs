using RFID_gate_ui.VM;
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

namespace RFID_gate_ui.Views
{
    /// <summary>
    /// Logique d'interaction pour RoomView.xaml
    /// </summary>
    public partial class RoomView : UserControl
    {
        public RoomView()
        {
            InitializeComponent();

            this.DataContext = new RoomViewModel();
        }
    }
}
