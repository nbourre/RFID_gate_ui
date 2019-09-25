using RFID_gate_models;
using RFID_gate_ui.Data;
using System.Collections.ObjectModel;

namespace RFID_gate_ui.VM
{
    class EmployeeViewModel : BaseViewModel
    {
        private IDataService<Employee> employeeDataService;
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
            this.employeeDataService = new EmployeeDataService();         
            
            Load();
        }

        public void Load()
        {
            var employees = employeeDataService.GetAll();
            Employees.Clear();

            foreach (var employee in employees)
            {
                Employees.Add(employee);
            }

            
        }


    }
}
