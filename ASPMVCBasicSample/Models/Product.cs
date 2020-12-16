using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVCBasicSample.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "product name can't emtry!")]
        [Display(Name ="Product Name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        [Display(Name="Category")]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual Category Category { get; set; }
    }
}