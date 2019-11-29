using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nepalists.Models;
using Nepalists.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Nepalists.Repository;

namespace Nepalists.Controllers
{
    [Authorize]
    public class ProfileController : BaseController
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IFollowerRepository _followerRepository;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        //private string userId;

        public ProfileController(
        IProfileRepository profileRepository,
        UserManager<IdentityUser> userManager,
        ApplicationDbContext context,
        IFollowerRepository followerRepository)
        {
            _profileRepository = profileRepository;
            _followerRepository = followerRepository;
            _userManager = userManager;
            _context = context;

        }
        // public ProfileController(string deps = GetUserName(_userManager))
        // {
        //       userId = deps;
        // }
        // public class AppUser()
        // {
        //     return GetUserName(_userManager);
        // }

        // public string ae = GetUserName(_userManager);

        public IActionResult Index()
        {
            // var profile = _profileRepository.GetAll().OrderByDescending(x=>x.Id);
            var user = GetUserName(_userManager);
            var profile = _profileRepository.GetSingle(x => x.UserName.Equals(user));

            var listing = _context.Listings.Where(x => x.PostedBy.Equals(user)).ToList();
            ViewBag.count = listing.Count;
            // ViewBag.Listings = listing;
            var id = GetUserId(_userManager);
            var followers = _followerRepository.GetBy(x => x.FollowId.Equals(id));
            var following = _followerRepository.GetBy(x => x.UserId.Equals(id));
            ViewBag.c = followers.Count();
            ViewBag.c1 = following.Count();



            return View(profile);
        }


        // public ViewResult Detail(int id)
        // {
        //     return View(_profileRepository.GetSingle(x => x.Id == id));
        // }
        public IActionResult Edit(int id)
        {
            return View(_profileRepository.GetSingle(x => x.Id == id));
        }

        public IActionResult Create(Profile profile, IFormFile file)
        {
            profile.UserName = GetUserName(_userManager);

            profile.UserId = GetUserId(_userManager);

            profile.ImageUrl = UploadFile2(file);


            var s = _profileRepository.CheckIfExists(x => x.UserName.Equals(profile.UserName));
            if (!s)
            {
                _profileRepository.Create(profile);

            }
            else
            {
                return Content("You Have Already Created Your Profile");
            }
            return RedirectToAction(nameof(Index));

        }



        public IActionResult New()
        {

            return View();
        }
        public IActionResult Delete(int id)
        {
            _profileRepository.Remove(x => x.Id == id);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Update(Profile profile, IFormFile file)
        {
            profile.UserName = GetUserName(_userManager);

            profile.UserId = GetUserId(_userManager);

            profile.ImageUrl = UploadFile2(file);

            _profileRepository.Update(profile);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult NewProfile()
        {
            return View();
        }

        public IActionResult FindProfiles(string search)
        {
            List<Profile> profile = new List<Profile>();

            if (string.IsNullOrEmpty(search))
            {
                profile = _profileRepository.GetAll();
            }
            else
            {
                profile = _profileRepository.GetBy(x => x.FullName.Contains(search));
            }




            return View(profile);
        }
        // public IActionResult SearchProfiles(string search)
        // {
        //     return View(_profileRepository.GetBy(x => x.FullName.Contains(search)));
        // }

        public IActionResult UserProfile(string id)
        {

            var s = _profileRepository.GetSingle(x => x.UserId.Equals(id));
            ViewBag.c = _followerRepository.GetBy(x => x.FollowId.Equals(id)).Count();
            var following = _followerRepository.GetBy(x => x.UserId.Equals(id));
            var k = GetUserId(_userManager);

            ViewBag.c1 = following.Count();

            var check = _followerRepository.CheckIfExists(x => x.UserId.Equals(k) && x.FollowId.Equals(id));
            if (check)
            {
                TempData["c"] = "Following";
            }
            else
            {
                TempData["c"] = "Follow";
            }
            ViewBag.ListCount = _context.Listings.Where(x => x.UserId.Equals(id)).ToList().Count();

            return View(s);

        }


        public IActionResult Follow(string userid, string username)
        {
            var k = GetUserId(_userManager);
            var follow = new Follower();
            follow.UserId = k;
            follow.UserName = GetUserName(_userManager);
            follow.FollowId = userid;
            follow.FollowName = username;

            var followcount = _profileRepository.GetSingle(x => x.UserId.Equals(userid));
            var followingcount = _profileRepository.GetSingle(x => x.UserId.Equals(k));


            followcount.FollowersCount += 1;



            _profileRepository.Update(followcount);


            var s = _followerRepository.CheckIfExists(x => x.UserId.Equals(k) && x.FollowId.Equals(userid));
            if (s)
            {
                return NoContent();
            }

            _followerRepository.Create(follow);

            return RedirectToAction("UserProfile", "Profile", new { id = userid });


        }
        public IActionResult Unfollow(string name)
        {
            var user = GetUserName(_userManager);
            // var delete = _followerRepository.GetSingle(x=>x.UserName.Equals(user) && x.FollowName.Equals(name));
            _followerRepository.Remove(x => x.UserName.Equals(user) && x.FollowName.Equals(name));
            return RedirectToAction(nameof(Following));
        }
        public IActionResult Followers()
        {
            var user = _followerRepository.GetBy(x => x.FollowId.Equals(_userManager.GetUserId(HttpContext.User)));
            return View(user);
        }
        public IActionResult Following()
        {
            var userid = GetUserId(_userManager);
            return View(_followerRepository.GetBy(x => x.UserId.Equals(userid)));
        }

    }

}

