using ShopProject.Domeins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Abstract
{
    public interface ICRUDShopRepository : IShopRepository
    {
        public void Delete(Product product);
        public void Delete(Characteristic characteristic);
        public void Delete(Category category);
        public void Delete(Subcategory subcategory);

        public void Update(Product product);
        public void Update(Characteristic characteristic);
        public void Update(Category category);
        public void Update(Subcategory subcategory);
    }               
}
