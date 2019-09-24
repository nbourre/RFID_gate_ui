using RFID_gate_models;
using RFID_gate_ui.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFID_gate_ui.Data
{
    class EmployeeDataService : IDataService<Employee>
    {
        static List<Employee> Employees = new List<Employee>()
        {
            new Employee { FirstName = "Nick", LastName = "Bourré", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "Lyne", LastName = "Amyot", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "France", LastName = "Jean", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "Stevens", LastName = "Gagnon", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "Mathieu", LastName = "St-Yves", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "James", LastName = "Hoffman", CardId = RandomFunctions.AlphanumericalString(5) },
            new Employee { FirstName = "Marco", LastName = "Guilmette", CardId = RandomFunctions.AlphanumericalString(5) },
        };

        IEnumerable<Employee> IDataService<Employee>.GetAll()
        {
            foreach (Employee e in Employees)
            {
                yield return e;
            }
        }


    }
}
