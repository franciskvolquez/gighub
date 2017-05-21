using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class ArtistsController : Controller
    {
        private ApplicationDbContext _context;

        public ArtistsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Artists
        public ActionResult Following()
        {

            var userId = User.Identity.GetUserId();

            var followees = _context.Followings
                .Where(f => f.FollowerId == userId)
                .Include(f => f.Followee)
                .Select(f => f.Followee)
                .ToList();


            return View(followees);
        }
    }
}