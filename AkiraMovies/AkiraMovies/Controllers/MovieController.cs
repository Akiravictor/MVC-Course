using AkiraMovies.Models;
using AkiraMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkiraMovies.Controllers
{
	public class MovieController : Controller
	{
		// GET: Movie/Random
		public ActionResult Random()
		{
			var movie = new MovieModels() { Name = "Star Wars" };
			var customers = new List<CustomerModels>
			{
				new CustomerModels {Name = "Akira"},
				new CustomerModels {Name = "Jose"}
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
			if (!pageIndex.HasValue)
			{
				pageIndex = 1;
			}
			if (String.IsNullOrWhiteSpace(sortBy))
			{
				sortBy = "Name";
			}

			return Content(String.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
		}

		[Route(@"movie/released/{year:regex(\d{4})}/{month:regex(\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
	}
}