using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AkiraMovies.Models;
using AkiraMovies.ViewModels;

namespace AkiraMovies.Controllers
{
	public class CustomersController : Controller
	{
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
		{
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();

			return View(customers);
		}

		public ActionResult Details(int id)
		{
			var customerDetail = _context.Customers.Include(c => c.MembershipType).FirstOrDefault(a => a.Id == id);

			return View(customerDetail);
		}

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {


            return View();
        }

	}
}