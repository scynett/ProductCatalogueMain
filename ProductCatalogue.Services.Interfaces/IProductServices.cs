using ProductCatalogue.Common;
using System;
using System.Collections.Generic;

namespace ProductCatalogue.Services.Interfaces
{
    public interface IProductServices
    {
        OperationResult AddProduct(Product product);

        OperationResult<Product> GetProduct(int id);

        OperationResult DeleteProduct(int id);

        OperationResult UpdateProduct(Product product);

        OperationResult<IList<Product>> GetProducts();
    }
}