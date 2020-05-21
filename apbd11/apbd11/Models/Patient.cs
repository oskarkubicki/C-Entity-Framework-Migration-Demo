using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd11.Models
{
    public class Patient
    {


        public Patient()
        {
            Perscriptions = new HashSet<Perscription>();
        }
        public int IdPatient { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }


        public virtual ICollection<Perscription> Perscriptions { get; set; }
    }
}
