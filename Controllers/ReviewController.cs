using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;

using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nepalists.Models;
using Nepalists.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
namespace Nepalists.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;
     private readonly UserManager<IdentityUser> _userManager;



        public ReviewController(ApplicationDbContext context, UserManager<IdentityUser> userManager)

        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult AddReview(string Text, int ListId)
        {
            Review r = new Review();
            var username = _userManager.GetUserName(HttpContext.User);
            r.UserName = username;
            r.Text = Text;
            var data = _context.Profiles.FirstOrDefault(x=>x.UserName.Equals(username));
            r.FullName = data.FullName;
            r.Image =  data.ImageUrl;
            r.ListId = ListId;
           _context.Reviews.Add(r);
           _context.SaveChanges();
          return RedirectToAction ("Description", "Listing", new {id = ListId});
       
        }
        [Route("api/[controller]")]

        public IActionResult Remove(int id, int listid)
        {
           var user = _userManager.GetUserName(HttpContext.User);
          
           
              var a = _context.Reviews.FirstOrDefault(x=>x.Id==id);
               
           if (a.UserName.Equals(user))
           {
              _context.Reviews.Remove(a);
              _context.SaveChanges();
              return RedirectToAction("Description", "Listing", new{id = listid});
           }
           else
           {
               return NoContent();
           }
           
        }
    }
}