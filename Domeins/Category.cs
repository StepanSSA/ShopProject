using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Domeins
{
    public class Category
    {
        public int id { get; set; }
        [Display(Name = "название")]
        public string name { get; set; }
    }
}
