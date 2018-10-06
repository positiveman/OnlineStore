using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public Collection<Product> Products { get; set; }
        
    }
}