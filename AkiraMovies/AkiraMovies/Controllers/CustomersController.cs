using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkiraMovies.Models;

namespace AkiraMovies.Controllers
{
	public class CustomersController : Controller
	{
		// GET: Customer
		public ActionResult Index()
		{
			var customers = GetCustomers();

			return View(customers);
		}

		public ActionResult Details(int id)
		{
			var customerDetail = GetCustomers().FirstOrDefault(a => a.Id == id);

			return View(customerDetail);
		}

		[Route(@"customers/details/{id}")]
		private IEnumerable<CustomerModels> GetCustomers()
		{
			return new List<CustomerModels>()
			{
				new CustomerModels(){Id = 1, Name = "Akira Hassuda" },
				new CustomerModels(){Id = 2, Name = "Kyoshi Hassuda"}
			};
		}
	}
}