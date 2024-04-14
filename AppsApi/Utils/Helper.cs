using AppsApi.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

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



        public static async Task<List<Claim>> GetClaims(User user , UserManager<User> _userManager)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Sid , user.Id),
                new Claim(ClaimTypes.Uri , user.ProfilePicture)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
                
            }
            return claims;
        }

        public static SigningCredentials GetSigningCredentials(IConfigurationSection _jwtSettings)
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public static JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims , IConfigurationSection _jwtSettings)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings.GetSection("validIssuer").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection("expiryInMinutes").Value)),
                signingCredentials: signingCredentials
                );
            return tokenOptions;
        }


        public static async Task<string> GetUserIdFromJwtToken(StringValues header)
        {
            var token = header.ToString().Replace("Bearer " , "");                      
            var sid = new JwtSecurityTokenHandler().ReadJwtToken(token).Claims.Where(c => c.Type == ClaimTypes.Sid).FirstOrDefault();

            Console.ForegroundColor = ConsoleColor.Red;


            await Console.Out.WriteLineAsync($"{sid.Value}");
            Console.ResetColor();
            return sid.Value;
        }

    }
}
