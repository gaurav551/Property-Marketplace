using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nepalists.Models;
using Nepalists.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


namespace Nepalists.Controllers
{
  // [Route("api/[controller]")]

    public class ListingController : BaseController

    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;


        public ListingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)

        {
            _userManager = userManager;
            _context = context;
        }
        public ViewResult Index(string search)
        {
            var s = _context.Listings.ToList();
            var hello = from l in _context.Listings
                        join p in _context.Profiles on l.PostedBy equals p.UserName
                        select new ListsModel
                        {
                            Id = l.Id,
                            Photo = p.ImageUrl,
                            Location = l.Location,
                            User = l.PostedBy,
                            UserId = p.UserId,
                            Title = l.Title,
                            Images = l.Images,
                            Description = l.Description
                        };

            if (string.IsNullOrEmpty(search))
            {
                ViewBag.Lists = hello;
            }
            else
            {
                ViewBag.Lists = hello.Where(x => x.Title.Contains(search) || x.Description.Contains(search));
            }

            var check = _context.Profiles.Any(x => x.UserId.Equals(GetUserId(_userManager)));

            if (!check)
            {
                ViewBag.c = "please create your profile";
            }
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
        public IActionResult UPlace(string category)
        {
            var check = _context.Profiles.Any(x => x.UserId.Equals(GetUserId(_userManager)));

            if (!check)
            {
                ViewBag.c = "please create your profile";
            }
            ViewBag.Cat = category;

            return View();
        }
        [HttpPost("Listing")]
        public async Task<IActionResult> UploadPlace(Listing p, IFormFile file)
        {
            p.Images = UploadFile(file);
            p.PostedBy = GetUserName(_userManager);
            p.UserId = GetUserId(_userManager);
            if (_context.Profiles.Any(x => x.UserId.Equals(p.UserId)))
            {
                var listcount = _context.Profiles.FirstOrDefault
                (x => x.UserId.Equals(p.UserId));
                listcount.Listing += 1;
                _context.Profiles.Update(listcount);
            }
            _context.Listings.Add(p);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
       // [HttpGet("{id}")]
        public IActionResult Description(int id)
        {
            var description = _context.Listings.FirstOrDefault(x => x.Id == id);
            var image = _context.Profiles.FirstOrDefault(x => x.UserId.Equals(description.UserId));
            ViewBag.Image = image.ImageUrl;
            ViewBag.reviews = _context.Reviews.Where(x => x.ListId == id).ToList();
            return Ok(description);
        }
        public IActionResult SaveListing(int id)
        {
            var s = new Saved();
            s.ListId = id;
            var user = GetUserName(_userManager);
            s.UserName = user;

            if (_context.Saves.Any(x => x.ListId == id && x.UserName.Equals(user)))
            {
                ViewData["c"] = "Saved";
                return NoContent();

            }

            else
            {
                ViewData["c"] = "Save";
            }

            _context.Saves.Add(s);
            _context.SaveChanges();
            return RedirectToAction(nameof(Description), new { id = id });


        }
        public IActionResult MySaves()
        {
            var user = GetUserName(_userManager);
            // var lists = _context.Saves.Where(x=>x.UserName.Equals(user)).ToList();
            var li = from l in _context.Listings
                     join s in _context.Saves on l.Id equals s.ListId
                     select new ListsModel
                     {
                         Id = l.Id,
                         Photo = l.Images,
                         Location = l.Location,

                         User = s.UserName,
                         Title = l.Title
                     };
            var list = li.Where(x => x.User.Equals(user)).ToList();
            ViewBag.List = list;
            return View();
        }

        public IActionResult MyListings()
        {
            var user = GetUserName(_userManager);
            var lists = _context.Listings.Where(x => x.PostedBy.Equals(user)).ToList();
            return View(lists);

        }
        public IActionResult Edit(int id)
        {

            return View(_context.Listings.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update(Listing L, IFormFile file)
        {

            L.Images = UploadFile(file);
            L.PostedBy = GetUserName(_userManager);
            L.UserId = GetUserId(_userManager);
            _context.Listings.Update(L);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyListings));


        }
        public IActionResult Delete(int id)
        {
            var delete = _context.Listings.FirstOrDefault(x => x.Id == id);
            _context.Listings.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction(nameof(MyListings));
        }
        // public IActionResult SearchListings (string search)
        // {
        //     return View(_context.Listings.Where(x=>x.Title.Contains(search) || x.Description.Contains(search)).ToList());
        // }

        public IActionResult Help()
        {
            return View();
        }
    }
}

