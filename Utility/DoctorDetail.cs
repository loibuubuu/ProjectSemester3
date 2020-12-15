using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class DoctorDetail
    {
        [Key]
        public int DoctorID { get; set; }
        public string DrQualification { get; set; }
        public string Specialist { get; set; }
        public string DrDescription { get; set; }
        public string DrPosition { get; set; }

        public string DrExperiences { get; set; }
        public string DrImage { get; set; }
        [Required]
        public int AccountID { get; set; }
        public bool DrLock { get; set; }
    }
}
