using RFID_gate_models;
using RFID_gate_ui.Data;
using System.Collections.ObjectModel;

namespace RFID_gate_ui.VM
{
    class RoomViewModel : BaseViewModel
    {
        private IDataService<Room> roomDataService;
        public ObservableCollection<Room> Rooms { get; set; }
        private Room _selectedRoom;

        public Room SelectedRoom
        {
            get
            {
                return _selectedRoom;
            }
            set
            {
                _selectedRoom = value;
                OnPropertyChanged();
            }
        }

        public RoomViewModel()
        {
            Rooms = new ObservableCollection<Room>();
            roomDataService = new RoomDataService();

            Load();
        }

        void Load()
        {
            var rooms = roomDataService.GetAll();
            Rooms.Clear();

            foreach (Room r in rooms)
            {
                Rooms.Add(r);
            }
        }
    }
}
