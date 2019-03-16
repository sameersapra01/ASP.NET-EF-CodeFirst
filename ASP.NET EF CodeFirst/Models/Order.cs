using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET_EF_CodeFirst.Models
{
    public enum OrderType
    {
        Online = 'O',
        InStore = 'S',
    }


    public class Order
    {
        
        public Int64 OrderID { get; set; }
        
        [Required]
        [StringLength(1)]
        public String OrderType { get; set; }

        public Int64 CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}