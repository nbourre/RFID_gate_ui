using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RFID_gate_models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string CardId { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public List<Access> Accesses { get; set; }

    }
}
