using AweBlazor.Service;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task UploadAsync(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_webHostEnvironment.ContentRootPath, "Upload", fileEntry.Name);
            var memoryStream = new MemoryStream();
            await fileEntry.Data.CopyToAsync(memoryStream);
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}