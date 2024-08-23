using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class TaskData
    {
        [Key] 
        public int TaskId { get; set; } 
        //[Foreign Key Assignment]
        public int Task_ProjectId_FK { get; set; } 
        public string? TaskName { get; set; } 
        public string? TaskDescription { get; set; } 
        public string? TaskStartDate { get; set; } 
        public string? TaskEndDate { get; set; }
        public decimal? Completion { get; set; } = 0;
        public int? SequenceID { get; set; } = 0;
    }
}
