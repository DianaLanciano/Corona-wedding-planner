using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CoronaWedding.Services
{
    public static class fileUpload
    {

        [HttpPost]
        public static async Task<string> imageUpload(IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    //var directoryPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
                    // string Path = directoryPath.Combine(directoryPath, "uploadFiles", file.FileName);
                    var rootPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
                    string _path = Path.Combine(rootPath,"wwwroot", "UploadedFiles", file.FileName);
                    using (var stream = System.IO.File.Create(_path))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return file.FileName;
                }
                return null;
            }

            catch
            {
                Console.WriteLine("Upload failed");
                return null;

            }
        }
    }
}

