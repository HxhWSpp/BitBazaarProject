using Microsoft.AspNetCore.Hosting;

namespace AppsApi.Utils
{
    public class Helper
    {
        public static async Task<string> UploadImageLocally(IFormFile image , IWebHostEnvironment _webHostEnvironment , string dir , IHttpContextAccessor _httpContextAccessor)
        {
            try
            {
                var address = _httpContextAccessor.HttpContext.Request;
                string Filepath = Path.Combine(_webHostEnvironment.WebRootPath, dir);

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

        public static async Task<List<string>> UploadMultipleImagesLocally(ICollection<IFormFile> images, IWebHostEnvironment _webHostEnvironment, string dir)
        {
            try
            {
                List<string> imagePaths = new List<string>();
                string Filepath = Path.Combine(_webHostEnvironment.WebRootPath, dir);

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

                    imagePaths.Add(imagePath);
                }
                

                return imagePaths;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public static bool DeleteImageLocally(string path)
        {
            //C:\Users\Wsupp\source\repos\AppsApi\AppsApi\wwwroot\ImagesForApps\00187fae-0e2f-4552-9202-d6753bf54346_tyrvtfgrsthrfdsgfdf.PNG
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }

        public static bool DeleteMultipleImagesLocally(ICollection<string> paths)
        {
            //C:\Users\Wsupp\source\repos\AppsApi\AppsApi\wwwroot\ImagesForApps\00187fae-0e2f-4552-9202-d6753bf54346_tyrvtfgrsthrfdsgfdf.PNG           
            foreach (var path in paths)
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);                   
                }
            }
            return true;
            
        }
       
    }
}
