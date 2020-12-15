using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Seminar
    {
        [Key]
        public int SeminarID { get; set; }
        public string SeminarTopic { get; set; }
        public string Staff { get; set; }
        public DateTime SeminarDate { get; set; }
        public string SeminarMaterials { get; set; }
        public string SeminarDescription { get; set; }
        public string NumOfParticipants { get; set; }
        public string Staff_Info { get; set; }
        public bool SeminarLock { get; set; }

    }
}
