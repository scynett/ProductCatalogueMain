using ProductCatalogue.Api;
using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace ProductCatalogue.Common
{
    public class Product
    {
        //id, Describtion, productName, Category UnitPrice, Image
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Product Edit(Product editedProduct)
        {
            Category = editedProduct.Category;
            Description = editedProduct.Description;
            ProductName = editedProduct.ProductName;
            UnitPrice = editedProduct.UnitPrice;
            Image = editedProduct.Image;
            return this;
        }
    }
}