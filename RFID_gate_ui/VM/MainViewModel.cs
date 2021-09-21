using RFID_gate_ui.Helpers;
using RFID_gate_ui.Views;
using RFID_gate_ui.VM;
using System.Windows.Controls;

namespace RFID_gate_ui
{
    class MainViewModel : BaseViewModel
    {
        private UserControl _contentWindow;
        public DelegateCommand<string> ShowEntityWindow;

        public MainViewModel(UserControl contentWindow)
        {
            ShowEntityWindow = new DelegateCommand<string>
            (
                (p) => OnShowEntityWindow(p),
                (p) => CanShowEntityWindow(p)
            );

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

        private bool CanShowEntityWindow(string entityType)
        {
            if ((this.ContentWindow is EmployeeView && entityType == "EMPLOYEES") ||
                (this.ContentWindow is RoomView && entityType == "ROOMS"))
            {
                return false;
            }

            return true;
        }

        private void OnShowEntityWindow(string entityType)
        {
            switch (entityType)
            {
                case "EMPLOYEES":
                    this.ContentWindow = new EmployeeView();
                    break;
                case "ROOMS":
                    this.ContentWindow = new RoomView();
                    break;
                default:
                    break;
            }
        }
    }
}
