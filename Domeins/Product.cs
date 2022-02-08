using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Domeins
{
    public class Product
    {
        public int id { get; set; }
        [Display(Name = "Идентификатор подкатегории")]
        public int idSubcategory { get; set; }
        [Display(Name = "Идентификатор характеристик")]
        public int idCharacteristics { get; set; }
        [Display(Name = "Производитель")]
        public string manufacturer { get; set; }
        [Display(Name = "Модель")]
        public string model { get; set; }
        [Display(Name = "Описание")]
        public string description { get; set; }
        [Display(Name = "Цена")]
        public int price { get; set; }
        [Display(Name = "Картинка")]
        public string image { get; set; }
        [Display(Name = "Количество")]
        public int count { get; set; }
    }
}
