using AkiraMovies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<GenreModels> Genres { get; set; }

		public int? Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		[Required]
		[Display(Name= "Genre")]
		public int? GenreId { get; set; }

		[Required]
		[Display(Name= "Release Date")]
		public DateTime? ReleaseDate { get; set; }

		[Required]
		[Range(1,20)]
		[Display(Name= "Number in Stock")]
		public int? NumberInStock { get; set; }

		public MovieModels Movie { get; set; }
		public string Title
		{
			get
			{
				return Id != 0 ? "Edit Movie" : "New Movie";
			}
		}

		public MovieFormViewModel()
		{
			Id = 0;
		}

		public MovieFormViewModel(MovieModels movie)
		{
			Id = movie.Id;
			Name = movie.Name;
			ReleaseDate = movie.ReleaseDate;
			NumberInStock = movie.NumberInStock;
			GenreId = movie.GenreId;
		}
	}
}