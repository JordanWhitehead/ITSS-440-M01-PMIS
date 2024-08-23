using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class Project
    {
        //this class is like the schema for the database table "Project"
        [Key]
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; } //required on new projects - validated by conditional statements
        public string? ProjectDescr { get; set; }
        public string? ProjectInitiative { get; set; }
        public string? ProjectManager { get; set; } //required on new projects - validated by conditional statements
        public string? ProjectStart { get; set; }
        public string? ProjectEnd { get; set; }
        public string? ProjectRevEnd { get; set; }
        public decimal? ProjectCompletion { get; set; } = 0;
    }
}
