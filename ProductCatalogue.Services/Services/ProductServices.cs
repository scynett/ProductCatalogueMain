using Microsoft.Extensions.Hosting;
using ProductCatalogue.Api;
using ProductCatalogue.Common;
using ProductCatalogue.Data;
using ProductCatalogue.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalogue.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ProductCatalogueDbContext _context;

        public ProductServices(ProductCatalogueDbContext context)
        {
            _context = context;
        }

        public OperationResult<IList<Product>> GetProducts()
        {
            var products = _context.Products.ToList();
            if (products == null) return new OperationResult<IList<Product>>(false, "Stock is empty", null);

            return new OperationResult<IList<Product>>(true, "Product Fetched successfully", products);
        }

        public OperationResult AddProduct(Product product)
        {
            if (product == null) return new OperationResult(false, "Product can't be null");

            _context.Products.Add(product);
            _context.SaveChanges();

            return new OperationResult(true, "Product added Successfully");
        }

        public OperationResult<Product> GetProduct(int id)
        {
            Product product = _context.Products.FirstOrDefault(e => e.Id == id);
            if (product == null) return new OperationResult<Product>(false, "Product Id can not be found", product);
            return new OperationResult<Product>(true, "fetch operation successfull", product);
        }

        public OperationResult DeleteProduct(int id)
        {
            Product product = _context.Products.FirstOrDefault(e => e.Id == id);
            if (product == null) return new OperationResult(false, "Product can't be null");

            _context.Remove(product);
            _context.SaveChanges();
            return new OperationResult(true, "Product added Successfully");
        }

        public OperationResult UpdateProduct(Product editedProduct)
        {
            Product originalProduct = _context.Products.FirstOrDefault(e => e.Id == editedProduct.Id);

            if (originalProduct == null)
            {
                return new OperationResult(false, "Product can't be null");
            }

            _context.Update(originalProduct.Edit(editedProduct));
            _context.SaveChanges();
            return new OperationResult(true, "Product Updated successfully");
        }
    }
}