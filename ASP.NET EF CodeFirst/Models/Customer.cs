using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_EF_CodeFirst.Models
{
    public class Customer
    {
        public Int64 CustomerID { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Cannot be empty and more than 50 characters.")]
        public string CustomeName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }


}