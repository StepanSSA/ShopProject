using ShopProject.Domeins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Abstract
{
    public interface IShopRepository
    {
        public IQueryable<Product> Products { get;}
        public IQueryable<Category> Categories { get;}
        public IQueryable<Subcategory> Subcategories { get;}
        public IQueryable<Characteristic> Characteristics { get;}
    }
}
