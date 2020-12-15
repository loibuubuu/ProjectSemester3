using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Categories
    {
        [Key]
        public int CategoriesID { get; set; }
        [Required]
        public string CategoriesName { get; set; }
        public string CategoriesDescription { get; set; }
    }
}
