using RFID_gate_models;
using System.Collections.ObjectModel;

namespace RFID_gate_ui.VM
{
    class EmployeeViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        private Employee _selectedEmployee;

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

        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<Employee>();

            Load();
            
        }

        public void Load()
        {
            Employees.Clear();

            Employees.Add(new Employee { FirstName = "Nick", LastName = "Bourré" });
            Employees.Add(new Employee { FirstName = "Lyne", LastName = "Amyot" });
        }


    }
}
