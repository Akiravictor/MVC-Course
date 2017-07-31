using AkiraMovies.Models;
using AkiraMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkiraMovies.Controllers
{
	public class MoviesController : Controller
	{
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movie/Random
        public ActionResult Random()
		{
			var movie = new MovieModels() { Name = "Star Wars" };
			var customers = new List<CustomerModels>
			{
				new CustomerModels {Name = "Akira"},
				new CustomerModels {Name = "Vig"}
			};

			var viewModel = new RandomMovieViewModel()
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
		}

		public ActionResult Edit(int id)
		{
			return Content("id= " + id);
		}

		public ActionResult Index(int? pageIndex, string sortBy)
		{
            var movies = _context.Movies.ToList();

			return View(movies);
		}

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.FirstOrDefault(a => a.Id == id);

            return View(movie);
        }

		[Route(@"movie/released/{year:regex(\d{4})}/{month:regex(\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
	}
}