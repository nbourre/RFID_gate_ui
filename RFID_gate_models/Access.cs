using System;
using System.ComponentModel.DataAnnotations;

namespace RFID_gate_models
{
    public class Access
    {
        [Required]
        public String CardId { get; set; }

        [Required]
        public String RoomNumber { get; set; }

        public bool Always { get; set; } = true;

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }
    }
}
