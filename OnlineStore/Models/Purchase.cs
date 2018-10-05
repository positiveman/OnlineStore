using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Purchase
    {
        [Key]
        public int ID { get; set; }       
        public int ProductId { get; set; }
        public string CustomerId { get; set; }       
    }
}