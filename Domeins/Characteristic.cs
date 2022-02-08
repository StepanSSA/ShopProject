using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Domeins
{
    public class Characteristic
    {
        public int id { get; set; }
        [Display(Name = "Цвет")]
        public string color { get; set; }
        [Display(Name = "Вес")]
        public string weight { get; set; }
        [Display(Name = "Размер")]
        public string size { get; set; }
    }
}
