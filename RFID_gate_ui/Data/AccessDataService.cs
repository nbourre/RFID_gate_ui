using RFID_gate_models;
using System;
using System.Collections.Generic;


namespace RFID_gate_ui.Data
{
    class AccessDataService : IDataService<Access>
    {
        static List<Access> Accesses = new List<Access>();
        private List<Employee> _employees;
        private List<Room> _rooms;
        Random random = new Random();

        public AccessDataService(List<Employee> employees, List<Room> rooms)
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

            if (Accesses != null && Accesses.Count > 0) return Accesses;

            int nbEmployees = _employees.Count;
            int nbRooms = _rooms.Count;

            // Générer de 2 à 5 accès aléatoires par employé
            for (int i = 0; i < nbEmployees; i++)
            {
                int nbAccess = random.Next(2, 5);
                for (int j = 0; j < nbAccess; j++)
                {
                    int roomIdx = random.Next(0, nbRooms);

                    Access temp = new Access
                    {
                        CardId = _employees[i].CardId,
                        RoomNumber = _rooms[roomIdx].Number,
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
