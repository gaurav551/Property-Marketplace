using System;
using System.IO;
using System.Threading.Tasks;
using Nepalists.Controllers;
using System.Net.Http.Headers;

using Nepalists.Models;
using Nepalists.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Nepalists.Controllers
{
    public class BaseController : Controller
    {

        // public async void UploadFile(string images)
        // {
        //      var files = HttpContext.Request.Form.Files;
        //     foreach (var Image in files)
        //     {
        //         if (Image != null && Image.Length > 0)
        //         {

        //             var file = Image;
        //             var uploads = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/placeimages");

        //             if (file.Length > 0)
        //             {
        //                 var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

        //                 System.Console.WriteLine(fileName);
        //                 using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
        //                 {
        //                     await file.CopyToAsync(fileStream);
        //                     images = file.FileName;
                           

        //                 }


        //             }
        //         }
        //     }
        // }

      

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