using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public int Quantity { get; set; }
        public string PaymentMethod { get; set; }
        [Required]
        public int AccountID { get; set; }
        [Required]
        public int MedicineID { get; set; }
        [Required]
        public int Medi_Equip_ID { get; set; }
    }
}
