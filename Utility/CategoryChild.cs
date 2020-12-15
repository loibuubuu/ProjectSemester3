using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class CategoryChild
    {
        [Key]
        public int CategoryChild_ID { get; set; }
        public string CateChild_Name { get; set; }
        public string CateChild_Description { get; set; }
        [Required]
        public int CategoriesID { get; set; }
    }
}
