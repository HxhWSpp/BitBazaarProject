using Microsoft.AspNetCore.Hosting;
using System.Net;

namespace AppsApi.Utils
{
    public static class Helper
    {

        public static IWebHostEnvironment _hostingEnvironment;
        public static bool IsInitialized { get; private set; }
        public static void Initialize(IWebHostEnvironment hostEnvironment)
        {
            if (IsInitialized == true)
            {
                throw new InvalidOperationException("Object already initialized");
            }              

            _hostingEnvironment = hostEnvironment;
            IsInitialized = true;
        }
        public static async Task<string> UploadImageLocally(IFormFile image , string dir , IHttpContextAccessor _httpContextAccessor)
        {
            try
            {
                var address = _httpContextAccessor.HttpContext.Request;
                string Filepath = Path.Combine(_hostingEnvironment.WebRootPath, dir);

                if (!System.IO.Directory.Exists(Filepath))
                {
                    System.IO.Directory.CreateDirectory(Filepath);
                }
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string imagePath = Path.Combine(Filepath, uniqueFileName);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                return $"{address.Scheme}://{address.Host}/{dir}/{uniqueFileName}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static async Task<List<string>> UploadMultipleImagesLocally(ICollection<IFormFile> images, string dir, IHttpContextAccessor _httpContextAccessor)
        {
            try
            {
                var address = _httpContextAccessor.HttpContext.Request;
                List<string> imagePaths = new List<string>();
                string Filepath = Path.Combine(_hostingEnvironment.WebRootPath, dir);

                if (!System.IO.Directory.Exists(Filepath))
                {
                    System.IO.Directory.CreateDirectory(Filepath);
                }

                foreach (var image in images)
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string imagePath = Path.Combine(Filepath, uniqueFileName);
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }

                    using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }

                    imagePaths.Add($"{address.Scheme}://{address.Host}/{dir}/{uniqueFileName}");
                }
                return imagePaths;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static bool DeleteImageLocally(string path , string dir)
        {
            string Filepath = Path.Combine(_hostingEnvironment.WebRootPath, dir , path);
            if (System.IO.File.Exists(Filepath))
            {
                System.IO.File.Delete(Filepath);
                return true;
            }
            return false;
        }

        public static bool DeleteMultipleImagesLocally(ICollection<string> paths , string dir)
        {
                 
            foreach (var path in paths)
            {
                string Filepath = Path.Combine(_hostingEnvironment.WebRootPath, dir, path);
                if (System.IO.File.Exists(Filepath))
                {
                    System.IO.File.Delete(Filepath);                   
                }
            }
            return true;
            
        }
       
    }
}
