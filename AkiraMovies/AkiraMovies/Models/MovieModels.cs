using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.Models
{
	public class MovieModels
	{
		public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public GenreModels Genre { get; set; }

		[Required]
		[Display(Name = "Genre")]
		public int GenreId { get; set; }

		[Display(Name = "Release Date")]
		public DateTime ReleaseDate { get; set; }

		[Display(Name = "Added Date")]
		public DateTime AddedDate { get; set; }

		[Display(Name = "Number in Stock")]
		public int NumberInStock { get; set; }
	}
}