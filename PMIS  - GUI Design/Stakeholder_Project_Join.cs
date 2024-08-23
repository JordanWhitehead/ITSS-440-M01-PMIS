using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    internal class Stakeholder_Project_Join
    {
        [Key]
        public int S_T_JoinID { get; set; }
        public int StakeholderID_FK { get; set; }
        public int ProjectID_FK { get; set; }
    }
}
