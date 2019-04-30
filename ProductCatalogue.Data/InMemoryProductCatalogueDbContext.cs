using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Api;
using ProductCatalogue.Common;
using System;
using System.Collections.Generic;

namespace ProductCatalogue.Data
{
    public class InMemoryProductCatalogueDbContext
    {
        private static List<Product> _productsList;

        public InMemoryProductCatalogueDbContext()
        {
        }

        public List<Product> Add(Product product)
        {
            _productsList.Add(product);

            return _productsList;
        }

        public List<Product> Delete(Product product)
        {
            _productsList.Remove(product);
            return _productsList;
        }

        public void Update(Product product)
        {
            var Product = new Product
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Category = product.Category,
                UnitPrice = product.UnitPrice,
                Description = product.Description,
                Image = product.Image
            };
        }

        public List<Product> ProductsList
        {
            get
            {
                if (_productsList == null)
                {
                    _productsList = new List<Product>
                    {
                        new Product
                        {
                               Id = 1,
                        ProductName = "ProductA",
                        Category = "A",
                        Description = "This is test A",
                        UnitPrice = 5.5,
                        Image="./Images/Capture.PNG"
                 },

                 new Product
                 {
                     Id = 2,
                     ProductName = "ProductB",
                     Category = "B",
                     Description = "This is test B",
                     UnitPrice = 5.2,
                     Image="./Images/Capture.PNG"
                 },
                  new Product
                  {
                      Id = 3,
                      ProductName = "ProductC",
                      Category = "C",
                      Description = "This is test C",
                      UnitPrice = 2.6,
                      Image="./Images/Capture.PNG"
                  },
                   new Product
                   {
                       Id = 4,
                       ProductName = "ProductD",
                       Category = "D",
                       Description = "This is test D",
                       UnitPrice = 23,
                       Image="./Images/Capture.PNG"
                   }
                };
                    return _productsList;
                }
                return _productsList;
            }
        }
    }
}