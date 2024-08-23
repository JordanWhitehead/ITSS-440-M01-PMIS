using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class Resource_Task_Join
    {
        [Key]
        public int R_T_JoinID { get; set; }
        public int ResourceID_FK { get; set; }
        public int TaskID_FK { get; set; }
    }
}
