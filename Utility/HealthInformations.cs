using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class HealthInformations
    {
        [Key]
        public int HealthInfoID { get; set; }
        public string Header { get; set; }
        public string HeathContent { get; set; }
        public string HealthImage { get; set; }

        public string HeathReferences { get; set; }
        public bool InfoLock { get; set; }
    }
}
