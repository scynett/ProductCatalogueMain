using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogue.Common;
using ProductCatalogue.Common.Dtos;
using ProductCatalogue.Services;
using ProductCatalogue.Services.Interfaces;

namespace ProductCatalogue.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [Route("AddProduct")]
        [HttpPost]
        public ActionResult AddProduct([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = _productServices.AddProduct(productDto.CreateProduct());
                if (result.IsSuccessfull)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("GetProducts")]
        [HttpGet]
        public ActionResult GetProducts()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = _productServices.GetProducts();
                if (result.IsSuccessfull)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetProductById/{id}")]
        public ActionResult GetProductById(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = _productServices.GetProduct(id);
                if (result.IsSuccessfull)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = _productServices.DeleteProduct(id);
                if (result.IsSuccessfull)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public ActionResult UpdateProduct([FromBody]ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = _productServices.UpdateProduct(productDto.CreateProduct());
                if (result.IsSuccessfull)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}