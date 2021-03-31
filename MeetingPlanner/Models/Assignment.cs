using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public enum AssignmentType
    {
        Talk, Song, Blessing, Announcement, Other
    }

    public class Assignment
    {
        public int ID { get; set; }

        [Display(Name = "Meeting")]
        public int MeetingID { get; set; }

        public int PersonID { get; set; }

        [Display(Name = "Assignment Type")]
        public AssignmentType Type{ get; set; }
        public String Title { get; set; }

        [Display(Name = "Additional Information")]
        public String AddInfo { get; set; }

        [Display(Name = "Program Order")]
        public short ShowOrder { get; set; }

        public Meeting Meeting { get; set; }
        public Person Person { get; set; }
    }
}
