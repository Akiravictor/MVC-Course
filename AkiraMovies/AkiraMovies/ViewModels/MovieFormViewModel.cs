using AkiraMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiraMovies.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<GenreModels> Genres { get; set; }
		public MovieModels Movie { get; set; }
		public string Title
		{
			get
			{
				if (Movie != null && Movie.Id != 0)
					return "Edit Movie";

				return "New Movie";
			}
		}
	}
}