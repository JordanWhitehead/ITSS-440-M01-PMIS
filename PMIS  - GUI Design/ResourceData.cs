using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class ResourceData
    {
        [Key]
        public int ResourceId { get; set; }
        public string? ResourceName { get; set; }
        public string? ResourceDescription { get; set; }
    }
}
