using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Display(Name = "First Name")] 
        public String FirstName { get; set; }

        [Display(Name = "Last Name")] 
        public String LastName { get; set; }


        public ICollection<Assignment> Assignment { get; set; }
    }
}
