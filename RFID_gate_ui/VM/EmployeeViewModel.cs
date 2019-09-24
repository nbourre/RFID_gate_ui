using RFID_gate_models;
using RFID_gate_ui.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RFID_gate_ui.VM
{
    class EmployeeViewModel : BaseViewModel
    {
        private IDataService<Employee> employeeDataService;
        public ObservableCollection<Employee> Employees { get; set; }
        private Employee _selectedEmployee;

        private ObservableCollection<Access> _selectedAccesses;
        
        private IDataService<Access> _accesses;

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

            _selectedAccesses = new ObservableCollection<Access>();
            
            
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
