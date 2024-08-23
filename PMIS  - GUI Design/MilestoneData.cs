using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class MilestoneData
    {
        [Key]
        public int MilestoneId { get; set; }
        //[Foreign Key Assignment]
        public int Milestone_ProjectId_FK { get; set; }
        public string? MilestoneName { get; set; }
        public string? MilestoneDate { get; set; }
    }
}
