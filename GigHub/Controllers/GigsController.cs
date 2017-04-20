using GigHub.Models;
using GigHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private IApplicationDbContext _context;

        public GigsController(IApplicationDbContext context)
        {
            _context = context;
        }


        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };


            return View(viewModel);
        }
    }
}