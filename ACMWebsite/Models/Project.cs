using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ACMWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string ProjectName { get; set; }
        public string Creator { get; set; }
        
        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        public DateTime PostedDate { get; set; }
        public string Description { get; set; }
        
    }
}
