using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project20232.Server.IRepository;
using Project202322.Shared.Domain;
using System.Collections.Generic;
using ProjectTestApp2.Data;
using System.Linq;

namespace ProjectTestApp2.Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _db;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public IEnumerable<Product> SearchProductsByName(string name)
        {
            return _context.Products.Where(p => p.Name.Contains(name)).ToList();
        }

        public IEnumerable<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            return _context.Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }
    }
}