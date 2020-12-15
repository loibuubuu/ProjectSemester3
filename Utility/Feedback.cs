using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Feedback
    {
        [Key]
        public int FeedBackID { get; set; }
        public int FeedbackStar { get; set; }
        public string FeedbackContent { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int AccountID { get; set; }
        public bool FeedbackLock { get; set; }
        public int MedicineID { get; set; }
        public int Medi_Equip_ID { get; set; }
    }
}
