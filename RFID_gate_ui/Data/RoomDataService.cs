using System.Collections.Generic;
using RFID_gate_models;

namespace RFID_gate_ui.Data
{
    class RoomDataService : IDataService<Room>
    {
        List<Room> Rooms = new List<Room>();

        public IEnumerable<Room> GetAll()
        {
            Rooms.Clear();

            Rooms.Add(new Room { Number = "1133", Description = "Labo Apple" });
            Rooms.Add(new Room { Number = "1134", Description = "Commun" });
            Rooms.Add(new Room { Number = "1133A", Description = "Labo Linux" });
            Rooms.Add(new Room { Number = "1135", Description = "Windows" });
            Rooms.Add(new Room { Number = "1139", Description = "Classe sèche" });

            return Rooms;
        }
    }
}
