using System.Collections.Generic;

namespace RFID_gate_ui.Data
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
