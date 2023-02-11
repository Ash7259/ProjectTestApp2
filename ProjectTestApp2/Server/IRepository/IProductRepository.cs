using Project202322.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project20232.Server.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Task<Product> GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Product> SearchProductsByName(string name);
        IEnumerable<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice);
    }
}