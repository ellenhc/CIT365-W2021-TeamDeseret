using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Talk
    {
        public int Id { get; set; }
        public String Topic { get; set; }
        public String SpeakerName { get; set; }
        public short SpeakingOrder { get; set; }
        [ForeignKey("Meeting")]
        public int MeetingFK { get; set; }
    }
}
