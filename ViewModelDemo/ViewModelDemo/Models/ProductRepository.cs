using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelDemo.Models
{
    public class ProductRepository
    {
        private viewmodeldemoEntities context = new viewmodeldemoEntities();

        public IQueryable<Product> GetAllProducts()
        {
            return context.Products;
        }

        public IQueryable<Category> GetAllCategories()
        {
            return context.Categories;
        }

        public Product GetProductByID(int target)
        {
            return context.Products.SingleOrDefault(p => p.productID == target);
        }

        public void AddProduct(Product product)
        {
            context.Products.AddObject(product);
            context.SaveChanges();
        }
    }
}