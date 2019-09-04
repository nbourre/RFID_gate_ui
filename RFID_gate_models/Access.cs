using System;
using System.ComponentModel.DataAnnotations;

namespace RFID_gate_models
{
    class Access
    {
        [Required]
        public Employee employee { get; set; }

        [Required]
        public Room room { get; set; }

        public bool Always { get; set; } = true;

        private DateTime _begin;

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }
    }
}
