using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utility
{
    public class Accounts
    {
        [Key]
        public int AccountID { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
        public string Phone { get; set; }
        public DateTime DoB { get; set; }
        public string AccountHistory { get; set; }
        [Required]
        public bool AccountLock { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string Image { get; set; }
    }
}
