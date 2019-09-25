using System.Collections.Generic;
using RFID_gate_models;

namespace RFID_gate_ui.Data
{
    class RoomDataService : IDataService<Room>
    {
        static List<Room> Rooms = new List<Room>()
        {
            new Room { Number = "1133", Description = "Labo Apple" },
            new Room { Number = "1134", Description = "Commun" },
            new Room { Number = "1133A", Description = "Labo Linux" },
            new Room { Number = "1135", Description = "Windows" },
            new Room { Number = "1139", Description = "Classe sèche" },
        };

        public IEnumerable<Room> GetAll()
        {
            foreach (Room r in Rooms)
            {
                yield return r;
            }
        }
    }
}
