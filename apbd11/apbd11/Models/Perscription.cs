using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd11.Models
{
    public class Perscription
    {


        public int IdPerscription { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }



        public int IdPatient { get; set; }



        public virtual Patient Patient { get; set;}

       
    }
}
