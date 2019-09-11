using RFID_gate_models;
using System;
using System.Collections.Generic;


namespace RFID_gate_ui.Data
{
    class AccessDataService : IDataService<Access>
    {
        List<Access> Accesses = new List<Access>();
        private List<Employee> _employees;
        private List<Room> _rooms;
        Random random = new Random();

        AccessDataService(List<Employee> employees, List<Room> rooms)
        {
            _employees = employees;
            _rooms = rooms;
        }


        public IEnumerable<Access> GetAll()
        {
            if (_employees == null || _rooms == null)
            {
                throw new System.ArgumentNullException();
            }

            Accesses.Clear();

            int nbEmployees = _employees.Count;
            int nbRooms = _rooms.Count;

            // Générer de 2 à 5 accès aléatoires par employé
            for (int i = 0; i < nbEmployees; i++)
            {
                int nbAccess = random.Next(2, 5);
                for (int j = 0; j < nbAccess; j++)
                {
                    Access temp = new Access
                    {
                        Employee = _employees[i],
                        Room = _rooms[random.Next(0, nbRooms)],
                        Begin = DateTime.Now.AddHours(random.Next(-4, 0)),
                        End = DateTime.Now.AddHours(random.Next(0, 4))                        
                    };

                    Accesses.Add(temp);
                }
            }

            return Accesses;
        }
    }
}
