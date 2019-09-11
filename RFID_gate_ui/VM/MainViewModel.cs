using RFID_gate_ui.Views;
using RFID_gate_ui.VM;
using System.Windows.Controls;

namespace RFID_gate_ui
{
    class MainViewModel : BaseViewModel
    {
        private UserControl _contentWindow;

        public MainViewModel(UserControl contentWindow)
        {
            ContentWindow = contentWindow;
        }

        public UserControl ContentWindow
        {
            get { return _contentWindow; }
            set
            {
                _contentWindow = value;
                OnPropertyChanged();
            }
        }
    }
}
