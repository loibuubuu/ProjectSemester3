using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class MedicalEquipments
    {
        [Key]
        public int Medi_Equip_ID { get; set; }
        public string EquipName { get; set; }
        public string EquipSKU { get; set; }
        public string EquipStatus { get; set; }
        public string EquipTag { get; set; }
        public string EquipDescription { get; set; }
        public double EquipPrice { get; set; }
        public string EquipImage { get; set; }
        public bool EquipLock { get; set; }
        [Required]

        public int CategoryChild_ID { get; set; }
    }
}
