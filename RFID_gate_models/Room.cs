using System.ComponentModel.DataAnnotations;

namespace RFID_gate_models
{
    class Room
    {
        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
