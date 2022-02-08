using ShopProject.Abstract;
using ShopProject.Domeins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Data
{
    public class MsSqlCRUDShopRepository : ICRUDShopRepository
    {
        public IQueryable<Product> Products => _context.Products;

        public IQueryable<Category> Categories => _context.Categories;

        public IQueryable<Subcategory> Subcategories => _context.Subcategories;

        public IQueryable<Characteristic> Characteristics => _context.Characteristics;

        private readonly ApplicationDbContext _context;

        public MsSqlCRUDShopRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Delete(Characteristic characteristic)
        {
            _context.Characteristics.Remove(characteristic);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void Delete(Subcategory subcategory)
        {
            _context.Subcategories.Remove(subcategory);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public void Update(Characteristic characteristic)
        {
            _context.Update(characteristic);
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public void Update(Subcategory subcategory)
        {
            _context.Update(subcategory);
            _context.SaveChanges();
        }
    }
}
