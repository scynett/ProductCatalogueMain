using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductCatalogue.Common.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        public Product CreateProduct()
        {
            return new Product
            {
                ProductName = ProductName,
                UnitPrice = UnitPrice,
                Category = Category,
                Description = Description,
                Image = Image
            };
        }
    }
}