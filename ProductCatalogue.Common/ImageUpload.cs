using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using ProductCatalogue.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogue.Api
{
    public class ImageUpload
    {
        private readonly IHostingEnvironment _Environment;

        public ImageUpload(IHostingEnvironment _environment)
        {
            _Environment = _environment ?? throw new ArgumentNullException(nameof(_environment));
        }

        public void Upload(IFormFile file)
        {
            var uploads = Path.Combine(_Environment.ContentRootPath, "Images");
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                {
                    file.CopyToAsync(fileStream);
                }
            }
        }
    }
}