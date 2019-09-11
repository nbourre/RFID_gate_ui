using RFID_gate_models;
using System;
using System.Collections.Generic;

namespace RFID_gate_ui.Data
{
    class EmployeeDataService : IDataService<Employee>
    {
        List<Employee> Employees = new List<Employee>()
        {
            new Employee { FirstName = "Nick", LastName = "Bourré" },
            new Employee { FirstName = "Lyne", LastName = "Amyot" },
            new Employee { FirstName = "France", LastName = "Jean" },
            new Employee { FirstName = "Stevens", LastName = "Gagnon" },
            new Employee { FirstName = "Mathieu", LastName = "St-Yves" },
            new Employee { FirstName = "James", LastName = "Hoffman" },
            new Employee { FirstName = "Marco", LastName = "Guilmette" },
        };

        IEnumerable<Employee> IDataService<Employee>.GetAll()
        {
            return Employees;
        }
    }
}
