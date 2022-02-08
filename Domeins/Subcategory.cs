using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Domeins
{
    public class Subcategory
    {
        public int id { get; set; }
        [Display(Name = "Идентификатор категории")]
        public int idCategory { get; set; }
        [Display(Name = "Название")]
        public string name { get; set; }
    }
}
