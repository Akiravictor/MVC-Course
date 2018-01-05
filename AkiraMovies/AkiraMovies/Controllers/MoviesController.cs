using AkiraMovies.Models;
using AkiraMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
			var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

			if (movie == null)
				return HttpNotFound();

			var viewModel = new MovieFormViewModel(movie)
			{
				Movie = movie,
				Genres = _context.Genres.ToList()
			};

			return View("MovieForm", viewModel);
		}

		public ViewResult New()
		{
			var genres = _context.Genres.ToList();

			var viewModel = new MovieFormViewModel
			{
				Genres = genres
			};

			return View("MovieForm", viewModel);
		}

		public ActionResult Index(int? pageIndex, string sortBy)
		{
			var movies = _context.Movies.Include(m => m.Genre).ToList();

			return View(movies);
		}

		public ActionResult Details(int id)
		{
			var movie = _context.Movies.FirstOrDefault(a => a.Id == id);

			return View(movie);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(MovieModels movie)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new MovieFormViewModel(movie)
				{
					Genres = _context.Genres.ToList()
				};

				return View("Movies");
			}

			if (movie.Id == 0)
			{
				movie.AddedDate = DateTime.Now;
				_context.Movies.Add(movie);
			}
			else
			{
				var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
				movieInDb.Name = movie.Name;
				movieInDb.GenreId = movie.GenreId;
				movieInDb.NumberInStock = movie.NumberInStock;
				movieInDb.ReleaseDate = movie.ReleaseDate;
			}

			_context.SaveChanges();

			return RedirectToAction("Index", "Movies");
		}

		[Route(@"movie/released/{year:regex(\d{4})}/{month:regex(\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
	}
}