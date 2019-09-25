using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RFID_gate_models
{
    public class Room
    {
        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public string FullDescription
        {
            get
            {
                return Number + " : " + Description;
            }
        }

        public List<Access> Accesses { get; set; }
    }
}
