using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Medicines
    {
        [Key]
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string MedicineSKU { get; set; }
        public string MedicineStatus { get; set; }
        public string MedicineTag { get; set; }
        public string MedicineDescription { get; set; }
        public double MedicinePrice { get; set; }
        public string MedicineImage { get; set; }
        public bool MedicineLock { get; set; }
        public DateTime MedicineExpiryDate { get; set; }
        [Required]

        public int CategoryChild_ID { get; set; }
    }
}
