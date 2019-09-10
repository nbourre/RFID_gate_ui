using RFID_gate_models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace RFID_gate_ui
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees { get; set; }
        private Employee _selectedEmployee;

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            Employees = new ObservableCollection<Employee>();

            InitializeComponent();
            this.DataContext = this;

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        public void Load()
        {
            Employees.Clear();

            Employees.Add(new Employee { FirstName = "Nick", LastName = "Bourré" });
            Employees.Add(new Employee { FirstName = "Lyne", LastName = "Amyot" });

        }



        private void NotYetImplemented_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'a pas été encore implémentée.");
        }

        private void Quit_click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
