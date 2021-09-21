using RFID_gate_models;
using System.Linq;

namespace RFID_gate_ui.Data
{
    /// <summary>
    /// Classe utilisée pour charger les données statiques
    /// </summary>
    static class DataLoader
    {
        static IDataService<Employee> employeeDataService = new EmployeeDataService();
        static IDataService<Room> roomDataService = new RoomDataService();
        static IDataService<Access> accessDataService;

        static public void Boot()
        {
            var employees = employeeDataService.GetAll();
            var rooms = roomDataService.GetAll();

            accessDataService = new AccessDataService(employees.ToList(), rooms.ToList());

            var accesses = accessDataService.GetAll();

            foreach (Employee e in employees)
            {
                e.Accesses = accesses.Where(access => access.CardId == e.CardId).ToList();
            }

            foreach (Room r in rooms)
            {
                r.Accesses = accesses.Where(access => access.RoomNumber == r.Number).ToList();
            }
        }
    }
}
