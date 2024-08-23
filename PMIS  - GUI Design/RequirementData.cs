using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class RequirementData
    {
        [Key]
        public int RequirementId { get; set; }
        //[Foreign Key Assignment]
        public int Requirement_ProjectId_FK { get; set; }
        public string? RequirementName { get; set; }
        public string? RequirementDescr { get; set; }
    }
}
