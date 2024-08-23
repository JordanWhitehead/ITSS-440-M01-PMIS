using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class StakeholderData
    {
        [Key]
        public int StakeholderID { get; set; }
        //[Foreign Key Assignment]
        //public int Stakeholder_ProjectId_FK { get; set; }
        //Will this have to be a join table or can we work around that?
        public string? StakeholderName { get; set; }
        public string? StakeholderTitle{ get; set; }
        public string? StakeholderRole { get; set; }
        public string? StakeholderDescription { get; set; }
    }
}
