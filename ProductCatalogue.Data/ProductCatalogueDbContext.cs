using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogue.Data
{
    public class ProductCatalogueDbContext : DbContext
    {
        public ProductCatalogueDbContext(DbContextOptions<ProductCatalogueDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}