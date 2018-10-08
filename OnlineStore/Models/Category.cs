using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace OnlineStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }


}