using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AkiraMovies.Models;

namespace AkiraMovies.ViewModels
{
	public class RandomMovieViewModel
	{
		public MovieModels Movie { get; set; }
		public List<CustomerModels> Customers { get; set; }
	}
}