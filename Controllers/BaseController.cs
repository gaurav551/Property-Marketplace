using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Nepalists.Controllers
{
    public class BaseController : Controller
    {
        public string UploadFile(IFormFile file){
            var fileName = Guid.NewGuid().ToString()+file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/placeimages",fileName);

            using(var fileStream = new FileStream(path,FileMode.Create)){
                file.CopyTo(fileStream);
            }

            return fileName;
        }
        public string UploadFile2(IFormFile file){
            var fileName = Guid.NewGuid().ToString()+file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/userimages",fileName);

            using(var fileStream = new FileStream(path,FileMode.Create)){
                file.CopyTo(fileStream);
            }

            return fileName;
        }

        public string GetUserId(UserManager<IdentityUser> userManager){
            return userManager.GetUserId(HttpContext.User);
        }
         public string GetUserName(UserManager<IdentityUser> userManager){
            return userManager.GetUserName(HttpContext.User);
        }
      
    }
    
}