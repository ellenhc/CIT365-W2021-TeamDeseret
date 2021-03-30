using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public String Presiding { get; set; }
        public String Conducting { get; set; }

        [Display(Name = "Opening Hymn")]
        public String OpenHymnTitle { get; set; }

        [Display(Name = "Page Number")]
        public short OpenHymnNum { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public String SacramentHymnTitle { get; set; }

        [Display(Name = "Page Number")]
        public short SacramentHymnNum { get; set; }

        [Display(Name = "Closing Hymn")]
        public String ClosingHymnTitle { get; set; }

        [Display(Name = "Page Number")]
        public short ClosingHymnNum { get; set; }

        [Display(Name = "Invocation")]
        public String OpeningPrayer { get; set; }

        [Display(Name = "Benediction")]
        public String ClosingPrayer { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
